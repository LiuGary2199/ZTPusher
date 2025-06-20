using UnityEngine;
using UnityEngine.UI;

public class ObeyPastPress : ForkUIVisit
{
    [Header("目标设置")]
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject BelterCry;
[UnityEngine.Serialization.FormerlySerializedAs("padding")]    public float Educate= 10f; // 目标周围的边距

    [Header("动画设置")]
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    public float TempleUser= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    public float BelterLitterX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    public float BelterLitterY;

    private Material Surprise;
    private RectTransform BelterObey;
    private Canvas BelterLatter;
    private RectTransform ZoneObey;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
    public float ChronicLitterX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    public float ChronicLitterY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]    public float BelterTugX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    public float BelterTugY;

    private float TempleSpectrumX= 0f;
    private float TempleSpectrumY= 0f;
    private ImminentHonorMechanize DiverMechanize;
    private bool CanEmployCry= false;

    private void Start()
    {
        ZoneObey = GetComponent<RectTransform>();
        Surprise = GetComponent<Image>().material;
        DiverMechanize = GetComponent<ImminentHonorMechanize>();

        // 检查是否有目标对象
        if (BelterCry != null)
        {
            BelterObey = BelterCry.GetComponent<RectTransform>();
            if (BelterObey != null)
            {
                BelterLatter = BelterCry.GetComponentInParent<Canvas>();
                if (BelterLatter != null)
                {
                    CanEmployCry = true;
                    ManualEmployDelectable();
                }
            }
        }

        if (!CanEmployCry)
        {
            // 原逻辑：使用Inspector中设置的参数
            Vector4 centerMat = new Vector4(BelterTugX, BelterTugY, 0, 0);
            Surprise.SetVector("_Center", centerMat);
        }

        if (DiverMechanize != null && CanEmployCry)
        {
            DiverMechanize.YouEmployObey(BelterObey);
        }
    }

    private void Update()
    {
        if (CanEmployCry)
        {
            ManualEmployDelectable();
        }

        // 原逻辑：平滑动画
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

    private void ManualEmployDelectable()
    {
        // 获取目标在屏幕空间的位置
        Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(BelterLatter.worldCamera, BelterObey.position);

        // 转换为遮罩面板的本地坐标
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(ZoneObey, screenPos, BelterLatter.worldCamera, out localPos);

        // 设置遮罩中心为目标中心
        BelterTugX = localPos.x;
        BelterTugY = localPos.y;
        Surprise.SetVector("_Center", new Vector4(BelterTugX, BelterTugY, 0, 0));

        // 设置遮罩大小为目标大小加上边距
        BelterLitterX = (BelterObey.rect.width / 2) + Educate;
        BelterLitterY = (BelterObey.rect.height / 2) + Educate;
    }

    // 外部调用：设置新的目标对象
    public void YouEmploy(GameObject newTarget)
    {
        BelterCry = newTarget;

        if (BelterCry != null)
        {
            BelterObey = BelterCry.GetComponent<RectTransform>();
            if (BelterObey != null)
            {
                BelterLatter = BelterCry.GetComponentInParent<Canvas>();
                if (BelterLatter != null)
                {
                    CanEmployCry = true;
                    ManualEmployDelectable();

                    if (DiverMechanize != null)
                    {
                        DiverMechanize.YouEmployObey(BelterObey);
                    }
                }
            }
        }
        else
        {
            CanEmployCry = false;
        }
    }
}