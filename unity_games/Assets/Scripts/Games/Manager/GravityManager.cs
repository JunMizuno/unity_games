using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager
{
    private static float fallSpeed;
    public static float FallSpeed
    {
        get
        {
            return fallSpeed;
        }
    }
    private static float forceSpeed;

    public static void DebugGravityStatus()
    {
        Debug.Log("Grav:" + Physics.gravity);
    }

    public static void AddFallSpeed()
    {
        fallSpeed += forceSpeed;
    }

    public static void ResetFallSpeed()
    {
        fallSpeed = 0.0f;
    }

    public static void AddForceSpeed()
    {
        forceSpeed += 0.001f;
    }

    public static void ResetFroceSpeed()
    {
        forceSpeed = 0.0f;
    }

    public static void AddAllSpeed()
    {
        AddForceSpeed();
        AddFallSpeed();
    }

    public static void ResetAllSpeed()
    {
        ResetFallSpeed();
        ResetFroceSpeed();
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
    /// 重力反転し左右にも力を加える
    /// </summary>
    public static void ChangeGravityVectorWithRandomValue()
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
