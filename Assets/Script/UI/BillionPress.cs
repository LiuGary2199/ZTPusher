using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using UnityEngine.SceneManagement;

public class BillionPress : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image TorporParis;
[UnityEngine.Serialization.FormerlySerializedAs("PassSliderImage")]    public Image AideRumbleParis;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text ReferentAfar;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    public SkeletonGraphic HeavyBall;
    AsyncOperation BrickScar;
[UnityEngine.Serialization.FormerlySerializedAs("gamebg")]

    public Image Encase;
[UnityEngine.Serialization.FormerlySerializedAs("passbg")]    public Sprite Effort;
[UnityEngine.Serialization.FormerlySerializedAs("OldPass")]    public GameObject BudAide;
[UnityEngine.Serialization.FormerlySerializedAs("NewPass")]    public GameObject DonAide;
[UnityEngine.Serialization.FormerlySerializedAs("titleObj")]    public GameObject HeavyCry;
[UnityEngine.Serialization.FormerlySerializedAs("EnterBtn")]
    public Button MakerOak;
[UnityEngine.Serialization.FormerlySerializedAs("progressObj")]    public GameObject ReferentCry;



    // Start is called before the first frame update
    void Start()
    {
        ReferentCry.SetActive(true);
        MakerOak.onClick.RemoveAllListeners();
        MakerOak.onClick.AddListener(() =>
        {
            if (VacantSkin.AtTract())
            {
                BrickScar.allowSceneActivation = true;
            }
            else {
                Destroy(transform.gameObject);
                HuntScratch.Instance.DownNose();
            }
        });
        //if (PlayerPrefs.HasKey(CBuckle.sys_AppSH))
        //{
        //    gamebg.sprite = passbg;
        //    titleAnim.gameObject.SetActive(true);
        //    titleObj.SetActive(false);
        //    OldPass.gameObject.SetActive(false);
        //    NewPass.gameObject.SetActive(true);
        //}
        //else
        //{
        //    titleAnim.gameObject.SetActive(false);
        //    titleObj.SetActive(true);
        //    OldPass.gameObject.SetActive(true);
        //    NewPass.gameObject.SetActive(false);
        //}
        if (!PlayerPrefs.HasKey(CBuckle.sys_Covering))
        {
            AutoTineScratch.YouLaunch(CBuckle.sys_Covering, I2.Loc.LocalizationManager.CurrentLanguage);
        }


        AideRumbleParis.fillAmount = 0;
        TorporParis.fillAmount = 0;
        ReferentAfar.text = "0%";

        HeavyBall.AnimationState.SetAnimation(0, "chuxian", false);
        HeavyBall.AnimationState.AddAnimation(0, "daiji", true, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (TorporParis.fillAmount <= 0.8f || (BisHeadCar.instance.Arise && CashOutManager.BuyDuctless().Ready))
        {
            AideRumbleParis.fillAmount += Time.deltaTime / 3f;
            TorporParis.fillAmount += Time.deltaTime / 3f;
            ReferentAfar.text = (int)(TorporParis.fillAmount * 100) + "%";
            if (BisHeadCar.instance.Arise && VacantSkin.AtTract() && BrickScar == null) //审核，模式 
            {
                BrickScar = SceneManager.LoadSceneAsync(1);
                BrickScar.allowSceneActivation = false;
            }
            if (TorporParis.fillAmount >= 1)
            {
                ReferentCry.SetActive(false);
                MakerOak.gameObject.SetActive(true);
            }
        }
    }
}
