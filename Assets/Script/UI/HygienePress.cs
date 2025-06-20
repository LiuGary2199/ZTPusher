using Lofelt.NiceVibrations;
using UnityEngine;
using UnityEngine.UI;

public class HygienePress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("musicBtn")]    public Button AptlyOak;
[UnityEngine.Serialization.FormerlySerializedAs("soundBtn")]    public Button DiscoOak;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationBtn")]    public Button ComponentOak;
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]
    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("musicOn")]
    public GameObject AptlyOn;
[UnityEngine.Serialization.FormerlySerializedAs("musicOff")]    public GameObject AptlyEgg;
[UnityEngine.Serialization.FormerlySerializedAs("soundOn")]    public GameObject DiscoNo;
[UnityEngine.Serialization.FormerlySerializedAs("soundOff")]    public GameObject DiscoEgg;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOn")]    public GameObject ComponentNo;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOff")]    public GameObject ComponentEgg;

    private string ComponentKey;

    protected override void Awake()
    {
        base.Awake();
        ComponentKey = "sv_vibrationType";
        if (!PlayerPrefs.HasKey(ComponentKey))
        {
            AutoTineScratch.YouGet(ComponentKey, 1);
        }
    }

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        AptlyOn.gameObject.SetActive(TheirCar.BuyDuctless().BgTheirIntent);
        AptlyEgg.gameObject.SetActive(!TheirCar.BuyDuctless().BgTheirIntent);

        DiscoNo.gameObject.SetActive(TheirCar.BuyDuctless().SingerTheirIntent);
        DiscoEgg.gameObject.SetActive(!TheirCar.BuyDuctless().SingerTheirIntent);

        ComponentNo.gameObject.SetActive(AutoTineScratch.BuyGet(ComponentKey) == 1);
        ComponentEgg.gameObject.SetActive(AutoTineScratch.BuyGet(ComponentKey) != 1);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
    // Start is called before the first frame update
    void Start()
    {
        GuardOak.onClick.AddListener(() =>
        {
            HuntScratch.Instance.DramWitness();
            if (VacantSkin.AtTract()) 
            {
                ShaftUIWish(nameof(DonFuelHygienePress));
            }
            else
            {
                ShaftUIWish(GetType().Name);
            }
        });

        AptlyOak.onClick.AddListener(() =>
        {
            TheirCar.BuyDuctless().BgTheirIntent = !TheirCar.BuyDuctless().BgTheirIntent;
            AptlyOn.gameObject.SetActive(TheirCar.BuyDuctless().BgTheirIntent);
            AptlyEgg.gameObject.SetActive(!TheirCar.BuyDuctless().BgTheirIntent);
        });
        DiscoOak.onClick.AddListener(() =>
        {
            TheirCar.BuyDuctless().SingerTheirIntent = !TheirCar.BuyDuctless().SingerTheirIntent;
            DiscoNo.gameObject.SetActive(TheirCar.BuyDuctless().SingerTheirIntent);
            DiscoEgg.gameObject.SetActive(!TheirCar.BuyDuctless().SingerTheirIntent);
        });

        ComponentOak.onClick.AddListener(() =>
        {
            int vibrationType = AutoTineScratch.BuyGet(ComponentKey) * -1;
            ComponentNo.gameObject.SetActive((vibrationType == 1));
            ComponentEgg.gameObject.SetActive((vibrationType != 1));
            AutoTineScratch.YouGet(ComponentKey, vibrationType);
            HapticController.hapticsEnabled = (vibrationType == 1);
        });
    }
}