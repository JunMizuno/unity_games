using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class WallBase : ObjectBase
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

    protected void ChangeAlpha(float alphaValue)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        var currentColor = meshRenderer.material.color;
        Debug.Log("currentColor:" + currentColor + "  alphaValue:" + alphaValue);
        meshRenderer.material.color = new Color(currentColor.r, currentColor.g, currentColor.b, alphaValue);
    }
}
