using System.Collections;
using System.Collections.Generic;
using com.adjust.sdk;
using UnityEngine;
using UnityEngine.UI;

public class DramPress : ForkUIVisit
{
    public static DramPress Instance;
[UnityEngine.Serialization.FormerlySerializedAs("goldBtn")]
    public Button RiftOak;
[UnityEngine.Serialization.FormerlySerializedAs("cashBtn")]    public Button JoltOak;
[UnityEngine.Serialization.FormerlySerializedAs("amazonBtn")]    public Button SprawlOak;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]
    public Image SparRay;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public Image JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public Image SprawlRay;
[UnityEngine.Serialization.FormerlySerializedAs("ballImg")]    public Image SoilRay;
[UnityEngine.Serialization.FormerlySerializedAs("cashBar")]
    public GameObject JoltIcy;
[UnityEngine.Serialization.FormerlySerializedAs("coinBar")]    public GameObject SparIcy;
[UnityEngine.Serialization.FormerlySerializedAs("amazonBar")]    public GameObject SprawlIcy;
[UnityEngine.Serialization.FormerlySerializedAs("ballBar")]    public GameObject SoilIcy;
[UnityEngine.Serialization.FormerlySerializedAs("NormalWindow")]
    public GameObject ChoppyMemory;
[UnityEngine.Serialization.FormerlySerializedAs("PassWindow")]    public GameObject AideMemory;
[UnityEngine.Serialization.FormerlySerializedAs("newgoldBtn")]    public Button LeatherOak;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBar")]    public GameObject MarriageIcy;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeNumText")]    public Text MarriageSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("NewSettingBtn")]    public Button DonHygieneOak;
[UnityEngine.Serialization.FormerlySerializedAs("NewGoldNumText")]    public Text DonStirSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("goldNumText")]
    public Text RiftSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("cashNumText")]    public Text JoltSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("amazonNumText")]    public Text SprawlSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("ballNumText")]    public Text SoilSodAfar;
[UnityEngine.Serialization.FormerlySerializedAs("settingBtn")]
    public Button PigmentOak;
[UnityEngine.Serialization.FormerlySerializedAs("gemsStoreBtn")]    public Button WingNevusOak;
[UnityEngine.Serialization.FormerlySerializedAs("testBtn")]   // public Button sohoShopBtn;

    public Button ClayOak;
