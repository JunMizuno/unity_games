using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : BallBase
{
    protected override void Start()
    {
        base.Start();

        EnableUseGravity(false);

        // @todo. 初回の前後左右の移動量をランダムで設定
        AddForceAtStart();
    }

    protected override void Update()
    {
        base.Update();
        GravityManager.AddAllSpeed();

        AddForceAtUpdate();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        GravityManager.ResetAllSpeed();
        GravityManager.ChangeVector();

        //GravityManager.DebugGravityStatus();
        //DebugRigidStatus();
    }

    private void AddForceAtStart()
    {
        GravityManager.AddAllSpeed();

        float vec = 1.0f;
        float forceX = 0.0f;
        float forceZ = 0.0f;

        // @todo. 後でUtilityなどに集約
        if (Random.Range(0, 1) == 0)
        {
            vec *= -1.0f;
        }

        forceX = Random.Range(0.0f, 1.0f) * vec;

        if (Random.Range(0, 1) == 0)
        {
            vec *= -1.0f;
        }

        forceZ = Random.Range(0.0f, 1.0f) * vec;

        rigid.AddForce(GravityManager.FallSpeed * forceX, -GravityManager.FallSpeed, GravityManager.FallSpeed * forceZ);
    }

    private void AddForceAtUpdate()
    {
        // @todo. バーとの衝突時にバーの移動ベクトルを反映させないといけない

        // @memo. velocityに応じてXとZにもForceを加算する
        float forceX = 1.0f;
        float forceZ = 1.0f;

        if (rigid.velocity.x < 0.0f)
        {
            forceX *= -1.0f;
        }

        if (rigid.velocity.z < 0.0f)
        {
            forceZ *= -1.0f;
        }

        rigid.AddForce(GravityManager.FallSpeed * forceX, -GravityManager.FallSpeed, GravityManager.FallSpeed * forceZ);
    }
}
