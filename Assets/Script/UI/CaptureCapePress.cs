// Project: Plinko
// FileName: CaptureCapePress.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:28
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using ScratchCardAsset;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CaptureCapePress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    // public SkeletonGraphic titleAnim;

    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("targetCard")]
    public ScratchCardManager BelterCape;
[UnityEngine.Serialization.FormerlySerializedAs("mainCard")]    public ScratchCardManager MuteCape;
[UnityEngine.Serialization.FormerlySerializedAs("cardLessProgress")]
    public float SageRapeEmigrant;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum01")]
    public Text BelterSod01;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum02")]    public Text BelterSod02;
[UnityEngine.Serialization.FormerlySerializedAs("mainCardObjList")]
    public List<CaptureCryPassageway> MuteCapeCryRent;

    private bool BelterCapeHoly;
    private bool MuteCapeHoly;

    private int ImpingeYouShePaint;
    private int FoulYouPaint;

    private List<int> BelterSodRent;

    private Dictionary<NormalRewardType, double> BurrowToo;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    
    public SkeletonGraphic HeavyBall;


    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        CardHonorDecode.BuyDuctless().SaltHonor("1008");

        HeavyBall.AnimationState.SetAnimation(0, "chuxian", false);
        HeavyBall.AnimationState.AddAnimation(0, "daiji", true, 0f);

        BelterCapeHoly = false;
        MuteCapeHoly = false;

        NoseDramTine();
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
    protected override void Awake()
    {
        base.Awake();
        ImpingeYouShePaint = BisHeadCar.instance.DramTine.base_config.scratch_win_max_count;
        //scratchWinMaxCount = 3;
        FoulYouPaint = 0;
    }

    private void Start()
    {
        GuardOak.onClick.AddListener(() => { ShaftCaptureCapePress(); });

        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.msg_Guard_Troop_Kit_Juicy,
            (messageData) => { ShaftCaptureCapePress(); });
        
        NoseDramTine();
    }

    private void Update()
    {
        if (!BelterCapeHoly && BelterCape.Progress.GetProgress() > 0.7f)
        {
            BelterCapeHoly = true;
            BelterCape.FillScratchCard();
            if (MuteCapeHoly)
            {
                BuryCaptureProne();
            }
        }

        if (!MuteCapeHoly && MuteCape.Progress.GetProgress() > SageRapeEmigrant)
        {
            MuteCapeHoly = true;
            MuteCape.FillScratchCard();
            if (BelterCapeHoly)
            {
                BuryCaptureProne();
            }
        }
    }


    private void BuryTemperPronePress()
    {
        if (BurrowToo.Count > 0)
        {
            AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_Drip, "1009");
 
            AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_ID_Go,"3");
            AdvicePressScratch.Instance.BuryChoppyAdvicePress(BurrowToo);
            // ChoppyYouPronePress.Instance.InitData(rewardMap, GetType().Name);
        }
        else
        {
            ShaftCaptureCapePress();
        }
    }

    private void BuryCaptureProne()
    {
        List<CaptureCryPassageway> objRent= new List<CaptureCryPassageway>();


        foreach (CaptureCryPassageway obj in MuteCapeCryRent)
        {
            if (BelterSodRent.Contains(obj.MuteSod))
            {
                string type = obj.ImpingeCryTine.ScratchObjType.ToString();
                NormalRewardType BurrowRear= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
                if (BurrowToo.ContainsKey(BurrowRear))
                {
                    BurrowToo[BurrowRear] =
                        BurrowToo[BurrowRear] + obj.ImpingeCryTine.RewardNum;
                }
                else
                {
                    BurrowToo.Add(BurrowRear, obj.ImpingeCryTine.RewardNum);
                }

                objRent.Add(obj);
            }
        }

        float timeTemp = 0f;

        for (int i = 0; i < objRent.Count; i++)
        {
            CaptureCryPassageway obj = objRent[i];
            obj.transform.DOScale(1, 0f).SetDelay(timeTemp).OnComplete(() => { obj.BuryEmploy(); });

            timeTemp += 0.15f;
        }

        Invoke(nameof(BuryTemperPronePress), 0.6f + timeTemp);
    }


    private int BuyDoctorCrySod()
    {
        return Random.Range(1, 71);
    }

    private void NoseDramTine()
    {
        BurrowToo = new Dictionary<NormalRewardType, double>();
        BelterSodRent = BuyEmployRent();
        FoulYouPaint = Random.Range(2, ImpingeYouShePaint);

        BelterCape.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
        MuteCape.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
 
        List<int> mainNumList = new List<int>();
        for (int i = 0; i < FoulYouPaint; i++)
        {
            int Panel= Random.Range(0, 2);
            int num = BelterSodRent[Panel];
            mainNumList.Add(num);
        }

        while (mainNumList.Count < 9)
        {
            int num = BuyDoctorCrySod();
            if (!mainNumList.Contains(num))
            {
                mainNumList.Add(num);
            }
        }

        mainNumList = DoctorSkin.DoctorRoam(mainNumList);

        for (int i = 0; i < mainNumList.Count; i++)
        {
            MuteCapeCryRent[i].NoseTine(mainNumList[i], BelterSodRent.Contains(mainNumList[i]));
        }
    }

    private List<int> BuyEmployRent()
    {
        List<int> targetList = new List<int>();
        int num1 = BuyDoctorCrySod();
        targetList.Add(num1);
        int num2 = BuyDoctorCrySod();
        while (num1 == num2)
        {
            num2 = BuyDoctorCrySod();
        }

        targetList.Add(num2);
        BelterSod01.text = num1.ToString();
        BelterSod02.text = num2.ToString();

        return targetList;
    }

    private void ShaftCaptureCapePress()
    {
        if (!gameObject.activeInHierarchy) return;
        BelterCape.ClearScratchCard();
        MuteCape.ClearScratchCard();
        Invoke(nameof(ShaftPress), 0.2f);
    }

    private void ShaftPress()
    {
        // AutoTineScratch.SetInt(CBuckle.sv_ad_trial_num, AutoTineScratch.GetInt(CBuckle.sv_ad_trial_num) + 1);
        HuntScratch.Instance.DramWitness();
        ShaftUIWish(GetType().Name);

        // PillarManager.Instance.StartLittleGameTimeBar();
        // HolderScratch.Instance.ReStartGame();
        // TuneScratch.Instance.inLittleGame = false;
    }
}