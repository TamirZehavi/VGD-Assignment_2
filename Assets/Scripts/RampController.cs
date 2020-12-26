using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RampController : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 rampPosition = new Vector2(transform.position.x, transform.position.y);
        rampPosition.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = rampPosition;
    }

    private float GetXPos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
    }
}

