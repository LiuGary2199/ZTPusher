// Project: Plinko
// FileName: ChoppyAdviceWarPassageway.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 16:53
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class ChoppyAdviceWarPassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    public GameObject RiftRay;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public GameObject JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject SprawlRay;
[UnityEngine.Serialization.FormerlySerializedAs("rollCashImg")]    public GameObject ScanGustRay;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]
    public Text BurrowSodAfar;

    private NormalRewardType BurrowRear;
    private double BurrowSod;


    public void NoseTine(NormalRewardType thisType, double num)
    {
        BurrowRear = thisType;
        BurrowSod = num;
        ShaftRay();
        BuryRay();
        BurrowSodAfar.text = "+ " + BurrowSod;
    }


    private void ShaftRay()
    {
        RiftRay.gameObject.SetActive(false);
        JoltRay.gameObject.SetActive(false);
        SprawlRay.gameObject.SetActive(false);
        ScanGustRay.gameObject.SetActive(false);
    }

    private void BuryRay()
    {
        switch (BurrowRear)
        {
            case NormalRewardType.Amazon:
                SprawlRay.gameObject.SetActive(true);
                break;
            case NormalRewardType.Cash:
                JoltRay.gameObject.SetActive(true);
                break;
            case NormalRewardType.RollCash:
                ScanGustRay.gameObject.SetActive(true);
                break;
            default:
                RiftRay.gameObject.SetActive(true);
                break;
        }
    }

    public void MutualSodBall(int multi)
    {
        PrimitivePassageway.MutualPartly(BurrowSod, BurrowSod * multi, 0, BurrowSodAfar, "+", () =>
        {
            BurrowSod = BurrowSod * multi;
            BurrowSodAfar.text = "+" + PartlySkin.ExpendAnSad(BurrowSod);
        });
    }


    public void BuyChoppyYouAdvice()
    {
        switch (BurrowRear)
        {
            case NormalRewardType.Amazon:
                DramPress.Instance.NorLitter(BurrowSod, SprawlRay.transform);
                break;
            case NormalRewardType.Cash:
                DramPress.Instance.NorGust(BurrowSod, JoltRay.transform);
                break;
            case NormalRewardType.RollCash:
                DramPress.Instance.NorGust(BurrowSod, JoltRay.transform);
                break;
            default:
                DramPress.Instance.NorStir(BurrowSod, RiftRay.transform);
                break;
        }
    }
}