﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAt : MonoBehaviour
{
    static public GameObject target;

    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
       
    }
}
