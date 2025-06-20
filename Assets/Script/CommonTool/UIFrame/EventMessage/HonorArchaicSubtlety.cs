/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HonorArchaicSubtlety : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate MeCrest;
    public VoidDelegate MeSalt;
    public VoidDelegate MeMaker;
    public VoidDelegate MeLoan;
    public VoidDelegate MeAn;
    public VoidDelegate MeSparse;
    public VoidDelegate MeManualSparse;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static HonorArchaicSubtlety Buy(GameObject go)
    {
        HonorArchaicSubtlety listener = go.GetComponent<HonorArchaicSubtlety>();
        if (listener == null)
        {
            listener = go.AddComponent<HonorArchaicSubtlety>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (MeCrest != null)
        {
            MeCrest(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (MeSalt != null)
        {
            MeSalt(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (MeMaker != null)
        {
            MeMaker(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (MeLoan != null)
        {
            MeLoan(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (MeAn != null)
        {
            MeAn(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (MeSparse != null)
        {
            MeSparse(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (MeManualSparse != null)
        {
            MeManualSparse(gameObject);
        }
    }
}
