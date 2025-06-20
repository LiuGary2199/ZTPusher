using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CirclePast : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject BelterCry;
[UnityEngine.Serialization.FormerlySerializedAs("CurrentRadius")]
    public float EveningWither;
[UnityEngine.Serialization.FormerlySerializedAs("TargetRadius")]    public float EmployWither;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    public float TempleUser= 0f;

    private Material Surprise;


    private ImminentHonorMechanize DiverMechanize;


    private void Start()
    {
        Vector3 targetPos = BelterCry.transform.localPosition * 0.7f;
        Vector4 centerMat = new Vector4(targetPos.x, targetPos.y, 0, 0);
        Surprise = GetComponent<Image>().material;
        Surprise.SetVector("_Center", centerMat);


        DiverMechanize = GetComponent<ImminentHonorMechanize>();
        if (DiverMechanize != null)
        {
            DiverMechanize.SetEmployParis(BelterCry.gameObject.GetComponent<Image>());
        }
    }


    /// <summary>
    /// 收缩速度
    /// </summary>
    private float TempleSpectrum= 0f;

    private void Update()
    {
        float value = Mathf.SmoothDamp(EveningWither, EmployWither, ref TempleSpectrum, TempleUser);
        if (!Mathf.Approximately(value, EveningWither))
        {
            EveningWither = value;
            Surprise.SetFloat("_Slider", EveningWither);
        }
    }
}