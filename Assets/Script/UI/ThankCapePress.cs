// Project: Pusher
// FileName: ThankCapePress.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:55
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;
using Spine.Unity;

public class ThankCapePress : ForkUIVisit
{
    public static ThankCapePress Instance;
[UnityEngine.Serialization.FormerlySerializedAs("luckyCardList")]
    public List<GameObject> AmpleCapeRent;
[UnityEngine.Serialization.FormerlySerializedAs("selectObjList")]    public List<GameObject> NobodyCryRent;
[UnityEngine.Serialization.FormerlySerializedAs("rewardMap")]
    public Dictionary<NormalRewardType, double> BurrowToo;
[UnityEngine.Serialization.FormerlySerializedAs("luckyObjDataList")]
    public List<LuckyObjData> AmpleCryTineRent;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]
    public bool GoClue;
    private bool GoLime;
[UnityEngine.Serialization.FormerlySerializedAs("onThanksWeight")]
    public int MeRetireMirage;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
    public SkeletonGraphic HeavyBall;

    private int FoulPaint;
    private int winShePaint;

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        winShePaint = BisHeadCar.instance.DramTine.base_config.lucky_card_win_max_count;
    }

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        NoseThankCape();
        HeavyBall.AnimationState.SetAnimation(0, "chuxian", false);
        HeavyBall.AnimationState.AddAnimation(0, "daiji", true, 0f);
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }

    private void Start()
    {
        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.msg_Guard_Troop_Kit_Juicy,
            (messageData) => { ShaftThankCapePress(); });
    }

    private void ShaftThankCapePress()
    {
        if (!gameObject.activeInHierarchy) return;
        ShaftUIWish(GetType().Name);
    }

    public void NoseThankCape()
    {
        FoulPaint = Random.Range(2, winShePaint) + 1;
        AmpleCryTineRent = new List<LuckyObjData>();

        GoClue = true;
        GoLime = false;
        for (int i = 0; i < AmpleCapeRent.Count; i++)
        {
            GameObject obj = AmpleCapeRent[i].gameObject;
            if (i == 4)
            {
                obj.GetComponent<ThankCapePassageway>().NoseRetireCryTine();
            }
            else
            {
                LuckyObjData objData = GameUtil.GetLuckyCardObjData();
                AmpleCryTineRent.Add(objData);
                obj.GetComponent<ThankCapePassageway>().NoseAdviceCryTine(objData);
            }

            obj.GetComponent<ThankCapePassageway>().No_Gibe.SetActive(false);
        }

        NobodyCryRent = new List<GameObject>();
        BurrowToo = new Dictionary<NormalRewardType, double>();

        Invoke(nameof(HeAie), 3f);
    }


    private void HeAie()
    {
        float WidenUser= 0.5f;

        for (int i = 0; i < AmpleCapeRent.Count; i++)
        {
            GameObject obj = AmpleCapeRent[i].gameObject;
            Vector3 objPos = obj.transform.localPosition;

            //obj.GetComponent<ThankCapePassageway>().CloseObj(); 
            obj.GetComponent<ThankCapePassageway>().CradPrimitive(obj, obj.GetComponent<ThankCapePassageway>().BG,
                obj.GetComponent<ThankCapePassageway>().NoCar, () => { },
                () =>
                {
                    obj.transform.DOLocalMove(new Vector3(0, 0, 0), 0.5f).OnComplete(() =>
                    {
                        obj.transform.DOLocalMove(objPos, 0.5f).SetDelay(WidenUser);
                    });
                });
            WidenUser = +0.1f;
        }

        Invoke(nameof(GibeClue), 2f);
    }

    private void GibeClue()
    {
        GoClue = false;
    }

    private void NorAdviceToo(LuckyObjData rewardObj)
    {
        string type = rewardObj.LuckyObjType.ToString();
        NormalRewardType BurrowRear= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        if (BurrowToo.ContainsKey(BurrowRear))
        {
            BurrowToo[BurrowRear] =
                BurrowToo[BurrowRear] + rewardObj.RewardNum;
        }
        else
        {
            BurrowToo.Add(BurrowRear, rewardObj.RewardNum);
        }
    }

    private void BuryPronePress()
    {
        for (int i = 0; i < AmpleCapeRent.Count; i++)
        {
            GameObject obj = AmpleCapeRent[i].gameObject;
            obj.GetComponent<ThankCapePassageway>().No_Gibe.SetActive(false);
        }
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_Drip, "1011");
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_ID_Go,"4");
        AdvicePressScratch.Instance.BuryChoppyAdvicePress(BurrowToo);
    }

    public void NorSparseRent(GameObject obj)
    {
        NobodyCryRent.Add(obj);

        if (NobodyCryRent.Count < FoulPaint && !GoLime)
        {
            int num = Random.Range(0, AmpleCryTineRent.Count);
            LuckyObjData objData = AmpleCryTineRent[num];
            obj.GetComponent<ThankCapePassageway>().CradPrimitive(obj, obj.GetComponent<ThankCapePassageway>().NoCar,
                obj.GetComponent<ThankCapePassageway>().BG, () =>
                {
                    obj.GetComponent<ThankCapePassageway>().No_Gibe.SetActive(true);
                    obj.GetComponent<ThankCapePassageway>().NoseAdviceCryTine(objData);
                }, () => { });
            NorAdviceToo(objData);
            AmpleCryTineRent.Remove(objData);
        }
        else
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_scratch_reward);
            GoLime = true;
            GoClue = true;
            obj.GetComponent<ThankCapePassageway>().CradPrimitive(obj, obj.GetComponent<ThankCapePassageway>().NoCar,
                obj.GetComponent<ThankCapePassageway>().BG,
                () => { obj.GetComponent<ThankCapePassageway>().NoseRetireCryTine(); }, () => { });
            Invoke(nameof(BuryPronePress), 2f);
        }
    }
}