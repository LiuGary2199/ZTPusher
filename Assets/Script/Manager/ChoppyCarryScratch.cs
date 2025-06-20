// Project: Pusher
// FileName: ChoppyCarryScratch.cs
// Author: AX
// CreateDate: 20230821
// CreateTime: 9:30
// Description:

using System;
using UnityEngine;

public class ChoppyCarryScratch : MonoBehaviour
{
    public static ChoppyCarryScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    public bool GoClue;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        GoClue = false;

        // NucleusCandidTribe.GetInstance().Register(CBuckle.msg_close_panel_and_start,
        //     (messageData) => { CloseLock(); });
    }


    /*
     *
     * 各类弹窗
     */
    public void BuryThankCapePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        CardHonorDecode.BuyDuctless().SaltHonor("1010");
        AutoTineScratch.YouGet(CBuckle.Go_ID_Hotel_Cud, AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud) + 1);
        UIManager.BuyDuctless().BuryUIVisit(nameof(ThankCapePress));
    }

    public void BuryCaptureCapePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        CardHonorDecode.BuyDuctless().SaltHonor("1008");
        AutoTineScratch.YouGet(CBuckle.Go_ID_Hotel_Cud, AutoTineScratch.BuyGet(CBuckle.Go_ID_Hotel_Cud) + 1);
        UIManager.BuyDuctless().BuryUIVisit(nameof(CaptureCapePress));
    }

    public void BuryFaintlyNevusPress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;

        if (CoalSkin.Evening() - AutoTineScratch.BuyGet("sv_show_gems_times") < 10)
        {
            return;
        }

        AutoTineScratch.YouGet("sv_show_gems_times", (int) CoalSkin.Evening());

        GoClue = true;
        HuntScratch.Instance.DramLady();

        UIManager.BuyDuctless().BuryUIVisit(nameof(FaintlyNevusPress));
    }

    public void BuryHygienePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(HygienePress));
    }
    public void BuryDonHygienePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(DonFuelHygienePress));
    }
    public void BuryVeinAdvicePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(VeinAdvicePress));
    }
    public void BuryVeinPaceDealPress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(VeinPaceDealPress));
    }

    public void BuryVeinTunePress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(VeinTunePress));
    }
    
    public void BuryMailUsPress()
    {
        if (GoClue || HuntScratch.Instance.DownClue) return;

        if (VacantSkin.AtTract())
        {
            return;
        }
        GoClue = true;
        HuntScratch.Instance.DramLady();
        UIManager.BuyDuctless().BuryUIVisit(nameof(MailMyPress));
     
    }

}