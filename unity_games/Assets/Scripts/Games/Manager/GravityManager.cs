﻿using System.Collections;
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

    private static float vector = 1.0f;

    public static void DebugGravityStatus()
    {
        Debug.Log("PhysicsGrav:" + Physics.gravity);
        Debug.Log("vector:" + vector);
    }

    public static void AddFallSpeed()
    {
        fallSpeed += (forceSpeed * vector);
    }

    public static void ResetFallSpeed()
    {
        fallSpeed = 0.0f;
    }

    public static void AddForceSpeed()
    {
        // @todo. 値は暫定的、自由にコントロール出来るように変えること
        forceSpeed += 0.00001f;
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

    public static void ChangeVector()
    {
        vector *= -1.0f;
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
