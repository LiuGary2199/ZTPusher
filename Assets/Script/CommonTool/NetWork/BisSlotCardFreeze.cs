/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class BisSlotCardFreeze 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Wish;
    //post成功回调
    public Action<UnityWebRequest> CardSeabird;
    //post失败回调
    public Action CardSoar;
    public BisSlotCardFreeze(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Wish = form;
        CardSeabird = success;
        CardSoar = fail;
    }
}
