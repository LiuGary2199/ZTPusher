using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacantSkin
{
    [HideInInspector] public static string Elicit_TrickleStep; //归因渠道名称 由BisHeadCar的CheckAdjustNetwork方法赋值
    static string Auto_AP; //ApplePie的本地存档 存储第一次进入状态 未来不再受ApplePie开关影响
    static string ChoppyCostStep= "pie"; //正常模式名称
    static string Viscosity; //距离黑名单位置的距离 打点用
    static string Nickel; //进审理由 打点用
    [HideInInspector] public static string KilnLog= ""; //判断流程 打点用

    public static bool AtTract()
    {
        //测试
        //return true;
        ///return true;
        if (PlayerPrefs.HasKey("Save_AP"))  //优先使用本地存档
            Auto_AP = PlayerPrefs.GetString("Save_AP");
        if (string.IsNullOrEmpty(Auto_AP)) //无本地存档 读取网络数据
            ShineOptionTine();

        if (Auto_AP != "P")
            return true;
        else
            return false;
    }

    static void ShineOptionTine() //读取网络数据 判断进入哪种游戏模式
    {
        string OtherChance = "NO"; //进审之后 是否还有可能变正常
        Auto_AP = "P";
        if (BisHeadCar.instance.BuckleTine.apple_pie != ChoppyCostStep) //审模式 
        {
            OtherChance = "YES";
            Auto_AP = "A";
            if (string.IsNullOrEmpty(Nickel))
                Nickel = "ApplePie";
        }
        KilnLog = "0:" + Auto_AP;
        //判断地理位置
        if (!string.IsNullOrEmpty(BisHeadCar.instance.BuckleTine.LocationList) && BisHeadCar.instance.PontTine != null)
        {
            //判断运营商信息
            if (BisHeadCar.instance.PontTine.IsHaveApple)
            {
                Auto_AP = "A";
                if (string.IsNullOrEmpty(Nickel))
                    Nickel = "HaveApple";
            }
            KilnLog += "  1:" + Auto_AP;
            //判断经纬度
            LocationData[] LocationDatas = LitJson.JsonMapper.ToObject<LocationData[]>(BisHeadCar.instance.BuckleTine.LocationList);
            if (LocationDatas != null && LocationDatas.Length > 0 && BisHeadCar.instance.PontTine.lat != 0 && BisHeadCar.instance.PontTine.lon != 0)
            {
                for (int i = 0; i < LocationDatas.Length; i++)
                {
                    float Distance = BuyExchange((float)LocationDatas[i].X, (float)LocationDatas[i].Y,
                    (float)BisHeadCar.instance.PontTine.lat, (float)BisHeadCar.instance.PontTine.lon);
                    Viscosity += Distance.ToString() + ",";
                    if (Distance <= LocationDatas[i].Radius)
                    {
                        Auto_AP = "A";
                        if (string.IsNullOrEmpty(Nickel))
                            Nickel = "Location";
                        break;
                    }
                }
            }
            KilnLog += "  2:" + Auto_AP;
            //判断城市
            string[] HeiCityList = LitJson.JsonMapper.ToObject<string[]>(BisHeadCar.instance.BuckleTine.HeiCity);
            if (!string.IsNullOrEmpty(BisHeadCar.instance.PontTine.regionName) && HeiCityList != null && HeiCityList.Length > 0)
            {
                for (int i = 0; i < HeiCityList.Length; i++)
                {
                    if (HeiCityList[i] == BisHeadCar.instance.PontTine.regionName
                    || HeiCityList[i] == BisHeadCar.instance.PontTine.city)
                    {
                        Auto_AP = "A";
                        if (string.IsNullOrEmpty(Nickel))
                            Nickel = "City";
                        break;
                    }
                }
            }
            KilnLog += "  3:" + Auto_AP;
            //判断黑名单
            string[] HeiIPs = LitJson.JsonMapper.ToObject<string[]>(BisHeadCar.instance.BuckleTine.HeiNameList);
            if (HeiIPs != null && HeiIPs.Length > 0 && !string.IsNullOrEmpty(BisHeadCar.instance.PontTine.query))
            {
                string[] IpNums = BisHeadCar.instance.PontTine.query.Split('.');
                for (int i = 0; i < HeiIPs.Length; i++)
                {
                    string[] HeiIpNums = HeiIPs[i].Split('.');
                    bool isMatch = true;
                    for (int j = 0; j < HeiIpNums.Length; j++) //黑名单IP格式可能是任意位数 根据位数逐个比对
                    {
                        if (HeiIpNums[j] != IpNums[j])
                            isMatch = false;
                    }
                    if (isMatch)
                    {
                        Auto_AP = "A";
                        if (string.IsNullOrEmpty(Nickel))
                            Nickel = "IP";
                        break;
                    }
                }
            }
            KilnLog += "  4:" + Auto_AP;
        }
        KilnLog += "  5:" + Auto_AP;
        //判断自然量
        if (!string.IsNullOrEmpty(BisHeadCar.instance.BuckleTine.fall_down))
        {
            if (BisHeadCar.instance.BuckleTine.fall_down == "bottom") //仅判断Organic
            {
                if (Elicit_TrickleStep == "Organic") //打开自然量 且 归因渠道是Organic 审模式
                {
                    Auto_AP = "A";
                    if (string.IsNullOrEmpty(Nickel))
                        Nickel = "FallDown";
                }
            }
            else if (BisHeadCar.instance.BuckleTine.fall_down == "down") //判断Organic + NoUserConsent
            {
                if (Elicit_TrickleStep == "Organic" || Elicit_TrickleStep == "No User Consent") //打开自然量 且 归因渠道是Organic或NoUserConsent 审模式
                {
                    Auto_AP = "A";
                    if (string.IsNullOrEmpty(Nickel))
                        Nickel = "FallDown";
                }
            }
        }
        KilnLog += "  6:" + Auto_AP;

        PlayerPrefs.SetString("Save_AP", Auto_AP);
        PlayerPrefs.SetString("OtherChance", OtherChance);
        //打点
        if (!string.IsNullOrEmpty(AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt)))
            SaltHonor();


        //本地log
        Debug.Log("++++++判断流程： " + KilnLog);
        if (BisHeadCar.instance.PontTine != null)
        {
            string Head= "游戏模式：" + (Auto_AP == "A" ? "审" : "正常")
                       + "\n进审理由：" + Nickel
                       + "\n开关： " + BisHeadCar.instance.BuckleTine.apple_pie
                       + "\n是否包含苹果： " + BisHeadCar.instance.PontTine.IsHaveApple
                       + "\n位置黑名单： " + BisHeadCar.instance.BuckleTine.LocationList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户位置： " + BisHeadCar.instance.PontTine.lat + "," + BisHeadCar.instance.PontTine.lon
                       + "\n黑名单城市： " + BisHeadCar.instance.BuckleTine.HeiCity?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户城市: " + BisHeadCar.instance.PontTine.regionName
                       + "\n与黑名单地点距离： " + Viscosity
                       + "\nIP黑名单： " + BisHeadCar.instance.BuckleTine.HeiNameList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户IP： " + BisHeadCar.instance.PontTine.query
                       + "\n自然量开关： " + BisHeadCar.instance.BuckleTine.fall_down
                       + "\n归因渠道： " + Elicit_TrickleStep
                       + "\n接口返回信息： " + BisHeadCar.instance.PontTineSad;
            Debug.Log("++++++" + Head);
        }
    }
    static float BuyExchange(float lat1, float lon1, float lat2, float lon2)
    {
        const float R = 6371f; // 地球半径，单位：公里
        float latDistance = Mathf.Deg2Rad * (lat2 - lat1);
        float lonDistance = Mathf.Deg2Rad * (lon2 - lon1);
        float a = Mathf.Sin(latDistance / 2) * Mathf.Sin(latDistance / 2)
               + Mathf.Cos(Mathf.Deg2Rad * lat1) * Mathf.Cos(Mathf.Deg2Rad * lat2)
               * Mathf.Sin(lonDistance / 2) * Mathf.Sin(lonDistance / 2);
        float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return R * c * 1000; // 距离，单位：米
    }

    public static void SaltHonor()
    {
        //打点
        if (BisHeadCar.instance.PontTine != null)
        {
            string Info1 = "[" + (Auto_AP == "A" ? "审" : "正常")
                                       + "] [" + Nickel + "]";
            string Info2 = "[" + BisHeadCar.instance.PontTine.lat + "," + BisHeadCar.instance.PontTine.lon
                           + "] [" + BisHeadCar.instance.PontTine.regionName
                           + "] [" + Viscosity + "]";
            string Info3 = "[" + BisHeadCar.instance.PontTine.query
                           + "] [" + Elicit_TrickleStep + "]";
            CardHonorDecode.BuyDuctless().SaltHonor("3000", Info1, Info2, Info3);
        }
        else
            CardHonorDecode.BuyDuctless().SaltHonor("3000", "No UserData");
        CardHonorDecode.BuyDuctless().SaltHonor("3001", (Auto_AP == "A" ? "审" : "正常"), KilnLog, BisHeadCar.instance.TineDumb);
        PlayerPrefs.SetInt("SendedEvent", 1);
    }

    public static bool AtShroud()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool AtPonytail()
    {
        return Screen.height > Screen.width;
    }


}
