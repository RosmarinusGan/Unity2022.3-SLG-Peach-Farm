using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 触发后只会激活目标碰撞体的子物体下挂接的Hyalinize组件
/// </summary>
public class TriggerHyalinize : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var hyalinizeItems = other.GetComponentsInChildren<Hyalinize>();
        foreach (var item in hyalinizeItems)
        {
            item.HyalinizeObject();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var hyalinizeItems = other.GetComponentsInChildren<Hyalinize>();
        foreach (var item in hyalinizeItems)
        {
            item.UndoHyalinize();
        }
    }
}
