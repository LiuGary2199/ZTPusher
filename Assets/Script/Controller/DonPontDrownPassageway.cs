// Project: Plinko
// FileName: DonPontDrownPassageway.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:28
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class DonPontDrownPassageway : MonoBehaviour
{
    public static DonPontDrownPassageway Instance;
[UnityEngine.Serialization.FormerlySerializedAs("step1Btn")]
    public Button Loam1Oak;
[UnityEngine.Serialization.FormerlySerializedAs("step2Btn")]
    public Button Loam2Oak;
[UnityEngine.Serialization.FormerlySerializedAs("step3Btn")]
    public Button Loam3Oak;
[UnityEngine.Serialization.FormerlySerializedAs("step4Btn")]
    public Button Loam4Oak;
[UnityEngine.Serialization.FormerlySerializedAs("cashMaskObj")]
    public GameObject JoltPastCry;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Loam1Oak.onClick.AddListener(() =>
        {
            Loam1Oak.gameObject.SetActive(false);
            Invoke(nameof(BuryKiln2Oak), 0.3f);
        });

        Loam2Oak.onClick.AddListener(() =>
        {
            Loam2Oak.gameObject.SetActive(false);
            Invoke(nameof(BuryKiln3Oak), 0.3f);
        });


        Loam3Oak.onClick.AddListener(() =>
        {
            Loam3Oak.gameObject.SetActive(false);
            Invoke(nameof(BuryKiln4Oak), 0.3f);
        });


        Loam4Oak.onClick.AddListener(() =>
        {
            Loam4Oak.gameObject.SetActive(false);
            PlainDram();
        });

        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.Gem_Toss_Jolt_Zone,
            (messageData) =>
            {
                Invoke(nameof(BuryGustPast),0.5f);
            });


        NoseTine();
    }


    private void BuryKiln2Oak()
    {
        Loam2Oak.gameObject.SetActive(true);
    }

    private void BuryKiln3Oak()
    {
        Loam3Oak.gameObject.SetActive(true);
    }

    private void BuryKiln4Oak()
    {
        Loam4Oak.gameObject.SetActive(true);
    }

    private void PlainDram()
    {
        AutoTineScratch.YouLaunch(CBuckle.Go_Secret_Few_Bush_Chalk, "done");
        HuntScratch.Instance.DramWitness();
    }

    public void NoseTine()
    {
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Secret_Few_Bush_Chalk) == "new" && !VacantSkin.AtTract())
        {
            Loam1Oak.gameObject.SetActive(true);
            Loam2Oak.gameObject.SetActive(false);
            Loam3Oak.gameObject.SetActive(false);
            Loam4Oak.gameObject.SetActive(false);
            JoltPastCry.gameObject.SetActive(false);
            HuntScratch.Instance.DramLady();
        }
        else
        {
            Loam1Oak.gameObject.SetActive(false);
            Loam2Oak.gameObject.SetActive(false);
            Loam3Oak.gameObject.SetActive(false);
            Loam4Oak.gameObject.SetActive(false);
            JoltPastCry.gameObject.SetActive(false);
        }
    }


    public void BuryGustPast()
    {
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Idiom_Jolt_Fad) == "new")
        {
            AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Jolt_Fad, "done");

            if (VacantSkin.AtTract())
            {
                return;
            }

            HuntScratch.Instance.DramLady();
            JoltPastCry.gameObject.SetActive(true);
        }
        else
        {
            HuntScratch.Instance.DramWitness();
            JoltPastCry.gameObject.SetActive(false);
        }
    }
}