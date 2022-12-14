using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Serialization;
using System.Text;
using System.Net;
using System;

namespace EZXR.NET
{
    /// <summary>
    /// 抽象url
    /// </summary>
    public abstract class BaseHttpCreate
    {
        private const string TAG = "BASEHTTPCREATE";
        private const int DEFAULT_CONNECTION_TIMEOUT = 5000;
        private const int MAX_CONNECTION_COUNT = 10;
        private BaseRequest mRequest;

        public BaseHttpCreate(BaseRequest request)
        {
            mRequest = request;
        }

        public abstract string Url();

        public abstract string Body();

        public abstract string ContentType();

        public abstract Dictionary<string, string> Headers();

        public abstract string strHeaders();

        public abstract int Timeout();

        public abstract int MaxConnectionCount();

        public abstract string Method();

        protected string GenerateUrl()
        {
            string url =  mRequest.GetDomain() + mRequest.GetApi();

            //判断querymap
            string queryString = GetQueryString(mRequest.GetQueryMap());
            if (!string.IsNullOrEmpty(queryString))
            {
                url += ("?" + queryString);
            }
            InsightDebug.Log("url", url);
            return url;
        }
        protected string GenerateJsonBody()
        {
            string content = null;
            if(mRequest!=null && mRequest.GetBodyMap()!=null && mRequest.GetBodyMap().Count > 0)
            {
                content = JsonUtil.Serialize(mRequest.GetBodyMap());
            }
            InsightDebug.Log("content", content);
            return content;
        }

        protected string GenerateJsonHeader()
        {
            string header = null;
            if (mRequest != null && mRequest.GetHeadMap() != null && mRequest.GetHeadMap().Count > 0)
            {
                header = JsonUtil.Serialize(mRequest.GetHeadMap());
            }
            InsightDebug.Log("header", header);
            return header;
        }

        protected int GetTimeout()
        {
            return mRequest.GetTimeout() == 0 ? DEFAULT_CONNECTION_TIMEOUT : mRequest.GetTimeout();
        }

        /// <summary>
        /// 最大连接数量
        /// </summary>
        /// <returns></returns>
        protected int GetMaxConnectionCount()
        {
            return MAX_CONNECTION_COUNT;
        }

        protected Dictionary<string,string> GetHeaders()
        {
            return mRequest.GetHeadMap();
        }

        private string GetQueryString(Dictionary<string ,object> dict)
        {
            if(dict!=null && dict.Count > 0)
            {
               return EncodeParams(ConverObjectToValueString(dict), Encoding.UTF8);
            }
            return null;
        }
        private Dictionary<string,string> ConverObjectToValueString(Dictionary<string, object> dic)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if(dic !=null && dic.Count > 0)
            {
                foreach(KeyValuePair<string,object> kv  in dic)
                {
                    result.Add(kv.Key, kv.Value.ToString());
                }
            }
            return result;
        }

        private string  EncodeParams(Dictionary<string,string> dic,Encoding encoding)
        {
            try
            {
                if (dic != null && dic.Count > 0)
                {
                    int index = 0;
                    StringBuilder sb = new StringBuilder();
                    var it = dic.GetEnumerator();
                    while (it.MoveNext())
                    {
                        KeyValuePair<string, string> current = it.Current;
                        if (!string.IsNullOrEmpty(current.Key) && !string.IsNullOrEmpty(current.Value))
                        {
                            if (index > 0)
                            {
                                sb.Append("&");
                            }
                            sb.Append(WebUtility.UrlEncode(current.Key));
                            sb.Append("=");
                            sb.Append(WebUtility.UrlEncode(current.Value));
                            index++;
                        }
                    }
                    return sb.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                InsightDebug.LogError(TAG, "Thow Exception " + encoding + e);         
            }
            return null;
        }
    }
}
