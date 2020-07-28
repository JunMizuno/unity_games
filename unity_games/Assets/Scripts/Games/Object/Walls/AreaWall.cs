using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaWall : WallBase
{
    protected override void Start()
    {
        base.Start();

        ChangeAlpha(0.0f);
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}
