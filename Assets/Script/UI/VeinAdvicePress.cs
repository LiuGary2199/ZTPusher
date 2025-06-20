// Project: Plinko
// FileName: VeinAdvicePress.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:00
// Description:

using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class VeinAdvicePress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    public Button LeoAdviceOak;
[UnityEngine.Serialization.FormerlySerializedAs("GoldBtn")]    public Button StirOak;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    public GameObject IDRay;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    public GameObject LeoOakAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
    public Text SoilSod;
[UnityEngine.Serialization.FormerlySerializedAs("needGoldNum")]    public Text SparStirSod;


    private string DiverRear;


    private void Start()
    {
        GuardOak.onClick.AddListener(() =>
        {
            DiverRear = "0";
            ADScratch.Ductless.GoRetireNorPaint();
            ShaftSledPress();
        });

        StirOak.onClick.AddListener(() =>
        {
            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = DramTineScratch.BuyDuctless().BuyStir();
            double needSod= buyCount * 50000;
            if (needSod >= 300000)
            {
                needSod = 300000;
            }
            if (coincount >= needSod)
            {
                BuyAdvice();
                DramTineScratch.BuyDuctless().NorStir(-needSod);
                PlayerPrefs.SetInt("MoneyBuyBall", buyCount + 1);
            }
            else 
            {
                LeoAdviceOak.gameObject.SetActive(true);
                StirOak.gameObject.SetActive(false);
            }
        });

        LeoAdviceOak.onClick.AddListener(() =>
        {
            if (!AutoTineScratch.BuyGirl(CBuckle.Go_Shyness_Mob_Soil)) {
                AutoTineScratch.YouGirl(CBuckle.Go_Shyness_Mob_Soil, true);
                BuyAdvice();
            }
            else
            {
                ADScratch.Ductless.HairAdviceKarst((success) => { BuyAdvice(); }, "8");
            }
        });

        SoilSod.text = "" + BisHeadCar.instance.DramTine.base_config.ball_limit;
    }


    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        // if (VacantSkin.IsApple())
        // {
        //     adImg.gameObject.SetActive(false);
        //     getBtnText.transform.localPosition = new Vector3(37f, 0f, 0f);
        //     closeBtn.gameObject.SetActive(true);
        // }
        // else
        // {
        if (!AutoTineScratch.BuyGirl(CBuckle.Go_Shyness_Mob_Soil))
        {
            IDRay.gameObject.SetActive(false);
            GuardOak.gameObject.SetActive(false);
            LeoOakAfar.transform.localPosition = new Vector3(0f, 0f, 0f);
            
        }
        else
        {
            LeoOakAfar.transform.localPosition = new Vector3(37f, 0f, 0f);
            IDRay.gameObject.SetActive(true);
            GuardOak.gameObject.SetActive(true);
            GuardOak.GetComponent<CanvasGroup>().alpha = 0f;
            GuardOak.enabled = false;


            GuardOak.GetComponent<CanvasGroup>().alpha = 0f;
            DOTween.To(x => GuardOak.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f)
                .OnComplete(() => { GuardOak.enabled = true; });

            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = DramTineScratch.BuyDuctless().BuyStir();
            double needSod= buyCount * 50000;
            SparStirSod.text = needSod.ToString();
            if (needSod >= 300000)
            {
                needSod = 300000;
            }
            if (coincount >= needSod)
            {
                LeoAdviceOak.gameObject.SetActive(false);
                StirOak.gameObject.SetActive(true);
            }
        }
        // }
    }

    private void BuyAdvice()
    {
        DiverRear = "1";
        NicheNameScratch.Instance.NorNicheName();
        ShaftSledPress();
    }


    private void ShaftSledPress()
    {
        CardHonorDecode.BuyDuctless().SaltHonor("1015", DiverRear);
        HuntScratch.Instance.DramWitness();
        ShaftUIWish(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
}