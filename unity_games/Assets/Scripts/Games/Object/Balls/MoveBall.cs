﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : BallBase
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        Debug.Log("HIT");
    }
}
