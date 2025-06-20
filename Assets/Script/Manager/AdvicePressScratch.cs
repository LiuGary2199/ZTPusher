// Project: Pusher
// FileName: AdvicePressScratch.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 17:33
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;

public class AdvicePressScratch : MonoBehaviour
{
    public static AdvicePressScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    public bool GoClue;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        GoClue = false;

        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.msg_Guard_Troop_Kit_Juicy,
            (messageData) => { ShaftClue(); });
    }


    private void ShaftClue()
    {
        GoClue = false;
    }


    // show big win panel
    public void BuryAidAdvicePress(double num)
    {
        if (GoClue) return;

        GoClue = true;
        if (VacantSkin.AtTract())
        {
            return;
        }
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(AidYouPronePress));
        AidYouPronePress.Instance.NoseTine(num);
    }

    // show normal win panel
    public void BuryChoppyAdvicePress(Dictionary<NormalRewardType, double> rewardMap)
    {
        if (GoClue) return;
        GoClue = true;
        UIManager.BuyDuctless().BuryUIVisit(nameof(ChoppyYouPronePress));
        ChoppyYouPronePress.Instance.NoseTine(rewardMap);
    }


    public void BuryGustDenyAdvice()
    {
        HuntScratch.Instance.DramLady();
        Dictionary<NormalRewardType, double> BurrowToo= new Dictionary<NormalRewardType, double>();

        double num = GameUtil.GetCashRollReward();
        BurrowToo[NormalRewardType.RollCash] = num;
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_Drip, "1012");
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_ID_Go,"5");
        BuryChoppyAdvicePress(BurrowToo);
    }

}