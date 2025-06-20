using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodTuneWedAutonomy : MonoBehaviour
{
    public static PeriodTuneWedAutonomy Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotCount")]
    public int WindPaint;
[UnityEngine.Serialization.FormerlySerializedAs("isSlotFlag")]    public bool GoTuneHoly;

    private void Awake()
    {
        Instance = this;
        WindPaint = 0;
        GoTuneHoly = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_enter_box);
        PeriodScratch.Instance.LeoPaceAdvice(other.transform.parent.GetComponent<PeriodAdviceBark>().BurrowRear,
            other.transform.parent.GetComponent<PeriodAdviceBark>().BurrowSod);

        ExamRawTune();
        other.transform.parent.gameObject.SetActive(false);
    }

    public void ExamRawTune()
    {
        NorTunePaint();
        DoTune();
    }

    public void NorTunePaint()
    {
        WindPaint++;
        TreadScratch.Instance.BuryTuneSod(true, WindPaint);
    }


    private void DoTune()
    {
        if (GoTuneHoly) return;
        TreadScratch.Instance.BuryTuneSod(true, WindPaint);
        GoTuneHoly = true;
        WindPaint--;
        PeriodScratch.Instance.JuicyTune();
    }

    public void MyHeTune()
    {
        if (WindPaint < 1)
        {
            TreadScratch.Instance.BuryTuneSod(false, WindPaint);
            return;
        }

        DoTune();
        // Invoke("DoSlot", 1f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ExamRawTune();
        }
    }
}