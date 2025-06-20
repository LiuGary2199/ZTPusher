using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class PeruGrande : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Employ_Rear;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Grande_Rear;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Rot_User;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Grande_Partly;
    private void Awake()
    {
        if (Rot_User == RunTime.Awake)
        {
            StripeHopper();
        }
    }
    private void Start()
    {
        if (Rot_User == RunTime.Start)
        {
            StripeHopper();
        }
    }

    public void StripeHopper()
    {
        if (Grande_Rear == LayoutType.Sprite_First_Weight)
        {
            if (Employ_Rear == TargetType.UGUI)
            {

                float scale = Screen.width / Grande_Partly;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Grande_Rear == LayoutType.Screen_First_Weight)
        {
            if (Employ_Rear == TargetType.Scene)
            {
                float scale = BuyStatueTine.BuyDuctless().LeoTargetStark() / Grande_Partly;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Grande_Rear == LayoutType.Bottom)
        {
            if (Employ_Rear == TargetType.Scene)
            {
                float screen_bottom_y = BuyStatueTine.BuyDuctless().LeoTargetRename() / -2;
                screen_bottom_y += (Grande_Partly + (BuyStatueTine.BuyDuctless().LeoTranceGift(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
