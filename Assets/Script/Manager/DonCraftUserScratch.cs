// Project: Plinko
// FileName: CraftUserScratch.cs
// Author: AX
// CreateDate: 20230508
// CreateTime: 16:04
// Description:

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class
    DonCraftUserScratch : MonoBehaviour
{
    public static DonCraftUserScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("progressImg")]
    public Image ReferentRay;

    private int RarerCrude;
    private int RarerUser;

    private int ChronicUser;
    private int ChronicName;
[UnityEngine.Serialization.FormerlySerializedAs("isFeverTime")]
    public bool GoCraftUser;

    private double JuicyGust;
    private double LogGust;

    private bool YawnCraftUser;

    private void Awake()
    {
        Instance = this;
        GoCraftUser = false;
        YawnCraftUser = false;
        RarerCrude = BisHeadCar.instance.DramTine.base_config.fever_limit;
        RarerUser = BisHeadCar.instance.DramTine.base_config.fever_time;
    }

    private void Start()
    {
        AssetTine();
    }


    private void Update()
    {
        if (GoCraftUser)
        {
            if (!YawnCraftUser)
            {
                ReferentRay.fillAmount -= Time.deltaTime / RarerUser;
                if (ReferentRay.fillAmount == 0)
                {
                    ShaftCraftUser();
                }
            }
        }
    }

    public void LadyCraft()
    {
        YawnCraftUser = true;
    }

    public void MyPlainCraftUser()
    {
        YawnCraftUser = false;
    }

    public void AssetTine()
    {
        ChronicName = AutoTineScratch.BuyGet(CBuckle.Go_Rarer_Drug_Chronic);
        MorallyEmigrant();
    }


    public void NorCraftName()
    {
        if (GoCraftUser) return;

        ChronicName++;
        AutoTineScratch.YouGet(CBuckle.Go_Rarer_Drug_Chronic, ChronicName);
        MorallyEmigrant();
        if (ChronicName >= RarerCrude)
        {
            PlainCraftUser();
        }
    }

    private void PlainCraftUser()
    {
        AutoTineScratch.YouGet(CBuckle.Go_Rarer_Drug_Chronic, 0);
        CardHonorDecode.BuyDuctless().SaltHonor("1006");

        // TheirCar.GetInstance().PlayBg(TheirRear.UIMusic.sound_fever_bgm);

        // startCash = AutoTineScratch.GetDouble(CBuckle.sv_CumulativeCash);
        GoCraftUser = true;
        ChronicUser = RarerUser;
        // PillarManager.Instance.CloseBigWinPillar();
        // NicheNameScratch.Instance.StartFeverTimeForSteelBall();
        // PillarManager.Instance.PillarGroupMove();
        // Fx_Group.Instance.FX_Fever.SetActive(true);
    }

    private void ShaftCraftUser()
    {
        // TheirCar.GetInstance().PlayBg(TheirRear.UIMusic.sound_bgm);

        // Fx_Group.Instance.FX_Fever.SetActive(false);
        GoCraftUser = false;
        // NicheNameScratch.Instance.CloseFeverTimeForSteelBall();
        AssetTine();
        if (VacantSkin.AtTract()) return;

        // endCash = AutoTineScratch.GetDouble(CBuckle.sv_CumulativeCash);
        // double cash = Math.Round((endCash - startCash), 2);
        // AutoTineScratch.SetDouble(CBuckle.sv_big_win_cash, cash);
        // HolderScratch.Instance.StopGame();

        // AutoTineScratch.SetString(CBuckle.sv_big_win_type, "1007");
        // AutoTineScratch.SetString(CBuckle.sv_big_win_ad_id, "3");

        // UIUnable.GetInstance().ShowUIForms(nameof(AidYouPronePress));
        // double num = 10;
        // AdvicePressScratch.Instance.ShowBigRewardPanel(num);
    }

    private void MorallyEmigrant()
    {
        ReferentRay.fillAmount = 1f * ChronicName / RarerCrude;
    }
}