// Project: HappyBingo-Real
// FileName: ObeyPastPress.cs
// Author: AX
// CreateDate: 20230220
// CreateTime: 9:55
// Description:

using UnityEngine;
using UnityEngine.UI;

public class ObeyPastPressMoral : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    public float BelterLitterX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    public float BelterLitterY;
    private Material Surprise;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
    public float ChronicLitterX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    public float ChronicLitterY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]
    public float BelterTugX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    public float BelterTugY;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]
    public float TempleUser= 0.3f;
    private ImminentHonorMechanize DiverMechanize;
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject BelterCry;


    private float TempleSpectrumX= 0f;
    private float TempleSpectrumY= 0f;


    private void Start()
    {
        Vector4 centerMat = new Vector4(BelterTugX, BelterTugY, 0, 0);
        Surprise = GetComponent<Image>().material;
        Surprise.SetVector("_Center", centerMat);


        DiverMechanize = GetComponent<ImminentHonorMechanize>();
        if (DiverMechanize != null)
        {
            DiverMechanize.SetEmployParis(BelterCry.gameObject.GetComponent<Image>());
        }
    }

    private void Update()
    {
        
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(ChronicLitterX, BelterLitterX, ref TempleSpectrumX, TempleUser);
        float valueY = Mathf.SmoothDamp(ChronicLitterY, BelterLitterY, ref TempleSpectrumY, TempleUser);
        if (!Mathf.Approximately(valueX, ChronicLitterX))
        {
            ChronicLitterX = valueX;
            Surprise.SetFloat("_SliderX", ChronicLitterX);
        }

        if (!Mathf.Approximately(valueY, ChronicLitterY))
        {
            ChronicLitterY = valueY;
            Surprise.SetFloat("_SliderY", ChronicLitterY);
        }
    }
    
    
    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 SixthAnLatterTug(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
    
}