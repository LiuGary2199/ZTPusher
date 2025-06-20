// Project: Plinko
// FileName: CaptureCryPassageway.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 10:13
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class CaptureCryPassageway : MonoBehaviour
{
    public static CaptureCryPassageway Instance;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    public GameObject RiftRay;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject SprawlRay;
[UnityEngine.Serialization.FormerlySerializedAs("circleImg")]    public GameObject RarefyRay;
[UnityEngine.Serialization.FormerlySerializedAs("mainNumText")]
    public Text MuteSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    public Text BurrowSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("mainNum")]
    public int MuteSod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double BurrowSod;
[UnityEngine.Serialization.FormerlySerializedAs("scratchObjData")]
    public ScratchObjData ImpingeCryTine;

    private void Awake()
    {
        Instance = this;
    }


    private void ShaftRay()
    {
        RiftRay.gameObject.SetActive(false);
        JoltRay.gameObject.SetActive(false);
        SprawlRay.gameObject.SetActive(false);
        RarefyRay.gameObject.SetActive(false);
    }

    private void BuryRay()
    {
        switch (ImpingeCryTine.ScratchObjType)
        {
            case ScratchObjType.Amazon:
                BurrowSod = ImpingeCryTine.RewardNum * GameUtil.GetAmazonMulti();
                BurrowSodAfar.text = "" + BurrowSod;
                SprawlRay.gameObject.SetActive(true);
                break;
            case ScratchObjType.Cash:
                double cashNum = ImpingeCryTine.RewardNum * GameUtil.GetCashMultiWithOutRandom();
                BurrowSod = Math.Round(cashNum, 2);
                BurrowSodAfar.text = "" + BurrowSod;
                JoltRay.gameObject.SetActive(true);
                break;
            default:
                BurrowSod = ImpingeCryTine.RewardNum * GameUtil.GetGoldMulti();
                BurrowSodAfar.text = "" + BurrowSod;
                RiftRay.gameObject.SetActive(true);
                break;
        }
        ImpingeCryTine.RewardNum = BurrowSod;
    }

    public void BuryEmploy()
    {
        // TheirCar.GetInstance().PlayEffect(TheirRear.UIMusic.sound_scratch_reward);
        RarefyRay.gameObject.SetActive(true);
        MuteSodAfar.color = new Color(1f, 1f, 0f);
    }

    public void NoseTine(int num, bool isRewardNumber = false)
    {
        MuteSod = num;
        MuteSodAfar.text = num + "";
        MuteSodAfar.color = new Color(1f, 1f, 1f);
        if (isRewardNumber)
        {
            ImpingeCryTine = GameUtil.GetScratchObjData();
        }
        else
        {
            int Daily= BisHeadCar.instance.DramTine.scratch_data_list.Count;
            ScratchDataItem item = BisHeadCar.instance.DramTine.scratch_data_list[UnityEngine.Random.Range(0, Daily)];
            ImpingeCryTine = new ScratchObjData();
            ImpingeCryTine.RewardNum = item.reward_num;
            ImpingeCryTine.ScratchObjType = (ScratchObjType)Enum.Parse(typeof(ScratchObjType), item.type);
        }

        if (VacantSkin.AtTract())
        {
            ImpingeCryTine.ScratchObjType = ScratchObjType.Gold;
        }

        ShaftRay();
        BuryRay();
    }
}