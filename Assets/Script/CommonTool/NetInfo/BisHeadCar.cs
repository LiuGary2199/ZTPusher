/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using com.adjust.sdk;
using System.Globalization;
//using MoreMountains.NiceVibrations;

public class BisHeadCar : MonoBehaviour
{

    public static BisHeadCar instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string ForkBay;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string ForkFacetBay;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string ForkBuckleBay;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string ForkUserBay;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string ForkElicitBay;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string DramBomb= "20000";
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("DataFrom")]public string TineDumb; //数据来源 打点用
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]    //channel渠道平台
#if UNITY_IOS
    public string Anxiety= "AppStore";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string DepleteStep{ get { return Application.identifier; } }
    //登录url
    private string FacetBay= "";
    //配置url
    private string BuckleBay= "";
    //更新AdjustId url
    private string ElicitBay= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Dynamic= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public ShrinkTine BuckleTine;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init NoseTine;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    
    public GameData DramTine;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    
    //ADScratch
    public GameObject IDScratch;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Belt;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string See;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Rise;
    int Arise_Daily= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Arise= false;
    //ios 获取idfa函数声明
#if UNITY_IOS
    //[DllImport("__Internal")]
    //internal extern static void getIDFA();
#endif
    void Awake()
    {

        //CultureInfo russianCulture = new CultureInfo("ru-RU");
        //System.Threading.Thread.CurrentThread.CurrentCulture = russianCulture;
        instance = this;
        FacetBay = ForkFacetBay + DramBomb + "&channel=" + Anxiety + "&version=" + Application.version;
        BuckleBay = ForkBuckleBay + DramBomb + "&channel=" + Anxiety + "&version=" + Application.version;
        ElicitBay = ForkElicitBay + DramBomb;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            //getIDFA();
            string idfv = UnityEngine.iOS.Device.vendorIdentifier;
            AutoTineScratch.YouLaunch("idfv", idfv);
#endif
        }
        else
        {
            Facet();           //编辑器登录
        }
        //获取config数据
        BuyBuckleTine();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void BeltHopper(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Belt = gaid_str; 
        if (Belt == null || Belt == "")
        {
            Belt = AutoTineScratch.BuyLaunch("gaid");
        }
        else
        {
            AutoTineScratch.YouLaunch("gaid", Belt);
        }
        Arise_Daily++;
        if (Arise_Daily == 2)
        {
            Facet();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void SeeHopper(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        See = aid_str;
        if (See == null || See == "")
        {
            See = AutoTineScratch.BuyLaunch("aid");
        }
        else
        {
            AutoTineScratch.YouLaunch("aid", See);
        }
        Arise_Daily++;
        if (Arise_Daily == 2)
        {
            Facet();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void RiseSeabird(string message)
    {
        Debug.Log("idfa success:" + message);
        Rise = message;
        AutoTineScratch.YouLaunch("idfa", Rise);
        Facet();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void RiseSoar(string message)
    {
        Debug.Log("idfa fail");
        Rise = AutoTineScratch.BuyLaunch("idfa");
        Facet();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Facet()
    {
        //提现登录
        CashOutManager.BuyDuctless().Login();
        //获取本地缓存的Local用户ID
        string localId = AutoTineScratch.BuyLaunch(CBuckle.Go_DozenPontIt);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            AutoTineScratch.YouLaunch(CBuckle.Go_DozenPontIt, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = FacetBay + "&" + "randomKey" + "=" + localId + "&idfa=" + Rise + "&packageName=" + DepleteStep;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = FacetBay + "&" + "randomKey" + "=" + localId + "&gaid=" + Belt + "&androidId=" + See + "&packageName=" + DepleteStep;
        }
        else //编辑器
        {
            url = FacetBay + "&" + "randomKey" + "=" + localId + "&packageName=" + DepleteStep;
        }

        //获取国家信息
        LeoProsper(() => {
            url += "&country=" + Dynamic;
            //登录请求
            BisSlotScratch.BuyDuctless().HttpBuy(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    AutoTineScratch.YouLaunch("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    AutoTineScratch.YouLaunch(CBuckle.Go_DozenShrinkIt, serverUserData.data.ToString());

                    SaltElicitFend();
                    if (PlayerPrefs.GetInt("SendedEvent") != 1 && !String.IsNullOrEmpty(VacantSkin.KilnLog))
                        VacantSkin.SaltHonor();

                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void LeoProsper(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Dynamic))
        {
            ////获取国家超时返回
            //StartCoroutine(NetWorkTimeOut(() =>
            //{
            //    if (!callBackReady)
            //    {
            //        country = "";
            //        callBackReady = true;
            //        cb?.Invoke();
            //    }
            //}));
            BisSlotScratch.BuyDuctless().HttpBuy("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Dynamic = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Dynamic);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Dynamic = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void BuyBuckleTine()
    {
        Debug.Log("GetConfigData:" + BuckleBay);
        //StartCoroutine(NetWorkTimeOut(() =>
        //{
        //    GetLoactionData();
        //}));

        //获取并存入Config
        BisSlotScratch.BuyDuctless().HttpBuy(BuckleBay,
        (data) => {
            TineDumb = "OnlineData";
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            AutoTineScratch.YouLaunch("OnlineData", data.downloadHandler.text);
            YouBuckleTine(data.downloadHandler.text);
        },
        () => {
            BuyCellularTine();
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void BuyCellularTine()
    {
        //是否有缓存
        if (AutoTineScratch.BuyLaunch("OnlineData") == "" || AutoTineScratch.BuyLaunch("OnlineData").Length == 0)
        {
            TineDumb = "LocalData_Updated"; //已联网更新过的数据
            Debug.Log("本地数据");
            TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
            YouBuckleTine(json.text);
        }
        else
        {
            TineDumb = "LocalData_Original"; //原始数据
            Debug.Log("服务器缓存数据");
            YouBuckleTine(AutoTineScratch.BuyLaunch("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void YouBuckleTine(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (BuckleTine == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            BuckleTine = rootData.data;
            switch (AutoTineScratch.BuyLaunch(CBuckle.sys_Covering))
            {
                case "Russian":
                    NoseTine = JsonMapper.ToObject<Init>(BuckleTine.init_ru);
                    DramTine = JsonMapper.ToObject<GameData>(BuckleTine.game_data_ru);
                    break;
                case "Portuguese (Brazil)":
                    NoseTine = JsonMapper.ToObject<Init>(BuckleTine.init_br);
                    DramTine = JsonMapper.ToObject<GameData>(BuckleTine.game_data_br);
                    break;
                case "English":
                    NoseTine = JsonMapper.ToObject<Init>(BuckleTine.init_us);
                    DramTine = JsonMapper.ToObject<GameData>(BuckleTine.game_data_us);
                    break;
                case "Japanese":
                    NoseTine = JsonMapper.ToObject<Init>(BuckleTine.init_jp);
                    DramTine = JsonMapper.ToObject<GameData>(BuckleTine.game_data_jp);
                    break;
                default:
                    NoseTine = JsonMapper.ToObject<Init>(BuckleTine.init);
                    DramTine = JsonMapper.ToObject<GameData>(BuckleTine.game_data);
                    break;
            }
   
            NoseTine.cash_group_real = new MultiGroup[NoseTine.cash_group.Length];
            for (int i = 0; i < NoseTine.cash_group.Length; i++)
            {
                MultiGroup multiGroup = new MultiGroup();
                multiGroup.max = NoseTine.cash_group[i].max;
                multiGroup.multi = double.Parse(NoseTine.cash_group[i].multi);
                multiGroup.weight_multi = NoseTine.cash_group[i].weight_multi;
                NoseTine.cash_group_real[i] = multiGroup;
            }
            BuyPontHead();
            if (!PlayerPrefs.HasKey(CBuckle.Toe_FeeSH))
            {
                if (BuckleTine.apple_pie != "apple")
                {
                    Debug.Log("sys_AppSH_______________Pass");
                    PlayerPrefs.SetInt(CBuckle.Toe_FeeSH, 1);
                }
            }
        }
        // if (ConfigData == null)
        // {
        //     RootData rootData = JsonMapper.ToObject<RootData>(configJson);
        //     ConfigData = rootData.data;
        //     InitData = JsonMapper.ToObject<Init>(ConfigData.init);
        //     GameData = JsonMapper.ToObject<GameData>(ConfigData.game_data);
        //     GetUserInfo();
        // }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void DramTopic()
    {
        //打开admanager
        IDScratch.SetActive(true);
        //进度条可以继续
        Arise = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator BisSlotUserHub(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void SaltElicitFend()
    {
        string serverId = AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt);
        string adjustId = ElicitNoseScratch.Instance.BuyElicitFend();
        if (string.IsNullOrEmpty(serverId) || string.IsNullOrEmpty(adjustId))
        {
            return;
        }

        string url = ElicitBay + "&serverId=" + serverId + "&adid=" + adjustId;
        BisSlotScratch.BuyDuctless().HttpBuy(url,
            (data) => {
                Debug.Log("服务器更新adjust adid 成功" + data.downloadHandler.text);
            },
            () => {
                Debug.Log("服务器更新adjust adid 失败");
            });
        CashOutManager.BuyDuctless().ReportAdjustID();
    }
    //轮询检查Adjust归因信息
    int ShinePaint= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Event_TrackerName")]public string Honor_TrickleStep; //打点用参数
    bool _ShineOk= false;
    [HideInInspector]
    public bool ElicitTrickle_Topic    {
        get
        {
            if (Application.isEditor) //编译器跳过检查
                return true;
            return _ShineOk;
        }
    }
    public void ShineElicitMammoth() //检查Adjust归因信息
    {
        if (Application.isEditor) //编译器跳过检查
            return;
        if (!string.IsNullOrEmpty(Honor_TrickleStep)) //已经拿到归因信息
            return;

        CancelInvoke(nameof(ShineElicitMammoth));
        if (!string.IsNullOrEmpty(BuckleTine.fall_down) && BuckleTine.fall_down == "fall")
        {
            print("Adjust 无归因相关配置或未联网 跳过检查");
            _ShineOk = true;
        }
        try
        {
            AdjustAttribution Head= Adjust.getAttribution();
            print("Adjust 获取信息成功 归因渠道：" + Head.trackerName);
            Honor_TrickleStep = "TrackerName: " + Head.trackerName;
            VacantSkin.Elicit_TrickleStep = Head.trackerName;
            _ShineOk = true;
        }
        catch (System.Exception e)
        {
            ShinePaint++;
            Debug.Log("Adjust 获取信息失败：" + e.Message + " 重试次数：" + ShinePaint);
            if (ShinePaint >= 10)
                _ShineOk = true;
            Invoke(nameof(ShineElicitMammoth), 1);
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("UserDataStr")]
    //获取用户信息
    public string PontTineSad= "";
[UnityEngine.Serialization.FormerlySerializedAs("UserData")]    public UserInfoData PontTine;
    int BuyPontHeadPaint= 0;
    void BuyPontHead()
    {
        //还有进入正常模式的可能
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "YES")
            PlayerPrefs.DeleteKey("Save_AP");
        //已经记录过用户信息 跳过检查
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "NO")
        {
            DramTopic();
            return;
        }

        //检查归因渠道信息
        ShineElicitMammoth();
        //获取用户信息
        string CheckUrl = ForkBay + "/api/client/user/checkUser";
        BisSlotScratch.BuyDuctless().HttpBuy(CheckUrl,
        (data) =>
        {
            PontTineSad = data.downloadHandler.text;
            print("+++++ 获取用户数据 成功" + PontTineSad);
            UserRootData rootData = JsonMapper.ToObject<UserRootData>(PontTineSad);
            PontTine = JsonMapper.ToObject<UserInfoData>(rootData.data);
            if (PontTineSad.Contains("apple")
            || PontTineSad.Contains("Apple")
            || PontTineSad.Contains("APPLE"))
                PontTine.IsHaveApple = true;
            DramTopic();
        }, () => { });
        Invoke(nameof(MyBuyPontHead), 1);
    }
    void MyBuyPontHead()
    {
        if (!Arise)
        {
            BuyPontHeadPaint++;
            if (BuyPontHeadPaint < 10)
            {
                print("+++++ 获取用户数据失败 重试： " + BuyPontHeadPaint);
                BuyPontHead();
            }
            else
            {
                print("+++++ 获取用户数据 失败次数过多，放弃");
                DramTopic();
            }
        }
    }

}
