using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class RewardItemPerfabs
{
    public GameObject RiftDealEither_1;
    public GameObject RiftDealEither_5;
    public GameObject RiftDealEither_10;
    public GameObject RiftDealEither_50;
    public GameObject RiftDealEither_100;
    public GameObject RiftDealEither_200;
    public GameObject RiftDealEither_500;
    public GameObject JoltDealEither_1;
    public GameObject JoltDealEither_5;
    public GameObject JoltDealEither_10;
    public GameObject JoltDealEither_50;
    public GameObject JoltDealEither_100;
    public GameObject JoltDealEither_200;
    public GameObject JoltDealEither_500;
    public GameObject ScanGustEither;
    public GameObject RowShortlyEither;
    public GameObject RowScamEither;
    public GameObject RowBegEither;
    public GameObject NumberEither;
    public GameObject ImpingeCapeEither;
    public GameObject luckyCapeEither;
    public GameObject ToyDealEither;
    public GameObject OliveEither;

}
public class PeriodAdviceBark : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]    public PusherRewardType BurrowRear;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double BurrowSod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfabs")]    public RewardItemPerfabs BurrowBarkBombard;
    bool ManPlayAllow= false;
    public void PramAdviceBark(PusherRewardType type, bool canPlay = true)
    {
        ManPlayAllow = canPlay;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        BurrowRear = type;
        if (VacantSkin.AtTract() && type == PusherRewardType.CoinCash)
        {
            type = PusherRewardType.CoinGold;
            BurrowRear = PusherRewardType.CoinGold;
        }
        switch (type)
        {
            case PusherRewardType.CoinGold:
                PramStirDeal();
                break;
            case PusherRewardType.CoinCash:
                PramGustDeal();
                break;
            case PusherRewardType.RollCash:
                BurrowBarkBombard.ScanGustEither.SetActive(true);
                break;
            case PusherRewardType.LuckyCard:
                BurrowBarkBombard.luckyCapeEither.SetActive(true);
                break;
            case PusherRewardType.ScratchCard:
                BurrowBarkBombard.ImpingeCapeEither.SetActive(true);
                break;
            case PusherRewardType.GemDiamond:
                BurrowBarkBombard.RowShortlyEither.SetActive(true);
                break;
            case PusherRewardType.GemBlue:
                BurrowBarkBombard.RowScamEither.SetActive(true);
                break;
            case PusherRewardType.GemRed:
                BurrowBarkBombard.RowBegEither.SetActive(true);
                break;
            case PusherRewardType.Golden:
                BurrowBarkBombard.NumberEither.SetActive(true);
                break;
            case PusherRewardType.BigCoin:
                BurrowBarkBombard.ToyDealEither.SetActive(true);
                break;
        }

    }
    public void PramStirDeal()
    {
        int num = TineAnnualScratch.BuyDuctless().LeoStirDealSod();
        if (VacantSkin.AtTract())
        {
            BurrowBarkBombard.OliveEither.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    BurrowBarkBombard.RiftDealEither_1.SetActive(true);
                    break;
                case 5:
                    BurrowBarkBombard.RiftDealEither_5.SetActive(true);
                    break;
                case 10:
                    BurrowBarkBombard.RiftDealEither_10.SetActive(true);
                    break;
                case 50:
                    BurrowBarkBombard.RiftDealEither_50.SetActive(true);
                    break;
                case 100:
                    BurrowBarkBombard.RiftDealEither_100.SetActive(true);
                    break;
                case 200:
                    BurrowBarkBombard.RiftDealEither_200.SetActive(true);
                    break;
                case 500:
                    BurrowBarkBombard.RiftDealEither_500.SetActive(true);
                    break;
            }
        }
        
        BurrowSod = num;
    }
    public void PramGustDeal()
    {
        int num = TineAnnualScratch.BuyDuctless().LeoGustDealSod();
        if (VacantSkin.AtTract())
        {
            BurrowBarkBombard.OliveEither.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    BurrowBarkBombard.JoltDealEither_1.SetActive(true);
                    break;
                case 5:
                    BurrowBarkBombard.JoltDealEither_5.SetActive(true);
                    break;
                case 10:
                    BurrowBarkBombard.JoltDealEither_10.SetActive(true);
                    break;
                case 50:
                    BurrowBarkBombard.JoltDealEither_50.SetActive(true);
                    break;
                case 100:
                    BurrowBarkBombard.JoltDealEither_100.SetActive(true);
                    break;
                case 200:
                    BurrowBarkBombard.JoltDealEither_200.SetActive(true);
                    break;
                case 500:
                    BurrowBarkBombard.JoltDealEither_500.SetActive(true);
                    break;
            }
        }
        BurrowSod = num / 100f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ManPlayAllow)
        {
            if (GetComponent<Rigidbody>() != null)
            {
                if (BurrowRear == PusherRewardType.CoinCash || BurrowRear == PusherRewardType.CoinGold)
                {
                    if (transform.position.y < 1.269)
                    {
                        ManPlayAllow = false;
                        TheirRear.SceneMusic type = (TheirRear.SceneMusic)Enum.Parse(typeof(TheirRear.SceneMusic), "sound_coin_collide_" + UnityEngine.Random.Range(1,5));
                        TheirCar.BuyDuctless().ExamSinger(type, 0.1f);
                    }
                }
            }
        }
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
