using System;
using System.Collections;
using System.Collections.Generic;
using ARWorldEditor;
using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
#endif

namespace ARWorldEditor
{
    public class FileRequest
    {
        public Action<string> onSuccess;
        public Action<string,string> onError;
        public Action<float> onUpload;
        public Action<float> onDownload;
    }

    public class TextureRequest
    {
        public Action<Texture2D> onSuccess;
        public Action<string, string> onError;
    }

    public class HttpManager : UnitySingleton<HttpManager>
    {
        #region params
        private const string TAG = "HttpManager";
        private Dictionary<IHttpRequest, IEnumerator> httpRequests;
        //记录文件数据请求，可以复用
        private Dictionary<string, List<FileRequest>> fileRequests;
        private Dictionary<string, List<TextureRequest>> textureRequests;
#endregion

#region http
        private void OnEnable()
        {
            Init();

#if UNITY_EDITOR
            //解决editor下没有update问题
            EditorApplication.update += Update;
#endif
        }

        private void Update()
        {
            if (httpRequests != null && httpRequests.Count > 0)
            {
                List<IHttpRequest> requestList = new List<IHttpRequest>();
                foreach (var httpRequest in httpRequests.Keys)
                {
                    (httpRequest as IUpdateProgress)?.UpdateProgress();
                    requestList.Add(httpRequest);
                }
            }
        }

        /// <summary>
        /// close
        /// </summary>
        private void OnDisable()
        {
            
        }

        private void OnDestroy()
        {
            Close();
        }

        /// <summary>
        /// init
        /// </summary>
        public void Init()
        {
            httpRequests = new Dictionary<IHttpRequest, IEnumerator>();
            fileRequests = new Dictionary<string, List<FileRequest>>();
            textureRequests = new Dictionary<string, List<TextureRequest>>();
        }

        /// <summary>
        /// post
        /// </summary>
        /// <param name="request"></param>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        public void Post(BaseRequest request, HttpRequestWrap wrap)
        {
            UnityHttpRequest unityHttpRequest = (UnityHttpRequest)UnityHttpRequest.Post(request);
            unityHttpRequest.AddListener(wrap.OnResult, wrap.OnError);
            var requestCoroutine = unityHttpRequest.Send();
#if UNITY_EDITOR
            EditorCoroutines.StartCoroutine(requestCoroutine, this);
#else
            StartCoroutine(requestCoroutine);
#endif
            if (httpRequests == null) httpRequests = new Dictionary<IHttpRequest, IEnumerator>();
            httpRequests.Add(unityHttpRequest, requestCoroutine);
        }

