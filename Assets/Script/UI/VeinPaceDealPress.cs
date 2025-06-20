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
public class VeinPaceDealPress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    public Button LeoAdviceOak;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBtn")]    public Button MarriageOak;
[UnityEngine.Serialization.FormerlySerializedAs("NoExchangeBtn")]    public GameObject NoMarriageOak;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
    public GameObject IDRay;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]
    public GameObject LeoOakAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
    public Text SoilSod;
[UnityEngine.Serialization.FormerlySerializedAs("NeedNum")]    public Text EarnSod;
[UnityEngine.Serialization.FormerlySerializedAs("needNum")]    public int needSod;
    private string DiverRear;


    private void Start()
    {
        EarnSod.text = needSod.ToString();
        GuardOak.onClick.AddListener(() =>
        {
            DiverRear = "0";
            ADScratch.Ductless.GoRetireNorPaint();
            ShaftSledPress();
        });

        MarriageOak.onClick.AddListener(() =>
        {
            double coincount = DramTineScratch.BuyDuctless().BuyStir();
            if (coincount >= needSod)
            {
                DramTineScratch.BuyDuctless().NorStir(-needSod);
                NicheNameScratch.Instance.NorNicheName();
                //DramPress.Instance.goldNumText.text = DramTineScratch.GetInstance().GetGold() + "";
                DramPress.Instance.DonStirSodAfar.text = DramTineScratch.BuyDuctless().BuyStir() + "";
                ShaftSledPress();
            }
        });

        LeoAdviceOak.onClick.AddListener(() =>
        {
            if (!AutoTineScratch.BuyGirl(CBuckle.Go_Shyness_Mob_Soil))
            {
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
        double coincount = DramTineScratch.BuyDuctless().BuyStir();
        MarriageOak.gameObject.SetActive(coincount >= needSod);
        NoMarriageOak.SetActive(coincount < needSod);
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
            //closeBtn.gameObject.SetActive(false);
            LeoOakAfar.transform.localPosition = new Vector3(0f, 0f, 0f);

        }
        else
        {
            LeoOakAfar.transform.localPosition = new Vector3(37f, 0f, 0f);
            IDRay.gameObject.SetActive(true);
            GuardOak.gameObject.SetActive(true);
           // closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // closeBtn.enabled = false;


            //closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // DOTween.To(x => closeBtn.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() => { closeBtn.enabled = true; });
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
