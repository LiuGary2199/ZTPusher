using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElicitFolkPress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button ShaftDivide;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    public Text ElicitFendAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    public Text ShrinkItAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    public Text AieLawlikeAfar;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    public Text ElicitRearAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    public Button ResetAiePaintDivide;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    public Button NorAiePaintDivide;

    // Start is called before the first frame update
    void Start()
    {
        ShaftDivide.onClick.AddListener(() => {
            ShaftUIWish(GetType().Name);
        });

        ResetAiePaintDivide.onClick.AddListener(() => {
            ElicitNoseScratch.Instance.SnailAiePaint();
        });

        NorAiePaintDivide.onClick.AddListener(() => {
            ElicitNoseScratch.Instance.NorAiePaint("test");
        });
    }

    private void BuryLawlikeAfar()
    {
        ElicitFendAfar.text = ElicitNoseScratch.Instance.BuyElicitFend();
        ShrinkItAfar.text = AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt);
        AieLawlikeAfar.text = ElicitNoseScratch.Instance._ChronicPaint.ToString();
        ElicitRearAfar.text = AutoTineScratch.BuyLaunch("sv_ADJustInitType");
    }

    public override void Display()
    {
        base.Display();
        InvokeRepeating(nameof(BuryLawlikeAfar), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(BuryLawlikeAfar));
    }
}
