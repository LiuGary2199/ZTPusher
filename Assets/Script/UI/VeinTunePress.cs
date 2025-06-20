// Project: Plinko
// FileName: VeinTunePress.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 9:23
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class VeinTunePress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button LeoOak;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]

    public GameObject LeoOakAfar;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    public GameObject IDRay;


    private string DiverRear;

    private void Start()
    {
        GuardOak.onClick.AddListener(() =>
        {
            DiverRear = "0";
            ADScratch.Ductless.GoRetireNorPaint();
            HuntScratch.Instance.DramWitness();
            ShaftSledPress();
        });

        LeoOak.onClick.AddListener(() =>
        {
            if (AutoTineScratch.BuyLaunch(CBuckle.Go_Idiom_Wind_Abuse) == "new")
            {
                AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Wind_Abuse, "done");
                BuyAdvice();
            }
            else
            {
                ADScratch.Ductless.HairAdviceKarst((success) => { BuyAdvice(); }, "1");
            }
        });
    }

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Idiom_Wind_Abuse) == "new")
        {
            IDRay.gameObject.SetActive(false);
            LeoOakAfar.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        else
        {
            LeoOakAfar.transform.localPosition = new Vector3(37f, 0f, 0f);
            IDRay.gameObject.SetActive(true);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }

    private void BuyAdvice()
    {
        DiverRear = "1";

        PeriodTuneWedAutonomy.Instance.NorTunePaint();
        ShaftSledPress();
    }


    private void ShaftSledPress()
    {
        CardHonorDecode.BuyDuctless().SaltHonor("1004", DiverRear);
        HuntScratch.Instance.DramWitness();
        ShaftUIWish(GetType().Name);
    }
}