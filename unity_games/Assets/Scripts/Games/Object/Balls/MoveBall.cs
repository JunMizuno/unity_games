using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : BallBase
{
    protected override void Start()
    {
        base.Start();

        EnableUseGravity(false);
    }

    protected override void Update()
    {
        base.Update();
        GravityManager.AddAllSpeed();

        rigid.AddForce(0.0f, -GravityManager.FallSpeed, 0.0f);
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        GravityManager.ResetAllSpeed();

        GravityManager.DebugGravityStatus();
        DebugRigidStatus();
    }
}
