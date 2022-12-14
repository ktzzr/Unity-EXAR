using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZXR.NET;
using UnityEngine.Networking;
using System.Text;

/// <summary>
/// 封装request post form data
/// </summary>
public class HttpRequestPostFormData : HttpRequestCreateBase
{
    private WWWForm formData;

    public static HttpRequestPostFormData Post(string _uri,WWWForm _formData)
    {
        HttpRequestPostFormData requestPostFormData = new HttpRequestPostFormData();
        requestPostFormData.uri = _uri;
        requestPostFormData.formData = _formData;
        return requestPostFormData;
    }

    public override  void CreateWebRequest()
    {
        unityWebRequest = GenerateWebRequest();
    }

    private UnityWebRequest GenerateWebRequest()
    {
        return UnityWebRequest.Post(uri, formData);
    }
}
