// Project: Plinko
// FileName: NicheNameScratch.cs
// Author: AX
// CreateDate: 20230427
// CreateTime: 15:20
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class NicheNameScratch : MonoBehaviour
{
    public static NicheNameScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("currentBallNum")]
    public int ChronicNameSod;

    private float SoilCrude;

    private double InclusionUp;

    private bool YawnHoly;

    private bool GoCraftUser;

    string HeUser;

    private bool FarceNameClue;

    private void Awake()
    {
        Instance = this;
        SoilCrude = BisHeadCar.instance.DramTine.base_config.ball_limit;
        InclusionUp = BisHeadCar.instance.DramTine.base_config.multiball_cd;
        ChronicNameSod = AutoTineScratch.BuyGet(CBuckle.Go_Farce_Soil_Cud);
    }

    private void Start()
    {
        MorallyTine();
        StartCoroutine(nameof(SurfaceNicheName));
    }


    public bool PaceName()
    {
        ChronicNameSod = AutoTineScratch.BuyGet(CBuckle.Go_Farce_Soil_Cud);
        if (ChronicNameSod <1)
        {
            ChoppyCarryScratch.Instance.BuryVeinAdvicePress();
            return false;
        }

        ChronicNameSod--;
        MorallyTine();
        return true;
    }

    public bool PaceDealSitTract()//审核用的 
    {
        ChronicNameSod = AutoTineScratch.BuyGet(CBuckle.Go_Farce_Soil_Cud);
        if (ChronicNameSod < 1)
        {
            ChoppyCarryScratch.Instance.BuryVeinPaceDealPress();
            return false;
        }
        ChronicNameSod--;
        MorallyTine();
        return true;
    }


    public void NorNicheName()
    {
        ChronicNameSod = BisHeadCar.instance.DramTine.base_config.ball_limit;
        StopCoroutine(nameof(SurfaceNicheNameUser));
        HeUser = "";
        // DramPress.Instance.cdText.text = cdTime;
        MorallyTine();
    }


    private void MorallyTine()
    {
        //Debug.Log("currentBallNum"+ currentBallNum);
        AutoTineScratch.YouGet(CBuckle.Go_Farce_Soil_Cud, ChronicNameSod);
        DramTineScratch.BuyDuctless().NorName(ChronicNameSod);
        DramPress.Instance.SoilSodAfar.text = ChronicNameSod + "";
        DramPress.Instance.MarriageSodAfar.text = ChronicNameSod + "";
        // DramPress.Instance.cdText.text = cdTime;
    }



    IEnumerator SurfaceNicheName()
    {
        while (ChronicNameSod > -10)
        {
            if (ChronicNameSod < SoilCrude)
            {
                string time = AutoTineScratch.BuyLaunch(CBuckle.Go_Farce_Soil_Hike);
                if (time.Length == 0)
                {
                    AutoTineScratch.YouLaunch(CBuckle.Go_Farce_Soil_Hike, DateTime.Now.ToString());
                    StopCoroutine(nameof(SurfaceNicheNameUser));
                    StartCoroutine(nameof(SurfaceNicheNameUser));
                }
                else
                {
                    int timenow = BuyStatueTine.BuyDuctless().WetCoalWold(time, DateTime.Now);
                    int a = (int) ( timenow / InclusionUp);
                    if (a >= 1)
                    {
                        ChronicNameSod += a;
                  
                        AutoTineScratch.YouLaunch(CBuckle.Go_Farce_Soil_Hike, DateTime.Now.ToString());
                        if (ChronicNameSod < SoilCrude)
                        {
                            DramTineScratch.BuyDuctless().NorName(a);
                            StopCoroutine(nameof(SurfaceNicheNameUser));
                            StartCoroutine(nameof(SurfaceNicheNameUser));
                        }
                        else
                        {
                            DramTineScratch.BuyDuctless().NorName((int)(ChronicNameSod-SoilCrude));
                            ChronicNameSod = (int) SoilCrude;
                            StopCoroutine(nameof(SurfaceNicheNameUser));
                            HeUser = "";
                            // DramPress.Instance.cdText.text = cdTime;
                        }
                    }
                    else
                    {
                        if (HeUser == "")
                        {
                            StopCoroutine(nameof(SurfaceNicheNameUser));
                            StartCoroutine(nameof(SurfaceNicheNameUser));
                        }
                    }
                }

                MorallyTine();
            }

            yield return new WaitForSeconds((float) 0.05);
        }
    }

    IEnumerator SurfaceNicheNameUser()
    {
        for (int i = (int) InclusionUp; i > 0; i--)
        {
            HeUser = i + "s";
            // DramPress.Instance.cdText.text = cdTime;
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator MutualNicheNameClue()
    {
        // yield return new WaitForSeconds((float) multiballCd);
        yield return new WaitForSeconds(0.5f);
        FarceNameClue = false;
    }
}