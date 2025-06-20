using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExamParisPrimitive : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    public List<Sprite> AcornRent;
    private Image Acorn;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    public float Embed;
    IEnumerator HairHopper()
    {
        foreach(Sprite sprite in AcornRent)
        {
            Acorn.sprite = sprite;
            yield return new WaitForSeconds(Embed);
        }
    }
    private void OnEnable()
    {
        Acorn = GetComponent<Image>();
        StartCoroutine(nameof(HairHopper));
    }
    // private void OnDisable()
    // {
    //     StopCoroutine("playAction");
    // }
}
