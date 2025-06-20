using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpsideCooper : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("block")]
    public System.Action Ample;
    private void OnTriggerEnter(Collider other)
    {
        Ample();
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
