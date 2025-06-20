using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntScratch : MonoBehaviour
{
    public static HuntScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("pushObj")]
    public GameObject HardCry;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    public GameObject WindCry;
[UnityEngine.Serialization.FormerlySerializedAs("gameLock")]
    public bool DownClue;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        TheirCar.BuyDuctless().NoseTheirCar();
        NucleusCandidTribe.BuyDuctless()
            .Clearing(CBuckle.msg_Guard_Troop_Kit_Juicy, (messageData) => { DramWitness(); });
    }

    public void DownNose()
    {
        bool isNewPlayer = !PlayerPrefs.HasKey(CBuckle.Go_AtDonWhence + "Bool") || AutoTineScratch.BuyGirl(CBuckle.Go_AtDonWhence);
        ElicitNoseScratch.Instance.NoseElicitTine(isNewPlayer);
        if (isNewPlayer)
        {
            // 新用户
            AutoTineScratch.YouGirl(CBuckle.Go_AtDonWhence, false);
        }
        
        CardHonorDecode.BuyDuctless().SaltHonor("1001");
        TheirCar.BuyDuctless().ExamGo(TheirRear.UIMusic.sound_bgm);
    
        DramTineScratch.BuyDuctless().NoseDramTine();
        UIManager.BuyDuctless().BuryUIVisit(nameof(DramPress));
        HardCry.gameObject.SetActive(true);
        WindCry.gameObject.SetActive(true);
    }

    public void ShineTune()
    {
        PeriodTuneWedAutonomy.Instance.MyHeTune();
    }

    public void DramWitness()
    {
        DownClue = false;
        ChoppyCarryScratch.Instance.GoClue = false;
        if (VacantSkin.AtTract())
        { 
            DonCraftUserScratch.Instance.MyPlainCraftUser();
        }
        else 
        {
            CraftUserScratch.Instance.MyPlainCraftUser(); 
        }
        WebWedPassageway.Instance.WitnessWed();
        PeriodScratch.Instance.AlwaysPeriod();
        ShineTune();
    }

    public void DramLady()
    {
        DownClue = true;
        if (VacantSkin.AtTract())
        { 
            DonCraftUserScratch.Instance.LadyCraft(); 
        } 
        else 
        {
            CraftUserScratch.Instance.LadyCraft();
        }
        WebWedPassageway.Instance.LadyWed();
        PeriodScratch.Instance.DrainPeriod();
    }
}