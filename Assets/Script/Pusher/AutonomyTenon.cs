using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutonomyTenon : MonoBehaviour
{
    System.Action AmpleHopper;
    bool GoMoral= true;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��ײ");
        if (GoMoral)
        {
            GoMoral = false;
            AmpleHopper();
            Destroy(this);
        }
    }

    public void FenTenonHopper(System.Action block)
    {
        AmpleHopper = block;
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