        /// <summary>
        /// get
        /// </summary>
        /// <param name="request"></param>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        public void Get(BaseRequest request, HttpRequestWrap wrap)
        {
            UnityHttpRequest unityHttpRequest = (UnityHttpRequest)UnityHttpRequest.Get(request);
            unityHttpRequest.AddListener(wrap.OnResult, wrap.OnError);
            var requestCoroutine = unityHttpRequest.Send();
#if UNITY_EDITOR
            EditorCoroutines.StartCoroutine(requestCoroutine, this);
#else
            StartCoroutine(requestCoroutine);
#endif
            if (httpRequests == null) httpRequests = new Dictionary<IHttpRequest, IEnumerator>();
            httpRequests.Add(unityHttpRequest, requestCoroutine);
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="filePath"></param>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        public void GetFile(string uri,string filePath,Action<string> onSuccess, Action<string, string> onError,
            Action<float> onUpload, Action<float> onDownload)
        {
            Debug.Log("get file uri " + uri);
            string hashCode = uri.GetHashCode().ToString();
            UnityHttpRequest unityHttpRequest = (UnityHttpRequest)UnityHttpRequest.GetFile(uri, filePath);

            FileRequest fileRequest = new FileRequest();
            fileRequest.onSuccess = onSuccess;
            fileRequest.onError = onError;
            fileRequest.onUpload = onUpload;
            fileRequest.onDownload = onDownload;

            List<FileRequest> request = null;

            if (fileRequests == null) fileRequests = new Dictionary<string, List<FileRequest>>();

            if (fileRequests.ContainsKey(hashCode))
            {
                fileRequests[hashCode].Add(fileRequest);
            }
            else
            {
                request = new List<FileRequest>();
                request.Add(fileRequest);
                fileRequests.Add(hashCode, request);
            }

            unityHttpRequest.AddListener((HttpResponse resp) =>
            {
                List<FileRequest> requests;
                if(fileRequests.TryGetValue(hashCode,out requests)){
                    if (requests == null || requests.Count == 0) return;
                    for(int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onSuccess?.Invoke(filePath);
                    }
                }
                fileRequests.Remove(hashCode);
            }, (string code, HttpResponse response) =>
            {
                if (onError != null)
                {
                    onError(code, "Http Or Network Error");
                }
                List<FileRequest> requests;
                if (fileRequests.TryGetValue(hashCode, out requests))
                {
                    if (requests == null || requests.Count == 0) return;
                    for (int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onError?.Invoke(code, "Http Or Network Error");
                    }
                }
                fileRequests.Remove(hashCode);
            },(float progress)=>
            {
                List<FileRequest> requests;
                if (fileRequests.TryGetValue(hashCode, out requests))
                {
                    if (requests == null || requests.Count == 0) return;
                    for (int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onUpload?.Invoke(progress);
                    }
                }
            }, (float progress) =>
            {
                List<FileRequest> requests;
                if (fileRequests.TryGetValue(hashCode, out requests))
                {
                    if (requests == null || requests.Count == 0) return;
                    for (int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onDownload?.Invoke(progress);
                    }
                }
            });
            var requestCoroutine = unityHttpRequest.Send();
#if UNITY_EDITOR
            EditorCoroutines.StartCoroutine(requestCoroutine, this);
#else
            StartCoroutine(requestCoroutine);
#endif
            httpRequests.Add(unityHttpRequest, requestCoroutine);
        }

        /// <summary>
        /// 下载贴图
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        public void GetTexture(string uri,Action<Texture2D> onSuccess,Action<string,string> onError,Action<float> onUpload,Action<float> onDownload)
        {
            Debug.Log("Get Texture uri " + uri);
            string hashCode = uri.GetHashCode().ToString();

            TextureRequest textureRequest = new TextureRequest();
            textureRequest.onSuccess = onSuccess;
            textureRequest.onError = onError;
            if (textureRequests == null) textureRequests = new Dictionary<string, List<TextureRequest>>();

            if (textureRequests.ContainsKey(hashCode))
            {
                textureRequests[hashCode].Add(textureRequest);
            }
            else
            {
                List<TextureRequest> requests = new List<TextureRequest>();
                requests.Add(textureRequest);
                textureRequests.Add(hashCode, requests);
            }

           UnityHttpRequest unityHttpRequest = (UnityHttpRequest)UnityHttpRequest.GetTexture(uri);
            unityHttpRequest.AddListener((HttpResponse resp) =>
            {
                byte[] bytes = resp.Bytes;
                Texture2D texture = new Texture2D(1, 1);
                texture.LoadImage(bytes);
                texture.Apply(false);

                List<TextureRequest> requests;
                if (textureRequests.TryGetValue(hashCode, out requests))
                {
                    if (requests == null || requests.Count == 0) return;
                    for (int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onSuccess?.Invoke(texture);
                    }
                }

                //add cache
                TextureCache.Instance.AddTexture(hashCode, uri, texture);

                textureRequests.Remove(hashCode);

            }, (string code, HttpResponse response) =>
            {
                if (onError != null)
                {
                    onError(code, "Http Or Network Error");
                }

                List<TextureRequest> requests;
                if (textureRequests.TryGetValue(hashCode, out requests))
                {
                    if (requests == null || requests.Count == 0) return;
                    for (int i = 0; i < requests.Count; i++)
                    {
                        requests[i].onError?.Invoke(code, "Http Or Network Error");
                    }
                }
                textureRequests.Remove(hashCode);
            });
            var requestCoroutine = unityHttpRequest.Send();
#if UNITY_EDITOR
            EditorCoroutines.StartCoroutine(requestCoroutine, this);
#else
            StartCoroutine(requestCoroutine);
#endif
            httpRequests.Add(unityHttpRequest, requestCoroutine);
        }

        /// <summary>
        /// abort
        /// </summary>
        /// <param name="request"></param>
        public void Abort(IHttpRequest request)
        {
            request.Abort();
            if (httpRequests.ContainsKey(request))
            {
#if UNITY_EDITOR
                EditorCoroutines.StopCoroutine(httpRequests[request],this);
#else
                StopCoroutine(httpRequests[request]);
#endif
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="request"></param>
        public void Dispose(IHttpRequest request)
        {
            request.Dispose();
            if (httpRequests.ContainsKey(request))
            {
#if UNITY_EDITOR
                EditorCoroutines.StopCoroutine(httpRequests[request], this);
#else
                StopCoroutine(httpRequests[request]);
#endif
            }
        }

        /// <summary>
        /// close
        /// </summary>
        public void Close()
        {
            if (httpRequests != null && httpRequests.Count > 0)
            {
                foreach (var httpRequest in httpRequests.Keys)
                {
                    httpRequest?.Dispose();
                }
            }
            httpRequests.Clear();
            textureRequests.Clear();
            fileRequests.Clear();
        }

#endregion

#region utility
        private IEnumerator SendCoroutine(IHttpRequest request, Action<BaseRequest, object> onSuccess, Action<BaseRequest, int, string> onError)
        {
            yield return request.Send();
            httpRequests.Remove(request);
        }
#endregion
    }
}
