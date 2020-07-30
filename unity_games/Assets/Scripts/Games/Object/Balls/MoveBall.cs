using System.Collections;
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

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        // @todo. AddForceかVelocityかどちらか、Gravityは上下のみ扱う方が良さそう
        //rigid.AddForce(500.0f, 0.0f, 500.0f);

        GravityManager.ChangeGravityVector();

        //GravityManager.ChangeGravutyVectorWithRandomValue();

        GravityManager.DebugGravityStatus();
        DebugRigidStatus();
    }
}
