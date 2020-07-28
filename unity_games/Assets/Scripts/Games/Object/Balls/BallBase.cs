﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallBase : ObjectBase
{
    protected Rigidbody rigid;

    protected override void Start()
    {
        base.Start();

        rigid = GetComponent<Rigidbody>();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    /// <summary>
    /// 接触時のコールバック
    /// isTriggerが有効時のみ
    /// </summary>
    /// <param name="other"></param>
    virtual protected void OnTriggerEnter(Collider other)
    {

    }

    /// <summary>
    /// 衝突時のコールバック
    /// isKinematicが無効時のみ
    /// </summary>
    /// <param name="collision"></param>
    virtual protected void OnCollisionEnter(Collision collision)
    {

    }
}
