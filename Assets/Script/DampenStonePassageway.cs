using System;
using DG.Tweening;
using UnityEngine;

public class DampenStonePassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("posY")]    public float GemY;
[UnityEngine.Serialization.FormerlySerializedAs("stoneRadius")]    public float CedarWither;
[UnityEngine.Serialization.FormerlySerializedAs("delayTime")]    public float WidenUser;
[UnityEngine.Serialization.FormerlySerializedAs("moveTime")]    public float DecoUser;
[UnityEngine.Serialization.FormerlySerializedAs("movingFlog")]
    public bool ResortLine;

    private Sequence ResortMow;

    private void Awake()
    {
        //delayTime = 2f;
    }

    private void Start()
    {
        transform.localPosition = new Vector3(-CedarWither, GemY, -1.314f);
        DampenAie();
    }

    public void LadyDampen()
    {
        ResortLine = false;
        ResortMow.Pause();
    }

    public void MyPlainDampen()
    {
        ResortLine = true;
        ResortMow.Play();
    }

    private void DampenAie()
    {
        ResortMow = DOTween.Sequence();
        ResortMow.Append(transform.DOLocalMoveX(CedarWither, DecoUser).SetEase(Ease.InOutCubic));
        ResortMow.AppendInterval(WidenUser);
        ResortMow.Append(transform.DOLocalMoveX(-CedarWither, DecoUser).SetEase(Ease.InOutCubic));
        ResortMow.AppendInterval(WidenUser);
        ResortMow.SetLoops(-1);
        ResortMow.Play();
    }



}