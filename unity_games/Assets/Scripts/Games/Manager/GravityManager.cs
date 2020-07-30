using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager
{
    public static void DebugGravityStatus()
    {
        Debug.Log("Grav:" + Physics.gravity);
    }

    /// <summary>
    /// 重力反転
    /// </summary>
    public static void ChangeGravityVector()
    {
        var currentGrav = Physics.gravity;

        // @memo. 通常は地球と同じ-9.81fの設定がされている。
        Physics.gravity = new Vector3(-currentGrav.x, -currentGrav.y, -currentGrav.z);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void ChangeGravutyVectorWithRandomValue()
    {
        var currentGrav = Physics.gravity;
        var sign = Random.Range(0, 1);
        if (sign == 0)
        {
            sign = -1;
        }
        currentGrav.x = Random.Range(0.0f, 10.0f) * sign;
        currentGrav.z = Random.Range(0.0f, 10.0f) * sign;

        // @memo. Y軸の重力は固定
        Physics.gravity = new Vector3(currentGrav.x, -currentGrav.y, currentGrav.z);
    }
}
