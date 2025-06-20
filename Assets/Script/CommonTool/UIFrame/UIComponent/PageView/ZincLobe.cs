/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ZincLobe : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Stag;
    //求出每页的临界角，页索引从0开始
    List<float> GemRent= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool GoWeed= false;
    bool SignJean= true;
    //滑动的起始坐标  
    float BelterAccelerate= 0;
    float JuicyWeedAccelerate;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Columbia= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Elimination= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> NoZincMutual;
    //当前页面下标
    int ChronicZincImage= -1;
    void Start()
    {
        Stag = this.GetComponent<ScrollRect>();
        float horizontalLength = Stag.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        GemRent.Add(0);
        for(int i = 1; i < Stag.content.childCount - 1; i++)
        {
            GemRent.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        GemRent.Add(1);
    }

    
    void Update()
    {
        if(!GoWeed && !SignJean)
        {
            startTime += Time.deltaTime;
            float t = startTime * Columbia;
            Stag.horizontalNormalizedPosition = Mathf.Lerp(Stag.horizontalNormalizedPosition, BelterAccelerate, t);
            if (t >= 1)
            {
                SignJean = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void YouZincImage(int index)
    {
        if (ChronicZincImage != index)
        {
            ChronicZincImage = index;
            if (NoZincMutual != null)
            {
                NoZincMutual(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        GoWeed = true;
        JuicyWeedAccelerate = Stag.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Stag.horizontalNormalizedPosition;
        posX += ((posX - JuicyWeedAccelerate) * Elimination);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Panel= 0;
        float offset = Mathf.Abs(GemRent[Panel] - posX);
        for(int i = 0; i < GemRent.Count; i++)
        {
            float temp = Mathf.Abs(GemRent[i] - posX);
            if (temp < offset)
            {
                Panel = i;
                offset = temp;
            }
        }
        YouZincImage(Panel);
        BelterAccelerate = GemRent[Panel];
        GoWeed = false;
        startTime = 0f;
        SignJean = false;
    }
}
