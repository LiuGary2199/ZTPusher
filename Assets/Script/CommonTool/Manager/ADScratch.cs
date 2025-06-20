using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using com.adjust.sdk;
using LitJson;
using DG.Tweening;

public class ADScratch : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]    public string MAX_SDK_KEY= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]    public string MAX_REWARD_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]    public string MAX_INTER_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]
    public bool GoFolk= false;
    public static ADScratch Ductless{ get; private set; }

    private int SlimyWeekday;   // 广告加载失败后，重新加载广告次数
    private bool GoHistoryAd;     // 是否正在播放广告，用于判断切换前后台时是否增加计数

    public int FootExamUserLawlike{ get; private set; }   // 距离上次广告的时间间隔
    public int Playful101{ get; private set; }     // 定时插屏(101)计数器
    public int Playful102{ get; private set; }     // NoThanks插屏(102)计数器
    public int Playful103{ get; private set; }     // 后台回前台插屏(103)计数器

    private string BurrowMammothStep;
    private Action<bool> BurrowReedRelyHopper;    // 激励视频回调
    private bool BurrowSeabird;     // 激励视频是否成功收到奖励
    private string BurrowImage;     // 激励视频的打点

    private string ExperimenterMammothStep;
    private int ExperimenterRear;      // 当前播放的插屏类型，101/102/103
    private string ExperimenterImage;     // 插屏广告的的打点
    public bool DrainUserRemuneration{ get; private set; } // 定时插屏暂停播放

    private List<Action<ADType>> IDSecrecyDeception;    // 广告播放完成回调列表，用于其他系统广告计数（例如商店看广告任务）

    private long BattlefieldBulgeInfection;     // 切后台时的时间戳
    private Ad_CustomData AdviceOnMobileTine; //激励视频自定义数据
    private Ad_CustomData RemunerationOnMobileTine; //插屏自定义数据
    private double RemunerationProboscis= 0;
    private void Awake()
    {
        Ductless = this;
    }

    private void OnEnable()
    {
        DrainUserRemuneration = false;
        GoHistoryAd = false;
        FootExamUserLawlike = 999;  // 初始时设置一个较大的值，不阻塞插屏广告
        BurrowSeabird = false;

        // Android平台将Adjust的adid传给Max；iOS将randomKey传给Max
#if UNITY_ANDROID
        MaxSdk.SetSdkKey(BuyStatueTine.DecryptDES(MAX_SDK_KEY));
        // 将adjust id 传给Max
        string adjustId = AutoTineScratch.GetString(CBuckle.sv_AdjustAdid);
        if (string.IsNullOrEmpty(adjustId))
        {
            adjustId = Adjust.getAdid();
        }
        if (!string.IsNullOrEmpty(adjustId))
        {
            MaxSdk.SetUserId(adjustId);
            MaxSdk.InitializeSdk();
            AutoTineScratch.SetString(CBuckle.sv_AdjustAdid, adjustId);
        }
        else
        {
            StartCoroutine(setAdjustAdid());
        }
#else
        MaxSdk.SetSdkKey(BuyStatueTine.PremiumDES(MAX_SDK_KEY));
        MaxSdk.SetUserId(AutoTineScratch.BuyLaunch(CBuckle.Go_DozenPontIt));
        MaxSdk.InitializeSdk();
#endif

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();

            ComparisonDescribeFly();
            MaxSdk.SetCreativeDebuggerEnabled(true);

            // 每秒执行一次计数
            InvokeRepeating(nameof(VirginStudio), 1, 1);
        };
    }

    IEnumerator FenElicitFend()
    {
        int i = 0;
        while (i < 5)
        {
            yield return new WaitForSeconds(1);
            if (VacantSkin.AtShroud())
            {
                MaxSdk.SetUserId(AutoTineScratch.BuyLaunch(CBuckle.Go_DozenPontIt));
                MaxSdk.InitializeSdk();
                yield break;
            }
            else
            {
                string adjustId = Adjust.getAdid();
                if (!string.IsNullOrEmpty(adjustId))
                {
                    MaxSdk.SetUserId(adjustId);
                    MaxSdk.InitializeSdk();
                    AutoTineScratch.YouLaunch(CBuckle.Go_ElicitFend, adjustId);
                    yield break;
                }
            }
            i++;
        }
        if (i == 5)
        {
            MaxSdk.SetUserId(AutoTineScratch.BuyLaunch(CBuckle.Go_DozenPontIt));
            MaxSdk.InitializeSdk();
        }
    }

    public void ComparisonDescribeFly()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        // Load the first rewarded ad
        ScarDescribeOn();

        // Load the first interstitial
        ScarRemuneration();
    }

    private void ScarDescribeOn()
    {
        MaxSdk.LoadRewardedAd(MAX_REWARD_ID);
    }

    private void ScarRemuneration()
    {
        MaxSdk.LoadInterstitial(MAX_INTER_ID);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // Reset retry attempt
        SlimyWeekday = 0;
        BurrowMammothStep = adInfo.NetworkName;

        AdviceOnMobileTine = new Ad_CustomData();
        AdviceOnMobileTine.Bush_id = CashOutManager.BuyDuctless().Data.UserID;
        AdviceOnMobileTine.Similar = Application.version;
        AdviceOnMobileTine.Fishery_Go = CashOutManager.BuyDuctless().EcpmRequestID();
        AdviceOnMobileTine.Afraid = adInfo.NetworkName;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        SlimyWeekday++;
        double retryDelay = Math.Pow(2, Math.Min(6, SlimyWeekday));

        Invoke(nameof(ScarDescribeOn), (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        TheirCar.BuyDuctless().BgTheirIntent = !TheirCar.BuyDuctless().BgTheirIntent;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        ScarDescribeOn();
        GoHistoryAd = false;
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {

    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
#if UNITY_IOS
        Time.timeScale = 1;
        TheirCar.BuyDuctless().BgTheirIntent = !TheirCar.BuyDuctless().BgTheirIntent;
#endif

        GoHistoryAd = false;
        ScarDescribeOn();
        if (BurrowSeabird)
        {
            BurrowSeabird = false;
            BurrowReedRelyHopper?.Invoke(true);

            GuildOnExamSeabird(ADType.Rewarded);
            CardHonorDecode.BuyDuctless().SaltHonor("9007", BurrowImage);
        }
        else
        {
            //rewardCallBackAction?.Invoke(false);
        }

        // 上报ecpm
        CashOutManager.BuyDuctless().ReportEcpm(adInfo, AdviceOnMobileTine.Fishery_Go, "REWARD");
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        BurrowSeabird = true;
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        CardHonorDecode.BuyDuctless().SaltHonor("9008", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
      //  ElicitNoseScratch.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        string adjustAdid = ElicitNoseScratch.Instance.BuyElicitFend();
        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(adjustAdid))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (rewarded), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Rewarded revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt
        SlimyWeekday = 0;
        ExperimenterMammothStep = adInfo.NetworkName;

        RemunerationOnMobileTine = new Ad_CustomData();
        RemunerationOnMobileTine.Bush_id = CashOutManager.BuyDuctless().Data.UserID;
        RemunerationOnMobileTine.Similar = Application.version;
        RemunerationOnMobileTine.Fishery_Go = CashOutManager.BuyDuctless().EcpmRequestID();
        RemunerationOnMobileTine.Afraid = adInfo.NetworkName;
    }

    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)

        SlimyWeekday++;
        double retryDelay = Math.Pow(2, Math.Min(6, SlimyWeekday));

        Invoke(nameof(ScarRemuneration), (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        TheirCar.BuyDuctless().BgTheirIntent = !TheirCar.BuyDuctless().BgTheirIntent;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.
        ScarRemuneration();
        GoHistoryAd = false;
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        CardHonorDecode.BuyDuctless().SaltHonor("9108", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
      //  ElicitNoseScratch.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(ElicitNoseScratch.Instance.BuyElicitFend()))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (interstitial), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        string adjustAdid = ElicitNoseScratch.Instance.BuyElicitFend();
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Interstitial revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.
#if UNITY_IOS
        Time.timeScale = 1;
        TheirCar.BuyDuctless().BgTheirIntent = !TheirCar.BuyDuctless().BgTheirIntent;
#endif
        ScarRemuneration();

        GuildOnExamSeabird(ADType.Interstitial);
        CardHonorDecode.BuyDuctless().SaltHonor("9107", ExperimenterImage);
        // 上报ecpm
        CashOutManager.BuyDuctless().ReportEcpm(adInfo, RemunerationOnMobileTine.Fishery_Go, "INTER");
    }


    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    /// <param name="callBack"></param>
    /// <param name="index"></param>
    public void HairAdviceKarst(Action<bool> callBack, string index)
    {
        if (GoFolk)
        {
            callBack(true);
            GuildOnExamSeabird(ADType.Rewarded);
            return;
        }

        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(MAX_REWARD_ID);
        BurrowReedRelyHopper = callBack;
        if (rewardVideoReady)
        {
            // 打点
            BurrowImage = index;
            CardHonorDecode.BuyDuctless().SaltHonor("9002", index);
            GoHistoryAd = true;
            BurrowSeabird = false;
            string placement = index + "_" + BurrowMammothStep;
            AdviceOnMobileTine.Dependent_Go = placement;
            MaxSdk.ShowRewardedAd(MAX_REWARD_ID, placement, JsonMapper.ToJson(AdviceOnMobileTine));
        }
        else
        {
            ThoseScratch.BuyDuctless().BuryThose("No ads right now, please try it later.");
            // rewardCallBackAction(false);
        }
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index"></param>
    public void HairRemunerationOn(int index)
    {
        if (index == 101 || index == 102 || index == 103)
        {
            UnityEngine.Debug.LogError("广告点位不允许为101、102、103");
            return;
        }

        HairRemuneration(index);
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index">101/102/103</param>
    /// <param name="customIndex">用户自定义点位</param>
    private void HairRemuneration(int index, int customIndex = 0)
    {
        ExperimenterRear = index;

        if (GoHistoryAd)
        {
            return;
        }

        // 当用户过关数 < trial_MaxNum时，不弹插屏广告
        int sv_trialNum = AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud);
        int trial_MaxNum = int.Parse(BisHeadCar.instance.BuckleTine.trial_MaxNum);
        if (sv_trialNum < trial_MaxNum)
        {
            return;
        }

        // 时间间隔低于阈值，不播放广告
        if (FootExamUserLawlike < int.Parse(BisHeadCar.instance.BuckleTine.inter_freq))
        {
            return;
        }

        if (GoFolk)
        {
            GuildOnExamSeabird(ADType.Interstitial);
            return;
        }

        bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
        if (interstitialVideoReady)
        {
            if (ExperimenterRear == 101)
            {
                RemunerationProboscis = GameUtil.GetInterstitialData();
                UIManager.BuyDuctless().BuryUIVisit(nameof(DifferBoil));
                DifferBoil.Instance.NoseTine(RemunerationProboscis);
                DOVirtual.DelayedCall(1f, () => //停顿
                {
                    UIManager.BuyDuctless().ShaftIfAcidicUIVisit(nameof(DifferBoil));
                    GoHistoryAd = true;
                    // 打点
                    string point = index.ToString();
                    if (customIndex > 0)
                    {
                        point += customIndex.ToString().PadLeft(2, '0');
                    }
                    ExperimenterImage = point;
                    CardHonorDecode.BuyDuctless().SaltHonor("9102", point);
                    string placement = point + "_" + ExperimenterMammothStep;
                    RemunerationOnMobileTine.Dependent_Go = placement;
                    MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(RemunerationOnMobileTine));
                });
            }
            else
            {
                GoHistoryAd = true;
                // 打点
                string point = index.ToString();
                if (customIndex > 0)
                {
                    point += customIndex.ToString().PadLeft(2, '0');
                }
                ExperimenterImage = point;
                CardHonorDecode.BuyDuctless().SaltHonor("9102", point);
                string placement = point + "_" + ExperimenterMammothStep;
                RemunerationOnMobileTine.Dependent_Go = placement;
                MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(RemunerationOnMobileTine));
            }
        }
    }

    /// <summary>
    /// 每秒更新一次计数器 - 101计数器 和 时间间隔计数器
    /// </summary>
    private void VirginStudio()
    {
        FootExamUserLawlike++;

        int relax_interval = int.Parse(BisHeadCar.instance.BuckleTine.relax_interval);
        // 计时器阈值设置为0或负数时，关闭广告101；
        // 播放广告期间不计数；
        if (relax_interval <= 0 || GoHistoryAd)
        {
            return;
        }
        else
        {
            Playful101++;
            if (Playful101 >= relax_interval && !DrainUserRemuneration)
            {
                HairRemuneration(101);
            }
        }
    }

    /// <summary>
    /// NoThanks插屏 - 102
    /// </summary>
    public void GoRetireNorPaint(int customIndex = 0)
    {
        // 用户行为累计次数计数器阈值设置为0或负数时，关闭广告102
        int nextlevel_interval = int.Parse(BisHeadCar.instance.BuckleTine.nextlevel_interval);
        if (nextlevel_interval <= 0)
        {
            return;
        }
        else
        {
            Playful102 = AutoTineScratch.BuyGet("NoThanksCount") + 1;
            AutoTineScratch.YouGet("NoThanksCount", Playful102);
            if (Playful102 >= nextlevel_interval)
            {
                HairRemuneration(102, customIndex);
            }
        }
    }

    /// <summary>
    /// 前后台切换计数器 - 103
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // 切回前台
            if (!GoHistoryAd)
            {
                // 前后台切换时，播放间隔计数器需要累加切到后台的时间
                if (BattlefieldBulgeInfection > 0)
                {
                    FootExamUserLawlike += (int)(CoalSkin.Evening() - BattlefieldBulgeInfection);
                    BattlefieldBulgeInfection = 0;
                }
                // 后台切回前台累计次数，后台配置为0或负数，关闭该广告
                int inter_b2f_count = int.Parse(BisHeadCar.instance.BuckleTine.inter_b2f_count);
                if (inter_b2f_count <= 0)
                {
                    return;
                }
                else
                {
                    Playful103++;
                    if (Playful103 >= inter_b2f_count)
                    {
                        HairRemuneration(103);
                    }
                }
            }
        }
        else
        {
            // 切到后台
            BattlefieldBulgeInfection = CoalSkin.Evening();
        }
    }

    /// <summary>
    /// 暂停定时插屏播放 - 101
    /// </summary>
    public void BulgeUserRemuneration()
    {
        DrainUserRemuneration = true;
    }

    /// <summary>
    /// 恢复定时插屏播放 - 101
    /// </summary>
    public void MaracaUserRemuneration()
    {
        DrainUserRemuneration = false;
    }

    /// <summary>
    /// 更新游戏的TrialNum
    /// </summary>
    /// <param name="num"></param>
    public void ManualDriftSod(int num)
    {
        AutoTineScratch.YouGet(CBuckle.Go_ID_Hotel_Cud, num);
    }

    /// <summary>
    /// 注册看广告的回调事件
    /// </summary>
    /// <param name="callback"></param>
    public void ClearingExamPhysical(Action<ADType> callback)
    {
        if (IDSecrecyDeception == null)
        {
            IDSecrecyDeception = new List<Action<ADType>>();
        }

        if (!IDSecrecyDeception.Contains(callback))
        {
            IDSecrecyDeception.Add(callback);
        }
    }

    /// <summary>
    /// 广告播放成功后，执行看广告回调事件
    /// </summary>
    private void GuildOnExamSeabird(ADType adType)
    {
        GoHistoryAd = false;
        // 播放间隔计数器清零
        FootExamUserLawlike = 0;
        // 插屏计数器清零
        if (adType == ADType.Interstitial)
        {
            // 计数器清零
            if (ExperimenterRear == 101)
            {
                DramPress.Instance.NorGust(RemunerationProboscis);
                Playful101 = 0;
            }
            else if (ExperimenterRear == 102)
            {
                Playful102 = 0;
                AutoTineScratch.YouGet("NoThanksCount", 0);
            }
            else if (ExperimenterRear == 103)
            {
                Playful103 = 0;
            }
        }

        // 看广告总数+1
        AutoTineScratch.YouGet(CBuckle.Go_Alter_ID_Cud + adType.ToString(), AutoTineScratch.BuyGet(CBuckle.Go_Alter_ID_Cud + adType.ToString()) + 1);

        // 回调
        if (IDSecrecyDeception != null && IDSecrecyDeception.Count > 0)
        {
            foreach (Action<ADType> callback in IDSecrecyDeception)
            {
                callback?.Invoke(adType);
            }
        }
    }

    /// <summary>
    /// 获取总的看广告次数
    /// </summary>
    /// <returns></returns>
    public int BuyCrawlOnSod(ADType adType)
    {
        return AutoTineScratch.BuyGet(CBuckle.Go_Alter_ID_Cud + adType.ToString());
    }
}

public enum ADType { Interstitial, Rewarded }

[System.Serializable]
public class Ad_CustomData //广告自定义数据
{
    public string Bush_id; //用户id
    public string Similar; //版本号
    public string Fishery_Go; //请求id
    public string Afraid; //渠道
    public string Dependent_Go; //广告位id
}