// Project: Plinko
// FileName: AidYouPronePress.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 16:00
// Description:

using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class AidYouPronePress : ForkUIVisit
{
    public static AidYouPronePress Instance;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinBGAnim")]
    public SkeletonGraphic ToyYouBGBall;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinWordAnim")]    public SkeletonGraphic ToyYouAiryBall;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
    public Button LeoVeinOak;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button LeoOak;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
    public GameObject IDRay;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    public GameObject LeoOakAfar;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text BurrowAfar;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinType")]
    public BigWinType ToyYouRear;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]
    public double BurrowSod;

    private string DiverRear;

    public override void Display()
    {
        base.Display();
        //TheirCar.GetInstance().PlayEffect(TheirRear.UIMusic.sound_bigwin2_open);
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
        LeoVeinOak.onClick.AddListener(() =>
        {
            if (AutoTineScratch.BuyLaunch(CBuckle.Go_Idiom_Suit_Too_Burrow) == "new")
            {
                AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Suit_Too_Burrow, "done");
                AutoTineScratch.YouLaunch(CBuckle.Go_Juicy_Fix_Fox, "done");

                NucleusCandidTribe.BuyDuctless().Salt(CBuckle.Gem_Toss_Jolt_Zone);
                BuyAdvice();
            }
            else
            {
                ADScratch.Ductless.HairAdviceKarst((success) =>
                {
                    DiverRear = "1";
                    BuyAdvice();
                }, "2");
            }
        });

        LeoOak.onClick.AddListener(() =>
        {
            DiverRear = "0";
            ADScratch.Ductless.GoRetireNorPaint();
            ShaftPress();
        });
    }

    public void NoseTine(double num)
    {
        ADScratch.Ductless.BulgeUserRemuneration();
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_bigwin2_open);
        BurrowSod = num;
        BurrowAfar.text = "" + BurrowSod;
        NoseBall();

        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Idiom_Suit_Too_Burrow) == "new")
        {
            LeoOak.gameObject.SetActive(false);
            IDRay.gameObject.SetActive(false);
            LeoOakAfar.transform.localPosition = new Vector3(0f, 0f, 0f);
            AutoTineScratch.YouGet(CBuckle.Go_ID_Hotel_Cud, AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud) + 1);
        }
        else
        {
            LeoOakAfar.transform.localPosition = new Vector3(37f, 0f, 0f);
            IDRay.gameObject.SetActive(true);
            LeoOak.gameObject.SetActive(true);
            LeoOak.GetComponent<CanvasGroup>().alpha = 0f;
            LeoOak.enabled = false;

            DOTween.To(x => LeoOak.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
            {
                LeoOak.enabled = true;
            });
        }
    }


    private void NoseBall()
    {
        ToyYouBGBall.AnimationState.SetAnimation(0, "chuxian", false);
        ToyYouBGBall.AnimationState.AddAnimation(0, "daiji", true, 0f);
        switch (ToyYouRear)
        {
            case BigWinType.BigWin:
                ToyYouAiryBall.AnimationState.SetAnimation(0, "Big_chuxian", false);
                ToyYouAiryBall.AnimationState.AddAnimation(0, "Big_daiji", true, 0f);

                break;
            case BigWinType.HugeWin:
                ToyYouAiryBall.AnimationState.SetAnimation(0, "Huge_chuxian", false);
                ToyYouAiryBall.AnimationState.AddAnimation(0, "Huge_daiji", true, 0f);
                break;
            default:
                ToyYouAiryBall.AnimationState.SetAnimation(0, "Mega_chuxian", false);
                ToyYouAiryBall.AnimationState.AddAnimation(0, "Mega_daiji", true, 0f);
                break;
        }
    }


    private void BuyAdvice()
    {
        DiverRear = "1";

        DramPress.Instance.NorGust(BurrowSod, transform);

        // PrimitivePassageway.CollectAni(DramPress.Instance.cashImg.transform.position,
        //     Resources.Load<GameObject>("Art/FX/RewardImage"), new Vector3(0, 0, 0), DramPress.Instance.transform,
        //     () => { });
        ShaftPress();
    }

    private void ShaftPress()
    {
        if (AutoTineScratch.BuyLaunch(CBuckle.Gem_Toss_Pink_us) == "show")
        {
            AutoTineScratch.YouLaunch(CBuckle.Gem_Toss_Pink_us, "done");
            NucleusCandidTribe.BuyDuctless().Salt(CBuckle.Gem_Toss_Pink_us);
        }

        NucleusCandidTribe.BuyDuctless().Salt(CBuckle.msg_Guard_Troop_Kit_Juicy);

        CardHonorDecode.BuyDuctless().SaltHonor("1007", DiverRear,BurrowSod.ToString());
        ShaftUIWish(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
}