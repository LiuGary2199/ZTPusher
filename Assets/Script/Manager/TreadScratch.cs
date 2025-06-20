// Project: Pusher
// FileName: TreadScratch.cs
// Author: AX
// CreateDate: 20230823
// CreateTime: 14:33
// Description:

using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TreadScratch : MonoBehaviour
{
    public static TreadScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("skillWall")]
    public GameObject ExistPeep;
[UnityEngine.Serialization.FormerlySerializedAs("skillLong")]    public GameObject ExistKeep;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    public GameObject WindCry;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinObj")]    public GameObject JoltDealCry;
[UnityEngine.Serialization.FormerlySerializedAs("skillLongText")]
    public Text ExistKeepAfar;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallText")]    public Text ExistPeepAfar;
[UnityEngine.Serialization.FormerlySerializedAs("slotNumText")]    public Text WindSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinNumText")]    public Text JoltDealSodAfar;


    private int ExistPeepUser;
    private int ExistKeepUser;
    private int JoltDealUser;

    private bool WindHoly;


    private void Awake()
    {
        Instance = this;
        ExistPeepUser = 0;
        ExistKeepUser = 0;
        JoltDealUser = 0;
        WindHoly = false;
    }


    private void BuryTreadKeepAie()
    {
        ExistKeep.transform.DOLocalMoveX(-450, 0.5f);
    }

    private void ShaftTreadKeepAie()
    {
        ExistKeep.transform.DOLocalMoveX(-725, 0.5f);
        StopCoroutine(nameof(TreadKeepGuess));
    }

    private void BuryTreadPeepAie()
    {
        ExistPeep.transform.DOLocalMoveX(450, 0.5f);
    }

    private void ShaftTreadPeepAie()
    {
        ExistPeep.transform.DOLocalMoveX(725, 0.5f);
        StopCoroutine(nameof(TreadPeepGuess));
    }

    public void PlainTreadKeep(bool flag, int time)
    {
        if (flag)
        {
            BuryTreadKeepAie();
            ExistKeepUser = 0;
        }

        ExistKeepUser += time;
        StopCoroutine(nameof(TreadKeepGuess));
        StartCoroutine(nameof(TreadKeepGuess));
    }

    public void PlainTreadPeep(bool flag, int time)
    {
        if (flag)
        {
            BuryTreadPeepAie();
            ExistPeepUser = 0;
        }

        ExistPeepUser += time;
        StopCoroutine(nameof(TreadPeepGuess));
        StartCoroutine(nameof(TreadPeepGuess));
    }


    public void BuryTuneSod(bool flag,int num)
    {
        WindSodAfar.text = num + "";
        if (flag)
        {
            if (WindHoly) return;
            WindHoly = true;
            WindCry.transform.DOLocalMoveX(-450, 0.5f);
        }
        else
        {
            WindHoly = false;
            WindSodAfar.text = num +"";
            WindCry.transform.DOLocalMoveX(-725, 0.5f);
        }

    }
    
    

    public void BuryGustDealSod(bool flag, int num)
    {
        JoltDealSodAfar.text = num + "";
        if (flag)
        {
            JoltDealCry.transform.DOLocalMoveX(450, 0.5f);
        }

        if (num == 1)
        {
            JoltDealSodAfar.text = "0";
            JoltDealCry.transform.DOLocalMoveX(725, 0.5f).SetDelay(1f);
        }
        
    }


    IEnumerator TreadKeepGuess()
    {
        while (ExistKeepUser > 0)
        {
            ExistKeepUser--;
            ExistKeepAfar.text = ExistKeepUser + "";

            if (ExistKeepUser == 0)
            {
                ShaftTreadKeepAie();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator TreadPeepGuess()
    {
        while (ExistPeepUser > 0)
        {
            ExistPeepUser--;
            ExistPeepAfar.text = ExistPeepUser + "";
            if (ExistPeepUser == 0)
            {
                ShaftTreadPeepAie();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator GustDealGuess()
    {
        while (ExistPeepUser > 0)
        {
            ExistPeepUser--;

            if (ExistPeepUser == 0)
            {
                ShaftTreadPeepAie();
            }

            yield return new WaitForSeconds(1);
        }
    }
}