[UnityEngine.Serialization.FormerlySerializedAs("flyBoxController")]
    public WebWedPassageway ToeWedPassageway;

    // Start is called before the first frame update
    void Start()
    {
        PigmentOak.onClick.AddListener(() => { ChoppyCarryScratch.Instance.BuryHygienePress(); });
        DonHygieneOak.onClick.AddListener(() => { ChoppyCarryScratch.Instance.BuryDonHygienePress(); });

        WingNevusOak.onClick.AddListener(() => { ChoppyCarryScratch.Instance.BuryFaintlyNevusPress(); });
        //sohoShopBtn.onClick.AddListener(() =>
        //{
        //    DonPontDrownPassageway.Instance.ShowCashMask();
        //    if (AutoTineScratch.GetString(CBuckle.msg_show_rate_us) == "new")
        //    {
        //        CardHonorDecode.GetInstance().SendEvent("1002");
        //        AutoTineScratch.SetString(CBuckle.msg_show_rate_us, "show");
        //    }

        //    HuntScratch.Instance.GameStop();
        ////  SOHOShopManager.instance.ShowRedeemPanel();
        //});

        RiftOak.onClick.AddListener(() =>
        {
            if (VacantSkin.AtTract()) return;
            HuntScratch.Instance.DramLady();
            //SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });
        JoltOak.onClick.AddListener(() =>
        {
            HuntScratch.Instance.DramLady();
          //  SOHOShopManager.instance.ShowRedeemPanel();
        });
        SprawlOak.onClick.AddListener(() =>
        {
            HuntScratch.Instance.DramLady();
       //     SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });

        ClayOak.onClick.AddListener(() =>
        {
            // AddGold(5000, transform);
            // AddCash(5000,transform);
            // AddAmazon(5000,transform);
            // DramTineScratch.GetInstance().AddGem(GemsType.Silver);
            // TreadScratch.Instance.StartSkillLong(true, 5);
            // TreadScratch.Instance.StartSkillWall(true, 8);
            // TreadScratch.Instance.ShowSlotNum();
            // TreadScratch.Instance.ShowCashCoinNum(2);
            ChoppyCarryScratch.Instance.BuryMailUsPress();
            // AdvicePressScratch.Instance.ShowCashRollReward();
        });

        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.It_DramStartle,
            (messageData) =>
            {
                HuntScratch.Instance.DramWitness();
                MorallyLament();
            });

        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.Gem_Toss_Pink_us,
            (messageData) =>
            {
                    Invoke(nameof(BuryMailUsPress),0.8f);
            });

        ToeWedPassageway.SnailHopPlainWed();
        if (VacantSkin.AtTract()) 
        {
            ChoppyMemory.SetActive(false);
            AideMemory.SetActive(true);
        }
        else
        {
            ChoppyMemory.SetActive(true);
            AideMemory.SetActive(false);
        }
}

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    public override void Display()
    {
        base.Display();

        ///sohoShopBtn.gameObject.SetActive(!VacantSkin.IsApple());
        //cashBar.gameObject.SetActive(!VacantSkin.IsApple());
       // amazonBar.gameObject.SetActive(!VacantSkin.IsApple());
        SoilIcy.gameObject.SetActive(!VacantSkin.AtTract());
        MarriageIcy.gameObject.SetActive(VacantSkin.AtTract());
        // gemsStoreBtn.gameObject.SetActive(!VacantSkin.IsApple());
        print("adid: " + Adjust.getAdid());
        MorallyLament();
    }

    private void BuryMailUsPress()
    {
        ChoppyCarryScratch.Instance.BuryMailUsPress();
    }

    public void MorallyLament()
    {
        RiftSodAfar.text = DramTineScratch.BuyDuctless().BuyStir() + "";
        DonStirSodAfar.text = DramTineScratch.BuyDuctless().BuyStir() + "";
        JoltSodAfar.text = PartlySkin.ExpendAnSad(DramTineScratch.BuyDuctless().BuyGust());
        SprawlSodAfar.text = DramTineScratch.BuyDuctless().BuyLitter() + "";
        SoilSodAfar.text = DramTineScratch.BuyDuctless().BuyName() + "";
        MarriageSodAfar.text = DramTineScratch.BuyDuctless().BuyName() + "";
    }

    public void NorStir(double gold, Transform objTrans = null)
    {
        DramTineScratch.BuyDuctless().NorStir(gold);
        StirNorPrimitive(objTrans, 5);
    }

    public void NorGust(double cash, Transform objTrans = null)
    {
        DramTineScratch.BuyDuctless().NorGust(cash);
        GustNorPrimitive(objTrans, 5);
    }

    public void NorLitter(double amazon, Transform objTrans = null)
    {
        DramTineScratch.BuyDuctless().NorLitter(amazon);
        LitterNorPrimitive(objTrans, 5);
    }

    private void StirNorPrimitive(Transform startTransform, double num)
    {
       
        if (VacantSkin.AtTract()) 
        {
            NorPrimitive(startTransform, SparRay.transform, SparRay.gameObject, DonStirSodAfar,DramTineScratch.BuyDuctless().BuyStir(), num);
        } else
        {
            NorPrimitive(startTransform, SparRay.transform, SparRay.gameObject, RiftSodAfar,DramTineScratch.BuyDuctless().BuyStir(), num);
        }

    }

    //  加现金动画
    private void GustNorPrimitive(Transform startTransform, double num)
    {
        NorPrimitive(startTransform, JoltRay.transform, JoltRay.gameObject, JoltSodAfar,
            DramTineScratch.BuyDuctless().BuyGust(), num);
    }

    // 加亚马逊币动画
    private void LitterNorPrimitive(Transform startTransform, double num)
    {
        NorPrimitive(startTransform, SprawlRay.transform, SprawlRay.gameObject, SprawlSodAfar,
            DramTineScratch.BuyDuctless().BuyLitter(), num);
    }

    private void NorPrimitive(Transform startTransform, Transform endTransform, GameObject icon, Text text,
        double textValue, double num)
    {
        if (startTransform != null)
        {
            PrimitivePassageway.StirJeanWine(icon, Mathf.Max((int) num, 1), startTransform, endTransform,
                () =>
                {
                    TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_getcoin);
                    PrimitivePassageway.MutualPartly(double.Parse(text.text), textValue, 0.1f, text,
                        () => { text.text = PartlySkin.ExpendAnSad(textValue); });
                });
        }
        else
        {
            PrimitivePassageway.MutualPartly(double.Parse(text.text), textValue, 0.1f, text,
                () => { text.text = PartlySkin.ExpendAnSad(textValue); });
        }
    }
}