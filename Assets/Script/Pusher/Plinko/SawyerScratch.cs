﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawyerScratch : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("columnPerfab")]    public GameObject GalaxyEither;
[UnityEngine.Serialization.FormerlySerializedAs("columnList")]    public List<SpriteRenderer> GalaxyRent;
    // Start is called before the first frame update
    void Start()
    {
        float x_space = 0.5f;
        float y_space = 0.45f;
        float scale = 0.52f;
        float y_bottom = 3.5f;
        int[] xcount = new int[] { 7, 6, 7, 6};
        for (int y= 0; y < 4; y++)
        {
            for (int x= 0; x < xcount[y]; x++)
            {
                GameObject columnItem = Instantiate(GalaxyEither);
                columnItem.transform.parent = transform;
                columnItem.transform.localScale = new Vector3(scale, scale, scale);
                float px = -((xcount[y] - 1) * x_space) / 2 + x * x_space;
                float py = y_bottom + y_space * y;
                columnItem.transform.position = new Vector3(px, py, 0f);
                GalaxyRent.Add(columnItem.GetComponent<SpriteRenderer>());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
