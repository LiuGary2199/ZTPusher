using System;
using System.Collections;
using com.adjust.sdk;
using UnityEngine;
using Random = UnityEngine.Random;

public class ElicitNoseScratch : MonoBehaviour
{
    public static ElicitNoseScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("adjustID")]
    public string StrongID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string sv_ADPuttNoseRear= "sv_ADJustInitType";

    //adjust 时间戳
    private string Go_ADPuttUser= "sv_ADJustTime";

    //adjust行为计数器
    public int _ChronicPaint{ get; private set; }


    private void Awake()
    {
        Instance = this;
        AutoTineScratch.YouLaunch(Go_ADPuttUser, CoalSkin.Evening().ToString());

#if UNITY_IOS
        AutoTineScratch.YouLaunch(sv_ADPuttNoseRear, AdjustStatus.OpenAsAct.ToString());
        ElicitNose();
#endif
    }

    private void Start()
    {
        _ChronicPaint = 0;
    }


    void ElicitNose()
    {
        AdjustConfig adjustConfig = new AdjustConfig(StrongID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        Adjust.start(adjustConfig);

        StartCoroutine(AutoElicitFend());
    }

    private IEnumerator AutoElicitFend()
    {
        while (true)
        {
            string adjustAdid = Adjust.getAdid();
            if (string.IsNullOrEmpty(adjustAdid))
            {
                yield return new WaitForSeconds(5);
            }
            else
            {
                AutoTineScratch.YouLaunch(CBuckle.Go_ElicitFend, adjustAdid);
                BisHeadCar.instance.SaltElicitFend();
                yield break;
            }
        }
    }

    public string BuyElicitFend()
    {
        return AutoTineScratch.BuyLaunch(CBuckle.Go_ElicitFend);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string BuyElicitAscent()
    {
        return AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear);
    }

    /*
     *  API
     *  标记老用户
     */
    public void BudPontYou()
    {
        
        print("old user add adjust status");
        AutoTineScratch.YouLaunch(sv_ADPuttNoseRear, AdjustStatus.OldUser.ToString());
        CardHonorDecode.BuyDuctless().SaltHonor("1093", BuyElicitUser());
    }


    /*
     *  API
     *  Adjust 初始化
     */
    public void NoseElicitTine(bool isOldUser = false)
    {
        #if UNITY_IOS
            return;
        #endif
        if (AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear) == "" && isOldUser)
        {
            BudPontYou();
        }
        // 如果后台配置的adjust_init_act_position <= 0，直接初始化
        if (string.IsNullOrEmpty(BisHeadCar.instance.BuckleTine.adjust_init_act_position) || int.Parse(BisHeadCar.instance.BuckleTine.adjust_init_act_position) <= 0)
        {
            AutoTineScratch.YouLaunch(sv_ADPuttNoseRear, AdjustStatus.OpenAsAct.ToString());
        }
        print(" user init adjust by status :" + AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear));
        //用户二次登录 根据标签初始化
        if (AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear) == AdjustStatus.OldUser.ToString() || AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            ElicitNose();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void NorAiePaint(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear) != "") return;
        _ChronicPaint++;
        print(" add up to :" + _ChronicPaint);
        if (string.IsNullOrEmpty(BisHeadCar.instance.BuckleTine.adjust_init_act_position) || _ChronicPaint == int.Parse(BisHeadCar.instance.BuckleTine.adjust_init_act_position))
        {
            ScarElicitNoAie(param2);
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void ScarElicitNoAie(string param2 = "")
    {
        if (AutoTineScratch.BuyLaunch(sv_ADPuttNoseRear) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(BisHeadCar.instance.BuckleTine.adjust_init_rate_act) || int.Parse(BisHeadCar.instance.BuckleTine.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            AutoTineScratch.YouLaunch(sv_ADPuttNoseRear, AdjustStatus.OpenAsAct.ToString());
            ElicitNose();

            // 上报点位 新用户达成 且 初始化
            CardHonorDecode.BuyDuctless().SaltHonor("1091", BuyElicitUser(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            AutoTineScratch.YouLaunch(sv_ADPuttNoseRear, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            CardHonorDecode.BuyDuctless().SaltHonor("1092", BuyElicitUser(), param2);
        }
    }

    
    /*
     * API
     *  重置当前次数
     */
    public void SnailAiePaint()
    {
        print("clear current ");
        _ChronicPaint = 0;
    }


    // 获取启动时间
    private string BuyElicitUser()
    {
        return CoalSkin.Evening() - long.Parse(AutoTineScratch.BuyLaunch(Go_ADPuttUser)) + "";
    }
}


/*
 *@param
 *  OldUser     老用户
 *  OpenAsAct   行为触发且初始化
 *  CloseAsAct  行为触发不初始化
 */
public enum AdjustStatus
{
    OldUser,
    OpenAsAct,
    CloseAsAct
}