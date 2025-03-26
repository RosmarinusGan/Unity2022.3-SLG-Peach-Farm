using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Hyalinize : MonoBehaviour
{
    public float targetAlpha = Global.Alpha, duration = Global.Duration;
    private SpriteRenderer sr;
    private Color originColor;
    
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        originColor = sr.color;
    }
    
    public void HyalinizeObject()
    {
        var targetColor = new Color(originColor.r, originColor.g, originColor.b, targetAlpha);
        sr.DOColor(targetColor, duration);
    }
    
    public void UndoHyalinize()
    {
        sr.DOColor(originColor, duration);
    }
}
