// Project: Plinko
// FileName: VaseBentPassageway.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:19
// Description:

using System;
using DG.Tweening;
using UnityEngine;

    public class VaseBentPassageway : MonoBehaviour
    {
[UnityEngine.Serialization.FormerlySerializedAs("handImg")]        public GameObject ToneRay;

        private void Start()
        {
            PlainBall();
        }

        private void PlainBall()
        {
           Sequence  handSeq = DOTween.Sequence();
           handSeq.Append(ToneRay.transform.DOLocalMoveY(25f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.Append(ToneRay.transform.DOLocalMoveY(0f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.SetLoops(-1);
           handSeq.Play();
        }

    }
