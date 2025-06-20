// Project: Pusher
// FileName: FaintlyCryPassageway.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:42
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaintlyCryPassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button LeoOak;
[UnityEngine.Serialization.FormerlySerializedAs("btnBgY")]    public Image InkGoY;
[UnityEngine.Serialization.FormerlySerializedAs("silverImg")]
    public GameObject FungusRay;
[UnityEngine.Serialization.FormerlySerializedAs("blueImg")]    public GameObject blueRay;
[UnityEngine.Serialization.FormerlySerializedAs("yellowImg")]    public GameObject AlaskaRay;
[UnityEngine.Serialization.FormerlySerializedAs("goldBarImg")]    public GameObject RiftIcyRay;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]
    public Image RiftRay;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public Image JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public Image SprawlRay;
[UnityEngine.Serialization.FormerlySerializedAs("sliderProgress")]
    public Image TorporEmigrant;
[UnityEngine.Serialization.FormerlySerializedAs("gemsNum")]    public Text WingSod;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text ReferentAfar;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    public Text BurrowSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("maxNum")]
    public int FarSod;
[UnityEngine.Serialization.FormerlySerializedAs("currentNum")]    public int ChronicSod;
[UnityEngine.Serialization.FormerlySerializedAs("gemsDataItem")]
    public GemsDataItem WingTineBark;
    private GemsType FoulWayRear;
    private RewardType BurrowRear;

    
    private Dictionary<NormalRewardType, double> BurrowToo;

    private void Start()
    {
        LeoOak.onClick.AddListener(() =>
        {
            if (!InkGoY.gameObject.activeInHierarchy)
            {
                return;
            }

            BuyAdvice();
        });
    }

    private void ShaftRookRay()
    {
        FungusRay.gameObject.SetActive(false);
        blueRay.gameObject.SetActive(false);
        AlaskaRay.gameObject.SetActive(false);
        RiftIcyRay.gameObject.SetActive(false);
    }

    private void BuryRookRay()
    {
        switch (FoulWayRear)
        {
            case GemsType.Silver:
                FungusRay.gameObject.SetActive(true);
                break;
            case GemsType.Blue:
                blueRay.gameObject.SetActive(true);
                break;
            case GemsType.Yellow:
                AlaskaRay.gameObject.SetActive(true);
                break;
            default:
                RiftIcyRay.gameObject.SetActive(true);
                break;
        }
    }

    private void ShaftAdviceRay()
    {
        RiftRay.gameObject.SetActive(false);
        JoltRay.gameObject.SetActive(false);
        SprawlRay.gameObject.SetActive(false);
    }

    private void BuryAdviceRay()
    {
        switch (BurrowRear)
        {
            case RewardType.Gold:
                RiftRay.gameObject.SetActive(true);
                break;
            case RewardType.Cash:
                JoltRay.gameObject.SetActive(true);
                break;
            default:
                SprawlRay.gameObject.SetActive(true);
                break;
        }
    }

    public void NoseTine()
    {
        FoulWayRear = (GemsType) Enum.Parse(typeof(GemsType), WingTineBark.gem_type);
        BurrowRear = (RewardType) Enum.Parse(typeof(RewardType), WingTineBark.reward_type);
        BurrowSodAfar.text = WingTineBark.reward_num + "";

        if (VacantSkin.AtTract())
        {
            BurrowRear = RewardType.Gold;
        }

        ShaftRookRay();
        BuryRookRay();
        ShaftAdviceRay();
        BuryAdviceRay();

        ChronicSod = AutoTineScratch.BuyGet(FoulWayRear.ToString());
        FarSod = WingTineBark.gem_limit;

        ReferentAfar.text = (ChronicSod < FarSod ? ChronicSod : FarSod) + "/" + FarSod;
        WingSod.text = "x " + FarSod;
        TorporEmigrant.fillAmount = (ChronicSod < FarSod ? ChronicSod : FarSod) * 1.0f / FarSod;
        InkGoY.gameObject.SetActive(ChronicSod >= FarSod);
    }


    public void BuyAdvice()
    {
        
        BurrowToo = new Dictionary<NormalRewardType, double>();
        NormalRewardType BurrowRear= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), WingTineBark.reward_type);
        BurrowToo.Add(BurrowRear, WingTineBark.reward_num);
        
        ChronicSod = 0;
        AutoTineScratch.YouGet(FoulWayRear.ToString(),0);
        // InitData();
        // UIUnable.GetInstance().CloseOrReturnUIForms(GetType().Name);
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_ID_Go,"7");
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_Drip, "1014");
        AutoTineScratch.YouLaunch(CBuckle.Go_Wing_Drip, FoulWayRear.ToString());
        AdvicePressScratch.Instance.BuryChoppyAdvicePress(BurrowToo);
        
    }
}