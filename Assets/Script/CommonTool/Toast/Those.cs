using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Those : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text ThoseAfar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        ThoseAfar.text = ThoseScratch.BuyDuctless().Head;
        StartCoroutine(nameof(RimeShaftThose));
    }

    private IEnumerator RimeShaftThose()
    {
        yield return new WaitForSeconds(2);
        ShaftUIWish(GetType().Name);
    }

}
