﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float capsule = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void capsuleCollected()
    {
        capsule += 1;
    }
}
