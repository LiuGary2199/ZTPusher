using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibeIfShaftCry : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Newrove")]    public GameObject Plateau;
[UnityEngine.Serialization.FormerlySerializedAs("Oldtop")]
    public GameObject Reveal;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction")]    public GameObject Tune_Seriousness;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_1")]    public GameObject Tune_Seriousness_1;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_2")]    public GameObject Tune_Seriousness_2;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Bottom_1")]    public GameObject Tune_Beggar_1;
[UnityEngine.Serialization.FormerlySerializedAs("SlotTop")]    public GameObject TuneCar;
[UnityEngine.Serialization.FormerlySerializedAs("Plane")]    public GameObject Apace;
[UnityEngine.Serialization.FormerlySerializedAs("Image")]    public GameObject Paris;
[UnityEngine.Serialization.FormerlySerializedAs("Arrow")]    public GameObject Badly;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher")]    public MeshRenderer Period;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher_mat")]    public Material Period_Sex;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom")]    public MeshRenderer Beggar;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom_mat")]    public Material Beggar_Sex;
[UnityEngine.Serialization.FormerlySerializedAs("Hold")]    public MeshRenderer Size;
[UnityEngine.Serialization.FormerlySerializedAs("Hold_mat")]   // public MeshRenderer Hold_1;
    public Material Size_Sex;
   // public Material Hold_1_mat;

    public void ShineCryIngot() 
    {
        if (VacantSkin.AtTract())
        {
            Plateau.SetActive(true);
            Reveal.SetActive(false);
            Tune_Seriousness.SetActive(false);
            Tune_Seriousness_1.SetActive(false);
            Tune_Seriousness_2.SetActive(false);
            TuneCar.SetActive(false);
            Apace.SetActive(false);
            Paris.SetActive(false);
            Tune_Beggar_1.SetActive(false);
            Badly.SetActive(false);
            Period.material = Period_Sex;
            Beggar.material = Beggar_Sex;
            Size.material = Size_Sex;
        }
        else
        {
            Plateau.SetActive(false);
            Reveal.SetActive(true);
            Tune_Seriousness.SetActive(true);
            Tune_Seriousness_1.SetActive(true);
            Tune_Seriousness_2.SetActive(true);
            TuneCar.SetActive(true);
            Apace.SetActive(true);
            Paris.SetActive(true);
            Tune_Beggar_1.SetActive(true);
            Badly.SetActive(true);
        }
    }
}
