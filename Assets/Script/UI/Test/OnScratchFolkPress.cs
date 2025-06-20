using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnScratchFolkPress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    public Text BurnExamUserLawlikeAfar;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    public Text Lawlike101Afar;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    public Text Lawlike102Afar;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    public Text Lawlike103Afar;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    public Text DriftSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    public Button ExamDescribeOnDivide;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    public Button ExamRemunerationOnDivide;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    public Button GoRetireDivide;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    public Button DriftSodDivide;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button ShaftDivide;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    public Text UserRemunerationAfar;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    public Button BulgeUserRemunerationDivide;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    public Button MaracaUserRemunerationDivide;

    private void Start()
    {
        InvokeRepeating(nameof(BuryLawlikeAfar), 0, 0.5f);

        ShaftDivide.onClick.AddListener(() => {
            ShaftUIWish(GetType().Name);
        });

        ExamDescribeOnDivide.onClick.AddListener(() => {
            ADScratch.Ductless.HairAdviceKarst((success) => { }, "10");
        });

        ExamRemunerationOnDivide.onClick.AddListener(() => {
            ADScratch.Ductless.HairRemunerationOn(1);
        });

        GoRetireDivide.onClick.AddListener(() => {
            ADScratch.Ductless.GoRetireNorPaint();
        });

        DriftSodDivide.onClick.AddListener(() => {
            ADScratch.Ductless.ManualDriftSod(AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud) + 1);
            DriftSodAfar.text = AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud).ToString();
        });

        BulgeUserRemunerationDivide.onClick.AddListener(() => {
            ADScratch.Ductless.BulgeUserRemuneration();
            BuryBulgeUserRemuneration();
        });

        MaracaUserRemunerationDivide.onClick.AddListener(() => {
            ADScratch.Ductless.MaracaUserRemuneration();
            BuryBulgeUserRemuneration();
        });

    }

    public override void Display()
    {
        base.Display();
        DriftSodAfar.text = AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud).ToString();
        BuryBulgeUserRemuneration();
    }

    private void BuryLawlikeAfar()
    {
        BurnExamUserLawlikeAfar.text = ADScratch.Ductless.FootExamUserLawlike.ToString();
        Lawlike101Afar.text = ADScratch.Ductless.Playful101.ToString();
        Lawlike102Afar.text = ADScratch.Ductless.Playful102.ToString();
        Lawlike103Afar.text = ADScratch.Ductless.Playful103.ToString();
    }

    private void BuryBulgeUserRemuneration()
    {
        UserRemunerationAfar.text = ADScratch.Ductless.DrainUserRemuneration ? "已暂停" : "未暂停";
    }
}
