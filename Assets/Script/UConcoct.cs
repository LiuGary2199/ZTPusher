using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UConcoct : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("materialId")]    // Scroll main texture based on time
    public int SurpriseIt= 0;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedX")]    public float HandleGuestX= 0.5f;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedY")]    public float HandleGuestY= 0f;
    Renderer Glow;

    void Start()
    {
        Glow = GetComponent<Renderer>();
    }

    void Update()
    {
        //GetComponent<LineRenderer>().materials[0].
        

        float offsetX = Time.time/2 * -HandleGuestX;
        float offsetY = Time.time * HandleGuestY;

        Glow.materials[SurpriseIt].SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));

        //rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }

}
