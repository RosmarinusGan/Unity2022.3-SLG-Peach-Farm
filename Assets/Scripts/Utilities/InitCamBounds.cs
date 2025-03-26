using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class InitCamBounds : MonoBehaviour
{
    //每次切换场景后都要初始化一下摄像机边界
    public void InitializeCameraBounds()
    {
        PolygonCollider2D boundingShape = GameObject.FindGameObjectWithTag("BoundingShape").GetComponent<PolygonCollider2D>();
        CinemachineConfiner confiner = this.GetComponent<CinemachineConfiner>();
        
        if(boundingShape == null)
        {
            Debug.LogError("Scene is missing a cinema bound!");
            return;
        }
        // Call this if the bounding shape's points change at runtime
        confiner.InvalidatePathCache();
        confiner.m_BoundingShape2D = boundingShape;
    }

    public void Awake()
    {
        InitializeCameraBounds();
    }
}
