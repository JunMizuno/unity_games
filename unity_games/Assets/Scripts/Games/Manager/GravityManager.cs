using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager
{
    /// <summary>
    /// 重力反転
    /// </summary>
    public static void ChangeGravityVector()
    {
        var currentGrav = Physics.gravity;

        // @memo. 通常は地球と同じ-9.81fの設定がされている。
        Physics.gravity = new Vector3(currentGrav.x, -currentGrav.y, currentGrav.z);
    }
}
