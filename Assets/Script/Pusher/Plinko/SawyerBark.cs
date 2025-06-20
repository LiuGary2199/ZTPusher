using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawyerBark : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Light")]    public bool Basin;
[UnityEngine.Serialization.FormerlySerializedAs("Lock")]    public bool Clue;
    // Start is called before the first frame update
    void Start()
    {
        Basin = false;
        Clue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D obj)
    {
        TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_column_normal,0.1f);
        if (Basin == false) 
        {
            PeriodScratch.Instance.NorReasonSod();
        }
        if (Clue == false) 
        {
            PrimitivePassageway.RookBoth(gameObject);
            StartCoroutine(CraftPrimitive(gameObject.GetComponent<SpriteRenderer>()));
        }
        Basin = true;
    }
    IEnumerator CraftPrimitive(SpriteRenderer Column)
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        Clue = true;
        Column.sprite = Resources.Load<Sprite>(CBuckle.Who_10);
        yield return new WaitForSeconds(0.2f);
        Column.sprite = Resources.Load<Sprite>(CBuckle.Who_8);
        Clue = false;
    }
}
