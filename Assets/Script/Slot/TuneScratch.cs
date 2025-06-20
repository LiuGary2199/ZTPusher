// Project: Plinko
// FileName: TuneScratch.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 11:26
// Description:

using System;
using System.Collections;
using System.IO;
using DG.Tweening;
using DG.Tweening.Plugins.Options;
using Lofelt.NiceVibrations;
using UnityEngine;

public class TuneScratch : MonoBehaviour
{
    public static TuneScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup01")]
    public GameObject WindCheck01;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup02")]    public GameObject WindCheck02;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup03")]    public GameObject WindCheck03;
[UnityEngine.Serialization.FormerlySerializedAs("inLittleGame")]
    public bool inTemperDram;

    private SlotRewardType WindCryTine;

    private bool AptlyHoly;
    private bool GoAide;

    private Sequence WindMow;

    private void Awake()
    {
        Instance = this;
        AptlyHoly = false;
        GoAide = false;
    }

    public void MorallyTuneCheck()
    {
        WindCheck01.transform.localPosition = new Vector3(-0.88f, 0, 0);
        WindCheck02.transform.localPosition = new Vector3(0, 0, 0);
        WindCheck03.transform.localPosition = new Vector3(0.88f, 0, 0);

        WindCheck01.GetComponent<TuneCryCheckPassageway>().MorallyTine();
        WindCheck02.GetComponent<TuneCryCheckPassageway>().MorallyTine();
        WindCheck03.GetComponent<TuneCryCheckPassageway>().MorallyTine();
    }

    public void TuneLady()
    {
        GoAide = true;
        WindCheck01.transform.DOPause();
        WindCheck02.transform.DOPause();
        WindCheck03.transform.DOPause();
    }

    public void TuneMyPlain()
    {
        GoAide = false;
        WindCheck01.transform.DOPlay();
        WindCheck02.transform.DOPlay();
        WindCheck03.transform.DOPlay();
    }

    public void PlainTune()
    {
        
        if (WindCryTine == SlotRewardType.Null)
        {
            SlotRewardType slotObjData1 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData3 = GameUtil.GetSlotObjDataWithOutThanks();
            while (slotObjData1 == slotObjData2)
            {
                slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            }

            WindCheck01.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(slotObjData1);
            WindCheck02.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(slotObjData2);
            WindCheck03.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(slotObjData3);
        }
        else
        {
            WindCheck01.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(WindCryTine);
            WindCheck02.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(WindCryTine);
            WindCheck03.GetComponent<TuneCryCheckPassageway>().WeldonAdviceCry(WindCryTine);
        }
        
    }

    private void JeanAie(Action finish)
    {
        AptlyHoly = true;
        StartCoroutine(nameof(ExamTuneTheir));
        WindCheck01.transform.DOLocalMoveY(-1f * 28,3f).OnComplete(() =>
        {
            //音效
            TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slotwheel_stop);
        });
        WindCheck02.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.3f).OnComplete(() =>
        {
            //音效
            TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slotwheel_stop);
        });
        WindCheck03.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.6f).OnComplete(() =>
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slotwheel_stop);

            StopCoroutine(nameof(ExamTuneTheir));
            WindCheck03.transform.DOScale(1f, 0f).SetDelay(1f).OnComplete(() =>
            {
                PeriodTuneWedAutonomy.Instance.GoTuneHoly = false;
                //音效
            
                AptlyHoly = false;

                finish();
                MorallyTuneCheck();
                if (WindCryTine == SlotRewardType.Null)
                {
                    Invoke(nameof(BuryRetirePress), 0.5f);
                }
                else
                {
                    HuntScratch.Instance.ShineTune();
                }
            });
        });
    }


    public void NorReasonSod(SlotRewardType targetType)
    {

        // PlaySlot();
    }


    public void ExamTune(SlotRewardType targetType ,Action finish)
    {
        WindCryTine = targetType;
        CardHonorDecode.BuyDuctless().SaltHonor("1003",WindCryTine.ToString());
        AptlyHoly = false;
        PlainTune();
        JeanAie(finish);
    }

    private void BuryRetirePress()
    {
        if (!inTemperDram)
        {
            ChoppyCarryScratch.Instance.BuryVeinTunePress();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            // PlaySlot();
        }
    }


    IEnumerator ExamTuneTheir()
    {
        while (AptlyHoly)
        {
            if (!GoAide)
            {
                TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.sound_slotwheel_rotate, 0.1f);
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
    public void Start()
    {
        //根据分辨率不同修改slot位置
        //float x = -0.616f* Screen.height - 159;
        //gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, x);
    }
    public void ShaftTuneBG()
    {
     this.gameObject.SetActive(false);
    }
}