﻿/*
* Nicole Lawson
* SpinPropellerX
* Assignment 3
* The plane's propeller spins
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
