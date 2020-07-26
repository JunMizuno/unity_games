using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BlockBase : ObjectBase
{
    protected Rigidbody rigid;

    protected  override void Start()
    {
        base.Start();

        rigid = GetComponent<Rigidbody>();
    }

    protected override void Update()
    {
        base.Update();
    }
}
