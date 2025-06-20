using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using LitJson;
using Lofelt.NiceVibrations;
public class PeriodScratch : MonoBehaviour
{
    static public PeriodScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool")]
    public GameObject No_Loud;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool_1")]    public GameObject No_Loud_1;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Pool")]    public GameObject Afar_Loud;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfab")]    public GameObject BurrowBarkEither;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemGroup")]    public Transform BurrowBarkCheck;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool")]    public LoudScratch NoLoud;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool_1")]    public LoudScratch NoLoud_1;
[UnityEngine.Serialization.FormerlySerializedAs("TextPool")]    public LoudScratch AfarLoud;
    private int FarReasonSod;
[UnityEngine.Serialization.FormerlySerializedAs("currentBucketNum")]    public int ChronicReasonSod;
[UnityEngine.Serialization.FormerlySerializedAs("ColumnGroup")]    public GameObject SawyerCheck;
[UnityEngine.Serialization.FormerlySerializedAs("centerDoor")]    public GameObject TundraLieu;
[UnityEngine.Serialization.FormerlySerializedAs("coinPagodaPerfab")]    public GameObject SparCooperEither;
[UnityEngine.Serialization.FormerlySerializedAs("fX_Fever")]    public GameObject fX_Craft;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BigWin")]    public GameObject fX_AidYou;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BoxGroup")]    public GameObject fX_WedCheck;
[UnityEngine.Serialization.FormerlySerializedAs("haveLittleGame")]    public bool MarkTemperDram= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPause")]    public bool GoBulge= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushFever")]    /// <summary>
    /// 是否进入fever
    /// </summary>
    public bool GoCaneCraft= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushBigWin")]    /// <summary>
    /// 是否正在777
    /// </summary>
    public bool GoCaneAidYou= false;
    int ErosionPaceDealPaint;
