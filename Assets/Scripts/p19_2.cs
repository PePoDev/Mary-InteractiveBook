using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class p19_2 : MonoBehaviour
{
    public RectTransform box;
    
    private void Start()
    {
        box.DOAnchorPosX(0, 1.5f);
    }
}
