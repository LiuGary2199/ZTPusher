// Project: Plinko
// FileName: ChoppyYouPronePress.cs
// Author: AX
// CreateDate: 20230515
// CreateTime: 16:01
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Spine.Unity;

public class ChoppyYouPronePress : ForkUIVisit
{
    public static ChoppyYouPronePress Instance;
[UnityEngine.Serialization.FormerlySerializedAs("normalSlot")]
    public ChoppyTunePassageway WeakenTune;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
    public Button LeoVeinOak;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button LeoOak;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop01")]
    public GameObject BurrowWar01;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop02")]    public GameObject BurrowWar02;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop03")]    public GameObject BurrowWar03;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
    public SkeletonGraphic HeavyBall;


    private Dictionary<NormalRewardType, double> BurrowToo;


    private string DiverRear;

    private string Valve2;
    private string Valve3;

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        //TheirCar.GetInstance().PlayEffect(TheirRear.UIMusic.sound_bigwin1_open);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
    private void Start()
    {
        LeoVeinOak.onClick.AddListener(() =>
        {
            ADScratch.Ductless.HairAdviceKarst((success) =>
            {
                DiverRear = "1";
                LeoVeinOak.gameObject.SetActive(false);
                LeoOak.gameObject.SetActive(false);
                ExamTune();
            }, AutoTineScratch.BuyLaunch(CBuckle.Go_Weaken_Too_ID_Go));
        });

        LeoOak.onClick.AddListener(() =>
        {
            ADScratch.Ductless.GoRetireNorPaint();
            DiverRear = "0";
            BuyAdvice();
        });
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        BurrowToo = new Dictionary<NormalRewardType, double>();
    }

    public void NoseTine(Dictionary<NormalRewardType, double> map)
    {
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_bigwin1_open);

        HeavyBall.AnimationState.SetAnimation(0, "chuxian", false);
        HeavyBall.AnimationState.AddAnimation(0, "daiji", true, 0f);

        WeakenTune.NoseFolly();
        LeoVeinOak.gameObject.SetActive(true);
        LeoOak.gameObject.SetActive(true);
        LeoOak.GetComponent<CanvasGroup>().alpha = 0f;
        LeoOak.enabled = false;

        DOTween.To(x => LeoOak.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
        {
            LeoOak.enabled = true;
        });
        BurrowToo = map;

        BurrowWar02.gameObject.SetActive(false);
        BurrowWar02.gameObject.SetActive(false);
        BurrowWar03.gameObject.SetActive(false);
        BurrowWar01.transform.localScale = new Vector3(1f, 1f, 1f);
        BurrowWar02.transform.localScale = new Vector3(1f, 1f, 1f);
        BurrowWar03.transform.localScale = new Vector3(1f, 1f, 1f);

        List<NormalRewardType> keyList = new List<NormalRewardType>();
        List<double> valueList = new List<double>();

        foreach (var item in BurrowToo)
        {
            keyList.Add(item.Key);
            valueList.Add(item.Value);
        }

        if (BurrowToo.Count == 1)
        {
            BurrowWar01.transform.localPosition = new Vector3(0f, 380f, 0f);
            BurrowWar01.transform.localScale *= 1.2f;
            BurrowWar01.gameObject.SetActive(true);
            BurrowWar01.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[0], valueList[0]);
            Valve2 = valueList[0].ToString();
            Valve3 = BuyShoot3(keyList[0]);
        }

        if (BurrowToo.Count == 2)
        {
            BurrowWar01.transform.localPosition = new Vector3(-220f, 350f, 0f);
            BurrowWar02.transform.localPosition = new Vector3(220f, 350f, 0f);

            BurrowWar01.gameObject.SetActive(true);
            BurrowWar02.gameObject.SetActive(true);
            BurrowWar01.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[0], valueList[0]);
            BurrowWar02.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[1], valueList[1]);
            Valve2 = "0";
            Valve3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Valve2 = valueList[i].ToString();
                    Valve3 = "1";
                }
            }
        }

        if (BurrowToo.Count == 3)
        {
            BurrowWar01.transform.localPosition = new Vector3(0f, 500f, 0f);
            BurrowWar02.transform.localPosition = new Vector3(-240f, 250f, 0f);
            BurrowWar03.transform.localPosition = new Vector3(240f, 250f, 0f);

            BurrowWar01.transform.localScale *= 0.8f;
            BurrowWar02.transform.localScale *= 0.8f;
            BurrowWar03.transform.localScale *= 0.8f;

            BurrowWar01.gameObject.SetActive(true);
            BurrowWar02.gameObject.SetActive(true);
            BurrowWar03.gameObject.SetActive(true);

            BurrowWar01.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[0], valueList[0]);
            BurrowWar02.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[1], valueList[1]);
            BurrowWar03.gameObject.GetComponent<ChoppyAdviceWarPassageway>().NoseTine(keyList[2], valueList[2]);

            Valve2 = "0";
            Valve3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Valve2 = valueList[i].ToString();
                    Valve3 = "1";
                }
            }
        }
    }

    private int BuyTuneImage()
    {
        int sumWeight = 0;
        foreach (RewardMultiItem wg in BisHeadCar.instance.NoseTine.RewardMultiList)
        {
            sumWeight += wg.weight;
        }

        int r = Random.Range(0, sumWeight);
        int nowWeight = 0;
        int Panel= 0;
        foreach (RewardMultiItem wg in BisHeadCar.instance.NoseTine.RewardMultiList)
        {
            nowWeight += wg.weight;
            if (nowWeight > r)
            {
                return Panel;
            }

            Panel++;
        }

        return 0;
    }


    private string BuyShoot3(NormalRewardType type)
    {
        switch (type)
        {
            case NormalRewardType.Cash:
                return "1";
            case NormalRewardType.Gold:
                return "2";
            default:
                return "3";
        }
    }


    private void ExamTune()
    {
        int Panel= BuyTuneImage();
        WeakenTune.SellTune(Panel, (multi) =>
        {
            if (BurrowWar01.activeInHierarchy)
            {
                BurrowWar01.gameObject.GetComponent<ChoppyAdviceWarPassageway>().MutualSodBall(multi);
            }

            if (BurrowWar02.activeInHierarchy)
            {
                BurrowWar02.gameObject.GetComponent<ChoppyAdviceWarPassageway>().MutualSodBall(multi);
            }

            if (BurrowWar03.activeInHierarchy)
            {
                BurrowWar03.gameObject.GetComponent<ChoppyAdviceWarPassageway>().MutualSodBall(multi);
            }

            Invoke(nameof(BuyAdvice), 1f);
        });
    }

    private void ShaftChoppyPress()
    {
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Weaken_Too_Drip) == "1014")
        {
            Valve3 = "1";
            String gemType = AutoTineScratch.BuyLaunch(CBuckle.Go_Wing_Drip);
            switch (gemType)
            {
                case "Yellow":
                    Valve3 = "1";
                    break;
                case "Blue":
                    Valve3 = "2";
                    break;
                case "Silver":
                    Valve3 = "3";
                    break;
                default:
                    Valve3 = "4";
                    break;
            }

            CardHonorDecode.BuyDuctless()
                .SaltHonor(AutoTineScratch.BuyLaunch(CBuckle.Go_Weaken_Too_Drip), DiverRear, Valve2, Valve3);
        }
        else
        {
            CardHonorDecode.BuyDuctless()
                .SaltHonor(AutoTineScratch.BuyLaunch(CBuckle.Go_Weaken_Too_Drip), DiverRear, Valve2, Valve3);
        }

        NucleusCandidTribe.BuyDuctless().Salt(CBuckle.msg_Guard_Troop_Kit_Juicy);
        // NucleusCandidTribe.GetInstance().Send(CBuckle.msg_show_cash_mask);

        ShaftUIWish(GetType().Name);
    }

    private void BuyAdvice()
    {
        if (BurrowWar01.activeInHierarchy)
        {
            BurrowWar01.gameObject.GetComponent<ChoppyAdviceWarPassageway>().BuyChoppyYouAdvice();
        }

        if (BurrowWar02.activeInHierarchy)
        {
            BurrowWar02.gameObject.GetComponent<ChoppyAdviceWarPassageway>().BuyChoppyYouAdvice();
        }

        if (BurrowWar03.activeInHierarchy)
        {
            BurrowWar03.gameObject.GetComponent<ChoppyAdviceWarPassageway>().BuyChoppyYouAdvice();
        }

        ShaftChoppyPress();
    }
}