[UnityEngine.Serialization.FormerlySerializedAs("GibeIfShaftCry")]
    public GibeIfShaftCry GibeIfShaftCry;

    private void OnApplicationPause(bool focus)
    {
        if (focus)
        {
            Debug.Log("进入后台");
            WeltSeaAdviceBark();
        }
        else
        {
            Debug.Log("进入前台");
        }
    }


    private void Awake()
    {
        Instance = this;
        
    }

    private void Start()
    {
        GibeIfShaftCry.ShineCryIngot();
        FarReasonSod = 26;
        ChronicReasonSod = AutoTineScratch.BuyGet(CBuckle.Go_Rarer_Drug_Chronic);
        BurrowBarkCheck.gameObject.AddComponent<LoudScratch>().NoseLoudScratch(BurrowBarkEither,BurrowBarkCheck,300,"RewardItem");
        NoLoud.NoseLoudScratch(No_Loud, NoLoud.transform, 50, "fxPool");
        NoLoud_1.NoseLoudScratch(No_Loud_1, NoLoud_1.transform, 20, "fxPool_1");
        AfarLoud.NoseLoudScratch(Afar_Loud, AfarLoud.transform, 50, "TextPool");
        GrabSeaAdviceBark();
        JuicyPeriod();
        if (VacantSkin.AtTract())
        {
            TuneScratch.Instance.ShaftTuneBG();
        }
    }


    /// <summary>
    /// 推币机启动
    /// </summary>
    public void JuicyPeriod()
    {
        PeriodPrimitiveScratch.Instance.HardPlainJean();
        if (VacantSkin.AtTract())//新报更改该 审核期间去掉slot显示
        {
            PeriodPrimitiveScratch.Instance.ShaftTuneWed();
        }
        else
        {
            PeriodPrimitiveScratch.Instance.FoxPlainJean();
        }
        RimePaceOnAdvice();
    }


    /// <summary>
    /// 推币机暂停
    /// </summary>
    public void DrainPeriod()
    {
        if(!GoBulge)
        {
            GoBulge = true;
            //推板移动
            PeriodPrimitiveScratch.Instance.HardBulgeJean();
            //小球停止运动
            HolderScratch.Instance.DrainSeaName();
            //rewarditem停止运动
            DrainAdviceBark();
            //slot暂停
            TuneScratch.Instance.TuneLady();
            //暂停自动掉落物品
            DrainPeruPaceOnAdvice();
            //fever暂停
            if (GoCaneCraft)
            {
                if (VacantSkin.AtTract())
                {
                    DonCraftUserScratch.Instance.LadyCraft();
                }
                else
                {
                    CraftUserScratch.Instance.LadyCraft();
                }
                StopCoroutine(nameof(RarerAnyLampUser));
            }
            if (GoCaneAidYou && ToyYouAnyUser > 0)
            {
                StopCoroutine(nameof(ToyYouAnyLampUser));
            }
            if (ErosionPaceDealPaint > 0)
            {
                StopCoroutine(nameof(WoldSaltDumbAnLampUser));
            }
        }
    }
    /// <summary>
    /// 推币机恢复
    /// </summary>
    public void AlwaysPeriod()
    {
        if (GoBulge)
        {
            GoBulge = false;
            //推板恢复
            PeriodPrimitiveScratch.Instance.HardMaracaJean();
            //小球恢复
            HolderScratch.Instance.AlwaysSeaName();
            //rewarditem恢复
            AlwaysAdviceBark();
            //slot恢复
            TuneScratch.Instance.TuneMyPlain();
            //恢复自动掉落物品
            AlwaysPeruPaceOnAdvice();
            //fever恢复
            if (GoCaneCraft)
            {
                if (VacantSkin.AtTract())
                {
                    DonCraftUserScratch.Instance.MyPlainCraftUser();
                }
                else
                {
                    CraftUserScratch.Instance.MyPlainCraftUser();
                }
                StartCoroutine(nameof(RarerAnyLampUser));
            }
            if (GoCaneAidYou && ToyYouAnyUser > 0)
            {
                StartCoroutine(nameof(ToyYouAnyLampUser));
            }
            if (ErosionPaceDealPaint > 0)
            {
                StartCoroutine(nameof(WoldSaltDumbAnLampUser));
            }
        }
    }
    /// <summary>
    /// 暂停奖励物体
    /// </summary>
    void DrainAdviceBark()
    {
        if (BurrowBarkCheck.GetComponent<LoudScratch>() != null)
        {
            List<GameObject> list = BurrowBarkCheck.GetComponent<LoudScratch>().Pray;
            foreach (GameObject rewardItem in list)
            {
                rewardItem.GetComponent<InfectionBulge>().DrainRigidbody();
            }
        }
    }
    /// <summary>
    /// 恢复奖励物体
    /// </summary>
    void AlwaysAdviceBark()
    {
        List<GameObject> list = BurrowBarkCheck.GetComponent<LoudScratch>().Pray;
        foreach (GameObject rewardItem in list)
        {
            rewardItem.GetComponent<InfectionBulge>().AlwaysInfection();
        }
    }


    /// <summary>
    /// pusher奖励掉落台下
    /// </summary>
    public void LeoPaceAdvice(PusherRewardType type, double rewardNum)
    {
        if (GoCaneCraft)
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_getReward,0.1f);
        }
        else
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_getReward,0.1f);
        }
        NorReasonSod();
        TineAnnualScratch.BuyDuctless().MobPeriodAdvice(type,rewardNum);
        if (type == PusherRewardType.RollCash || type == PusherRewardType.ScratchCard || type == PusherRewardType.LuckyCard)
        {
            MarkTemperDram = false;
        }
    }


    /// <summary>
    /// 触发slot
    /// </summary>
    public void JuicyTune()
    {
        if (GoBulge)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
        TineAnnualScratch.BuyDuctless().LeoTuneAdviceTine((slotRewardType)=> {
            TuneScratch.Instance.ExamTune(slotRewardType, () =>
            {
                Debug.Log("finish");
                if (slotRewardType != SlotRewardType.Null)
                {
                    TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slot_reward);
                    HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
                }

                switch (slotRewardType)
                {
                    case SlotRewardType.BigWin:
                      //  SOHOShopManager.instance.AddTaskValue("777", 1);
                        AidYou();
                        break;
                    case SlotRewardType.Cash1:
                        WoldFiveGustDumbAn(25);
                        break;
                    case SlotRewardType.Cash2:
                        WoldFiveGustDumbAn(50);
                        break;
                    case SlotRewardType.Cash3:
                        WoldFiveGustDumbAn(100);
                        break;
                    case SlotRewardType.SkillWall:
                        FenPeepAn();
                        break;
                    case SlotRewardType.SkillBigCoin:
                        ToyDealPace();
                        break;
                    case SlotRewardType.SkillLong:
                        HardNorKeep();
                        break;
                    case SlotRewardType.GemBlue:
                        WoldDumbAn(PusherRewardType.GemBlue);
                        break;
                    case SlotRewardType.GemRed:
                        WoldDumbAn(PusherRewardType.GemRed);
                        break;
                    case SlotRewardType.GemDiamond:
                        WoldDumbAn(PusherRewardType.GemDiamond);
                        break;
                    case SlotRewardType.Golden:
                        WoldDumbAn(PusherRewardType.Golden);
                        break;
                    case SlotRewardType.Null:
                        break;
                }
            });
        });
    }


    /// <summary>
    /// 自动掉落间隔时间
    /// </summary>
    float adAdviceCDUser= 0;
    /// <summary>
    /// 自动掉落广告奖励(现金卷/刮刮卡/翻牌)
    /// </summary>
    public void RimePaceOnAdvice()
    {
        adAdviceCDUser = BisHeadCar.instance.DramTine.base_config.little_game_time;
        StartCoroutine(nameof(RimePaceOnAdviceLampUser));
    }
    /// <summary>
    /// 暂停自动掉落等时
    /// </summary>
    public void DrainPeruPaceOnAdvice()
    {
        StopCoroutine(nameof(RimePaceOnAdviceLampUser));
    }
    /// <summary>
    /// 恢复自动掉落等时
    /// </summary>
    public void AlwaysPeruPaceOnAdvice()
    {
        StartCoroutine(nameof(RimePaceOnAdviceLampUser));
    }
    /// <summary>
    /// 自动掉落等时
    /// </summary>
    /// <returns></returns>
    IEnumerator RimePaceOnAdviceLampUser()
    {
        while(adAdviceCDUser > 0 || MarkTemperDram || AutoTineScratch.BuyLaunch(CBuckle.Gem_Toss_Pink_us) == "new")
        {
            yield return new WaitForSeconds(1);
            adAdviceCDUser--;
        }
        if (!VacantSkin.AtTract())
        {
            PusherRewardType type = TineAnnualScratch.BuyDuctless().LeoPeruPaceOnRear();
            WoldDumbAn(type);
            MarkTemperDram = true;
        }
        RimePaceOnAdvice();
    }


    /// <summary>
    /// 技能-大金币-投掷
    /// </summary>
    public void ToyDealPace()
    {
        WoldDumbAn(PusherRewardType.BigCoin, () => {
            
            ToyDealRecur();
        });
    }
    /// <summary>
    /// 技能-大金币-震动
    /// </summary>
    public void ToyDealRecur()
    {
        Debug.Log("大金币-震动");
        Vector3 startPos = Camera.main.transform.position;
        TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_column_bomb);
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.HeavyImpact);
        Camera.main.DOShakePosition(0.5f, 0.28f, 30, 2, true).SetEase(Ease.Linear).OnComplete(() =>
        {
            Camera.main.transform.localPosition = startPos;
        });
        for (int i = 0; i < BurrowBarkCheck.childCount; i++)
        {
            Transform rewardItem = BurrowBarkCheck.GetChild(i);
            if(rewardItem.GetComponent<Rigidbody>())
            {
                rewardItem.GetComponent<Rigidbody>().AddForce(new Vector3(0, 150, -80));
            }
        }
    }


    /// <summary>
    /// 技能-推板加长
    /// </summary>
    public void HardNorKeep()
    {
        //单次推板加长时间
        float time = 10;
        PeriodPrimitiveScratch.Instance.HardNorKeep(time);
    }


    /// <summary>
    /// 技能-墙
    /// </summary>
    public void FenPeepAn()
    {
        //单次升墙时间
        float time = 10;
        PeriodPrimitiveScratch.Instance.FenPeepAn(time);
    }


   
    /// <summary>
    /// 并排掉落多个
    /// </summary>
    /// <param name="count"></param>
    /// <param name="delay"></param>
    void WoldFiveGustDumbAn(int count)
    {
        ErosionPaceDealPaint += count;
        if (ErosionPaceDealPaint == count)
        {
            StartCoroutine(nameof(WoldSaltDumbAnLampUser));
        }
    }

    
    /// <summary>
    /// 并排掉落延迟
    /// </summary>
    /// <param name="type"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    IEnumerator WoldSaltDumbAnLampUser()
    {
        TineAnnualScratch.BuyDuctless().TossPaceGustDealPaint(true, ErosionPaceDealPaint);
        while (ErosionPaceDealPaint > 0)
        {
            TineAnnualScratch.BuyDuctless().TossPaceGustDealPaint(false,ErosionPaceDealPaint);
            ErosionPaceDealPaint--;
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_creat_coin, 0.1f);
            WoldDumbAn(PusherRewardType.CoinCash, null, (int)Mathf.PingPong(ErosionPaceDealPaint, 4) + 1);
            yield return new WaitForSeconds(0.1f);
        }
    }


    /// <summary>
    /// 从上空掉落物体
    /// </summary>
    /// <param name="dropObj"></param>
    void WoldDumbAn(PusherRewardType type, Action block = null, int index = 0)
    {
        GameObject rewardItemObj = LeoAdviceBark(type);
        switch (type)
        {
            case PusherRewardType.CoinGold:
                rewardItemObj.transform.eulerAngles = LeoDoctorAwardBabble();
                break;
            case PusherRewardType.CoinCash:
                rewardItemObj.transform.eulerAngles = LeoDoctorAwardBabble();
                break;
            default:
                
                break;
            
        }
        if (rewardItemObj != null)
        {
            
            if (index == 0)
            {
                rewardItemObj.transform.position = new Vector3(UnityEngine.Random.Range(-1.5f,1.5f), 7, -1.6f);
            }
            else
            {
                float[] targetXArray = new float[] {-1.6f,-0.8f,0,0.8f,1.6f };
                rewardItemObj.transform.position = new Vector3(targetXArray[index - 1], 7, -1.6f);
            }
        }
        if (block != null)
        {
            rewardItemObj.AddComponent<AutonomyTenon>().FenTenonHopper(block);
        }
    }


    /// <summary>
    /// 根据类型获得对应奖励物体
    /// </summary>
    /// <returns></returns>
    public GameObject LeoAdviceBark(PusherRewardType type)
    {
        GameObject rewardItem = BurrowBarkCheck.GetComponent<LoudScratch>().BuyFreeze();
        rewardItem.GetComponent<PeriodAdviceBark>().PramAdviceBark(type);
        rewardItem.GetComponent<Rigidbody>().velocity = Vector3.zero;
        rewardItem.transform.eulerAngles = Vector3.zero;
        rewardItem.SetActive(true);
        return rewardItem;
    }

    bool GoCooperUpside= false;
    /// <summary>
    /// 777
    /// </summary>
    void AidYou()
    {
        CardHonorDecode.BuyDuctless().SaltHonor("1005");
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slot_777);
        GoCaneAidYou = true;
        fX_AidYou.SetActive(true);
        PeriodPrimitiveScratch.Instance.HardSeaJean(()=> {
            TundraLieu.GetComponent<Rigidbody>().DOMoveY(-3, 0.5f).OnComplete(() => {
                TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_enter_allbox);
                GameObject pagodaGroup = VaporDealCooper(20);
                TundraLieu.transform.DOMoveY(0.664f, 0.5f);
                HolderScratch.Instance.VaporKierDeal(10);
                GoCooperUpside = false;
                pagodaGroup.transform.DOMoveY(0.74f,2f).OnComplete(()=> {
                    SparCooperCenter(pagodaGroup);
                });
            });
        });
        
    }
    /// <summary>
    /// 创建币塔
    /// </summary>
    /// <param name="heightCount">币塔层数</param>
    GameObject VaporDealCooper(int heightCount, bool isLoad = false)
    {
        bool isUnlock = false;
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> eulerList = new List<Vector3>();
        for (int i = 0; i < SparCooperEither.transform.childCount; i++)
        {
            Transform targetTrans = SparCooperEither.transform.GetChild(i);
            pointList.Add(targetTrans.localPosition);
            eulerList.Add(targetTrans.eulerAngles);
        }
        GameObject pagodaGroup = new GameObject();
        pagodaGroup.AddComponent<UpsideCooper>().Ample = () =>
        {
            if (!isUnlock)
            {
                isUnlock = true;
                pagodaGroup.GetComponent<UpsideCooper>().enabled = false;
                //Destroy(pagodaGroup.GetComponent<Rigidbody>());
                //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
                //{
                //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
                //    cashCoin.AddComponent<Rigidbody>();
                //    cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
                //    cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
                //}
            }
        };
        pagodaGroup.transform.position = new Vector3(0, TundraLieu.transform.position.y + 0.076f, -3.671f);
        pagodaGroup.transform.SetParent(PeriodScratch.Instance.BurrowBarkCheck);
        for (int i = 0; i < heightCount; i++)
        {
            GameObject tempObject = new GameObject();
            for (int j = 0; j < 7; j++)
            {
                GameObject cashCoin = PeriodScratch.Instance.LeoAdviceBark(PusherRewardType.CoinCash);
                cashCoin.transform.SetParent(tempObject.transform);
                cashCoin.transform.localPosition = pointList[j];
                cashCoin.transform.eulerAngles = eulerList[j];
                cashCoin.layer = 0;
                if (!isLoad)
                {
                    Destroy(cashCoin.GetComponent<Rigidbody>());
                }
            }
            tempObject.transform.position = pagodaGroup.transform.position + new Vector3(0, 0.1074f * i, 0);
            tempObject.transform.eulerAngles = new Vector3(0, i * 3, 0);
            for (int k = tempObject.transform.childCount - 1; k >= 0; k--)
            {
                tempObject.transform.GetChild(k).SetParent(pagodaGroup.transform);
            }
            Destroy(tempObject);
        }
        return pagodaGroup;
    }
    
    /// <summary>
    /// 币塔解封
    /// </summary>
    /// <param name="pagodaGroup"></param>
    void SparCooperCenter(GameObject pagodaGroup)
    {

        //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
        //{
        //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
        //    cashCoin.layer = 6;
        //}
        //pagodaGroup.layer = 6;
        //pagodaGroup.AddComponent<Rigidbody>().mass = 30;
        //isUnlock = true;
        //Destroy(pagodaGroup.GetComponent<Rigidbody>());
        GoCooperUpside = true;
        for (int i = pagodaGroup.transform.childCount - 1; i >= 0; i--)
        {
            Debug.Log(i);
            GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
            cashCoin.AddComponent<Rigidbody>();
            cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
            cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
            cashCoin.transform.SetParent(BurrowBarkCheck);
            if (GoBulge)
            {
                cashCoin.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        fX_AidYou.SetActive(false);
        ToyYouAnyUser = 5f;
        StartCoroutine(nameof(ToyYouAnyLampUser));
    }
    float ToyYouAnyUser= 0;
    /// <summary>
    /// 777结算
    /// </summary>
    IEnumerator ToyYouAnyLampUser()
    {
        while(ToyYouAnyUser > 0)
        {
            yield return new WaitForSeconds(1);
            ToyYouAnyUser--;
        }
        GoCaneAidYou = false;
        TineAnnualScratch.BuyDuctless().ToyYouAny();
        if (!GoCaneCraft)
        {
            //奖励弹窗
            AdvicePressScratch.Instance.BuryAidAdvicePress(GameUtil.GetBigWinCash());
        }
    }


    /// <summary>
    /// 开始fever
    /// </summary>
    public void RarerPlain()
    {
        TheirCar.BuyDuctless().ExamGo(TheirRear.UIMusic.sound_fever_bgm);
        PeriodScratch.Instance.GoCaneCraft = true;
        PeriodPrimitiveScratch.Instance.HardPlainJean(true);
        HolderScratch.Instance.RarerPlainWedMorally(10);
        HolderScratch.Instance.RarerPlainPeruPaceName();
        fX_Craft.SetActive(true);
        foreach (GameObject fx_Box in fX_WedCheck.GetComponent<WedCheck>().Solidify)
        {
            fx_Box.GetComponent<Folklore>().FX_Basin.SetActive(true);
        }
        RarerUser = BisHeadCar.instance.DramTine.base_config.fever_time;
        StartCoroutine(nameof(RarerAnyLampUser));
    }
    /// <summary>
    /// fever剩余时间
    /// </summary>
    float RarerUser= 0;
    /// <summary>
    /// 结束fever等时
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    IEnumerator RarerAnyLampUser()
    {
        while (RarerUser > 0)
        {
            yield return new WaitForSeconds(1);
            RarerUser--;
        }
        fX_Craft.SetActive(false);
        foreach (GameObject fx_Box in fX_WedCheck.GetComponent<WedCheck>().Solidify)
        {
            fx_Box.GetComponent<Folklore>().FX_Basin.SetActive(false);
        }
        GoCaneCraft = false;
        PeriodPrimitiveScratch.Instance.HardPlainJean(true);
        HolderScratch.Instance.RarerAnyWedMorally();
        HolderScratch.Instance.RarerAnyPeruPaceName();
        RarerAny();
    }
    /// <summary>
    /// fever结算
    /// </summary>
    void RarerAny()
    {
        TineAnnualScratch.BuyDuctless().RarerAny();
        TheirCar.BuyDuctless().ExamGo(TheirRear.UIMusic.sound_bgm);
        if (!GoCaneAidYou)
        {
            //结算弹窗
            AdvicePressScratch.Instance.BuryAidAdvicePress(GameUtil.GetBigWinCash());
        }
    }


    public void ExamCraft() 
    {
        foreach (SpriteRenderer sr in SawyerCheck.GetComponent<SawyerScratch>().GalaxyRent) 
        {
            sr.sprite = Resources.Load<Sprite>(CBuckle.Who_8);
        }
        
    }

    /// <summary>
    /// fever累计次数
    /// </summary>
    public void NorReasonSod()
    {
        if (!GoCaneCraft)
        {
            // 增加fever 数值
            if (VacantSkin.AtTract())
            {
                DonCraftUserScratch.Instance.NorCraftName();
            }
            else
            {
                CraftUserScratch.Instance.NorCraftName();
            }
            ChronicReasonSod++;
            if (ChronicReasonSod >= BisHeadCar.instance.DramTine.base_config.fever_limit)
            {
                ChronicReasonSod = 0;
                RarerPlain();
            }
        }
        
    }


    

    Vector3 LeoDoctorAwardBabble()
    {
        Vector3 v3 = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
        return v3;
    }



    /// <summary>
    /// 保存全部物体
    /// </summary>
    public void WeltSeaAdviceBark()
    {
        List<RewardItemSaveData> saveList = new List<RewardItemSaveData>();
        if (GoCaneAidYou && !GoCooperUpside)
        {
            foreach (GameObject item in BurrowBarkCheck.GetComponent<LoudScratch>().Pray)
            {
                if (item.activeSelf && item.transform.parent == BurrowBarkCheck && item.GetComponent<PeriodAdviceBark>().BurrowRear != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<PeriodAdviceBark>().BurrowRear;
                    saveData.num = item.GetComponent<PeriodAdviceBark>().BurrowSod;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.Dy = item.transform.eulerAngles.x;
                    saveData.Ox = item.transform.eulerAngles.y;
                    saveData.On = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            AutoTineScratch.YouGirl("save_data_inbigwin", true);
        }
        else
        {
            foreach (GameObject item in BurrowBarkCheck.GetComponent<LoudScratch>().Pray)
            {
                if (item.activeSelf && item.GetComponent<PeriodAdviceBark>().BurrowRear != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<PeriodAdviceBark>().BurrowRear;
                    saveData.num = item.GetComponent<PeriodAdviceBark>().BurrowSod;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.Dy = item.transform.eulerAngles.x;
                    saveData.Ox = item.transform.eulerAngles.y;
                    saveData.On = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            AutoTineScratch.YouGirl("save_data_inbigwin", false);
        }
        //SaveData savedata = new SaveData();
        //savedata.saveList = saveList;
        string saveJson = JsonMapper.ToJson(saveList);
        AutoTineScratch.YouLaunch("save_data",saveJson);
    }

    /// <summary>
    /// 读取全部物体
    /// </summary>
    public void GrabSeaAdviceBark()
    {
        string saveJson = AutoTineScratch.BuyLaunch("save_data");
        if (saveJson != null && saveJson.Length > 0)
        {
            foreach (GameObject rewardItem in BurrowBarkCheck.GetComponent<LoudScratch>().Pray)
            {
                rewardItem.SetActive(false);
            }
            List<RewardItemSaveData> saveList = JsonMapper.ToObject<List<RewardItemSaveData>>(saveJson);
            if (AutoTineScratch.BuyGirl("save_data_inbigwin"))
            {
                VaporDealCooper(20,true);
            }
            foreach (RewardItemSaveData data in saveList)
            {
                if (data.type == PusherRewardType.ScratchCard || data.type == PusherRewardType.LuckyCard || data.type == PusherRewardType.RollCash)
                {
                    MarkTemperDram = true;
                }
                GameObject rewardItem = BurrowBarkCheck.GetComponent<LoudScratch>().BuyFreeze();
                rewardItem.transform.position = new Vector3((float)data.x, (float)data.y, (float)data.z);
                rewardItem.transform.eulerAngles = new Vector3((float)data.Dy, (float)data.Ox, (float)data.On);
                rewardItem.GetComponent<PeriodAdviceBark>().PramAdviceBark(data.type,false);
            }
        } else
        {
            if (VacantSkin.AtTract())
            {
                foreach (GameObject coin in BurrowBarkCheck.GetComponent<LoudScratch>().Pray)
                {
                    if (coin.activeSelf)
                    {
                        coin.GetComponent<PeriodAdviceBark>().PramAdviceBark(PusherRewardType.CoinGold,false);
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            AidYou();
        // AdvicePressScratch.Instance.ShowBigRewardPanel(10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToyDealPace();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            WoldFiveGustDumbAn(25);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            PeriodTuneWedAutonomy.Instance.ExamRawTune();

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            WoldDumbAn(PusherRewardType.GemRed);
            WoldDumbAn(PusherRewardType.GemBlue);
            WoldDumbAn(PusherRewardType.GemDiamond);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!GoBulge)
            {
                DrainPeriod();
            }
            else
            {
                AlwaysPeriod();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            RarerPlain();
        }
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    SOHOShopManager.instance.AddTaskValue("777", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    SOHOShopManager.instance.AddTaskValue("golden", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    SOHOShopManager.instance.AddTaskValue("AD", 1);
        //}
    }


    

}
//public class SaveData
//{
//    public List<RewardItemSaveData> saveList;
//}
public class RewardItemSaveData
{
    public PusherRewardType type;
    public double num;
    public double x;
    public double y;
    public double z;
    public double Dy;
    public double Ox;
    public double On;
}