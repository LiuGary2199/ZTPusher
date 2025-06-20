using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class ImminentHonorMechanize : MonoBehaviour, ICanvasRaycastFilter
{
    private Image BelterParis;
    private RectTransform BelterObey;
    public void SetEmployParis(Image target)
    {
        BelterParis = target;
    }
    public void YouEmployObey(RectTransform rect)
    {
        BelterObey = rect;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (BelterParis == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(BelterParis.rectTransform, sp, eventCamera);
    }
}