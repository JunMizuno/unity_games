using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : ObjectBase
{
    protected override void Update()
    {
        base.Update();

        MoveBar();
    }

    /// <summary>
    /// @todo. 暫定的にキーで移動できる様に設定
    /// </summary>
    private void MoveBar()
    {
        var position = this.gameObject.transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.z += 0.05f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.z -= 0.05f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += 0.05f;
        }

        this.gameObject.transform.position = position;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
