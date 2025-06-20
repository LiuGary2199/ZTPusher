using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailMyPress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Japan;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Weft1Trance;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Weft2Trance;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Japan)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Panel= indexStr == "" ? 0 : int.Parse(indexStr);
                TherePlain(Panel);
            });
        }
        
    }

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        for (int i = 0; i < 5; i++)
        {
            Japan[i].gameObject.GetComponent<Image>().sprite = Weft2Trance;
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }


    private void TherePlain(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Japan[i].gameObject.GetComponent<Image>().sprite = i <= index ? Weft1Trance : Weft2Trance;
        }
        if (index < 3)
        {
            StartCoroutine(GuardPress());
        } else
        {
            // 跳转到应用商店
            MailMyScratch.instance.GibeAPOatTurkey();
            StartCoroutine(GuardPress());
        }
        
        // 打点
        CardHonorDecode.BuyDuctless().SaltHonor("1016", (index + 1).ToString());
    }

    IEnumerator GuardPress(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        HuntScratch.Instance.DramWitness();
        ShaftUIWish(GetType().Name);
    }
}
