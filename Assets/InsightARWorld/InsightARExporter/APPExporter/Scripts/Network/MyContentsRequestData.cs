using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARWorldEditor
{
    [Serializable]
    public class MyContentsRequestData : ARWorldEditor.BaseRequestData
    {
        public MyContentsRequestData(BaseAuthRequestData baseRequestData)
        {
            this.sign = baseRequestData.sign;
            this.nonce = baseRequestData.nonce;
            this.t = baseRequestData.t;
            this.token = baseRequestData.token;
        }

        public override void ResetTimeStamp(long timestamp)
        {
        }
    }
}
