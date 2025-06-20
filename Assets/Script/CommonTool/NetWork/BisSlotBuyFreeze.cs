/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class BisSlotBuyFreeze 
{
    //get的url
    public string Bay;
    //get成功的回调
    public Action<UnityWebRequest> BuySeabird;
    //get失败的回调
    public Action BuySoar;
    public BisSlotBuyFreeze(string url,Action<UnityWebRequest> success,Action fail)
    {
        Bay = url;
        BuySeabird = success;
        BuySoar = fail;
    }
   
}
