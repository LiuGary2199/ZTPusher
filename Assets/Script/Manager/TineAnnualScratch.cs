using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PusherRewardType
{
    CoinGold,
    CoinCash,
    RollCash,
    GemBlue,
    GemRed,
    GemDiamond,
    Golden,
    ScratchCard,
    LuckyCard,
    BigCoin
}

public enum SlotRewardType
{
    BigWin = 0,
    Cash1 = 1,
    Cash2 = 2,
    Cash3 = 3,
    SkillWall = 4,
    SkillBigCoin = 5,
    SkillLong = 6,
    GemBlue = 7,
    GemRed = 8,
    GemDiamond = 9,
    Golden = 10,
    Null = 11
}

public class TineAnnualScratch : WhigSuccessor<TineAnnualScratch>
{
    /// <summary>
    /// 获得pusher掉落奖励
    /// </summary>
    /// <param name="item"></param>
    public void MobPeriodAdvice(PusherRewardType type, double rewardNum)
    {
        switch (type)
        {
            case PusherRewardType.CoinCash:
                DramPress.Instance.NorGust(rewardNum);
                break;
            case PusherRewardType.CoinGold:
                DramPress.Instance.NorStir(rewardNum);
                break;
            case PusherRewardType.RollCash:
                AdvicePressScratch.Instance.BuryGustDenyAdvice();
                break;
            case PusherRewardType.GemDiamond:
                DramTineScratch.BuyDuctless().NorWay(GemsType.Silver);
                break;
            case PusherRewardType.GemBlue:
                DramTineScratch.BuyDuctless().NorWay(GemsType.Blue);
                break;
            case PusherRewardType.GemRed:
                DramTineScratch.BuyDuctless().NorWay(GemsType.Yellow);
                break;
            case PusherRewardType.Golden:
                DramTineScratch.BuyDuctless().NorWay(GemsType.GoldBar);

                break;
            case PusherRewardType.ScratchCard:
                ChoppyCarryScratch.Instance.BuryCaptureCapePress();
                break;
            case PusherRewardType.LuckyCard:
                ChoppyCarryScratch.Instance.BuryThankCapePress();
                break;
            case PusherRewardType.BigCoin:
                DramPress.Instance.NorStir(1);
                break;
        }
    }

    /// <summary>
    /// 获取plinko格子创建金币的数量
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public int LeoPlinkoDealPaint(int index)
    {
        return GameUtil.GetBoxNum();
    }

    /// <summary>
    /// 获取自动掉落物体类型
    /// </summary>
    /// <returns></returns>
    public PusherRewardType LeoPeruPaceOnRear()
    {
        int typeIndex = Random.Range(0, 3);
        PusherRewardType type = PusherRewardType.RollCash;
        switch (typeIndex)
        {
            case 0:
                type = PusherRewardType.RollCash;
                break;
            case 1:
                type = PusherRewardType.ScratchCard;
                break;
            case 2:
                type = PusherRewardType.LuckyCard;
                break;
        }

        return type;
    }

    /// <summary>
    /// 获取slot中奖项(从此函数中调用slot动画)
    /// </summary>
    public void LeoTuneAdviceTine(System.Action<SlotRewardType> rewardAction)
    {
        SlotRewardType slotRewardType = GameUtil.GetSlotObjData();
        if (VacantSkin.AtTract())
        {
            while (slotRewardType == SlotRewardType.Null && DonCraftUserScratch.Instance.GoCraftUser)
            {
                slotRewardType = GameUtil.GetSlotObjData();
            }
        }
        else
        {
            while (slotRewardType == SlotRewardType.Null && CraftUserScratch.Instance.GoCraftUser)
            {
                slotRewardType = GameUtil.GetSlotObjData();
            }
        }
        rewardAction(slotRewardType);
    }

    /// <summary>
    /// 墙技能触发
    /// </summary>
    /// <param name="needShow">是否需要UI滑出动画,如果为false则只需要增加显示时长</param>
    /// <param name="time">单次增加的时长</param>
    public void TossTreadPeepUser(bool needShow, int time)
    {
        TreadScratch.Instance.PlainTreadPeep(needShow,time);
    }

    /// <summary>
    /// 加长技能触发
    /// </summary>
    /// <param name="needShow">是否需要UI滑出动画,如果为false则只需要增加显示时长</param>
    /// <param name="time">单次增加的时长</param>
    public void TossTreadKeepUser(bool needShow, int time)
    {
        TreadScratch.Instance.PlainTreadKeep(needShow,time);
    }
    /// <summary>
    /// 刷新剩余未掉落绿币显示个数
    /// </summary>
    public void TossPaceGustDealPaint(bool needShow, int count)
    {
        TreadScratch.Instance.BuryGustDealSod(needShow,count);
    }

    /// <summary>
    /// 777结束
    /// </summary>
    public void ToyYouAny()
    {

    }
    /// <summary>
    /// fever结束
    /// </summary>
    public void RarerAny()
    {

    }

    /// <summary>
    /// 获取金币面额
    /// </summary>
    /// <returns></returns>
    public int LeoStirDealSod()
    {
        double coinValues = GameUtil.GetPusherGoldReward();
        return int.Parse(coinValues.ToString());
    }

    /// <summary>
    /// 获取绿币面额
    /// </summary>
    /// <returns></returns>
    public int LeoGustDealSod()
    {
        double coinValues = GameUtil.GetPusherCashReward();
        return int.Parse(coinValues.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}