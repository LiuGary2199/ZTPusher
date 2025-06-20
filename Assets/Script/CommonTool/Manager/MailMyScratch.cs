using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking.Types;

public class MailMyScratch : MonoBehaviour
{
    //获取IOS函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void openRateUsUrl(string appId);
#endif

    public static MailMyScratch instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Range;

    private void Awake()
    {
        instance = this;
    }

    public void GibeAPOatTurkey()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=" + Range);
#endif
#if UNITY_IOS
        openRateUsUrl(Range);
#endif
    }
}
