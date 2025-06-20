using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionBulge : MonoBehaviour
{
    Vector3 Landmark;

    /// <summary>
    /// ��ͣ������
    /// </summary>
    public void DrainRigidbody()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            Landmark = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            Landmark = GetComponent<Rigidbody2D>().velocity;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    public void AlwaysInfection()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().velocity = Landmark;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().velocity = Landmark;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
