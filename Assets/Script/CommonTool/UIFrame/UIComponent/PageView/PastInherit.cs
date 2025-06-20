using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PastInherit : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Zone;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public ZincLobe Simplistic;
    private void Awake()
    {
        Simplistic.NoZincMutual = Sanitation;
    }

    void Sanitation(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Zone.GetComponent<RectTransform>().position = pos;
    }
}
