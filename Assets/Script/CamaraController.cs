﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    private Transform _transform;
    public GameObject tarjet;
    private float x, y, z;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        x = tarjet.transform.position.x;
        y = _transform.position.y;
        z = _transform.position.z;
        _transform.position = new Vector3(x + 4, y, z); // estaba en 15
    }
}
