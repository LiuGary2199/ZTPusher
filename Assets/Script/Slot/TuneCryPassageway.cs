// Project: Plinko
// FileName: TuneCryPassageway.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 14:21
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class TuneCryPassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BigWin")]    public GameObject AidYou;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_1")]    public GameObject Gust_1;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_2")]    public GameObject Gust_2;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_3")]    public GameObject Gust_3;
[UnityEngine.Serialization.FormerlySerializedAs("SkillWall")]    public GameObject TreadPeep;
[UnityEngine.Serialization.FormerlySerializedAs("SkillBigCoin")]    public GameObject TreadAidDeal;
[UnityEngine.Serialization.FormerlySerializedAs("SkillLong")]    public GameObject TreadKeep;
[UnityEngine.Serialization.FormerlySerializedAs("GemBlue")]    public GameObject WayScam;
[UnityEngine.Serialization.FormerlySerializedAs("GemRed")]    public GameObject WayBeg;
[UnityEngine.Serialization.FormerlySerializedAs("GemDiamond")]    public GameObject WayShortly;
[UnityEngine.Serialization.FormerlySerializedAs("Golden")]    public GameObject Icicle;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjData")]
    //public Text numText;

    public SlotRewardType WindCryTine;


    public void NoseTineDoctor()
    {
        WindCryTine = GameUtil.GetSlotObjDataWithOutThanks();
        NoseTineOxTine(WindCryTine);
    }

    public void NoseTineOxTine(SlotRewardType targetObj)
    {
        //if (VacantSkin.IsApple())
        //{
        //    if (targetObj.SlotObjType == SlotObjType.Cash)
        //    {
        //        targetObj.SlotObjType = SlotObjType.Ball;
        //    }
        //}

        WindCryTine = targetObj;
        ShaftRay();
        BuryRay();
    }


    private void ShaftRay()
    {
        AidYou.gameObject.SetActive(false);
        Gust_1.gameObject.SetActive(false);
        Gust_2.gameObject.SetActive(false);
        Gust_3.gameObject.SetActive(false);
        TreadPeep.gameObject.SetActive(false);
        TreadAidDeal.gameObject.SetActive(false);
        TreadKeep.gameObject.SetActive(false);
        WayScam.gameObject.SetActive(false);
        WayBeg.gameObject.SetActive(false);
        WayShortly.gameObject.SetActive(false);
        Icicle.gameObject.SetActive(false);
    }


    private void BuryRay()
    {
        switch (WindCryTine)
        {
            case SlotRewardType.BigWin:
                AidYou.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash1:
                Gust_1.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash2:
                Gust_2.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash3:
                Gust_3.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillWall:
                TreadPeep.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillBigCoin:
                TreadAidDeal.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillLong:
                TreadKeep.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemBlue:
                WayScam.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemRed:
                WayBeg.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemDiamond:
                WayShortly.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            default:
                Icicle.gameObject.SetActive(true);
                //numText.text = "";
                break;
        }
    }
}