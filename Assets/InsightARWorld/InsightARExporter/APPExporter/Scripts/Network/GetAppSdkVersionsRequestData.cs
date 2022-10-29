using System.Collections;
using System;
using Newtonsoft.Json;

namespace ARWorldEditor
{
    public class GetAppSdkVersionsRequestData
    {
        [JsonIgnore]
        public long appId { get; set; }
    }
}