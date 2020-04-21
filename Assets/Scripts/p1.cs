using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class p1 : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject button;
    
    private void Update()
    {
        if (vp.isPrepared)
        {
            button.SetActive(true);
            Destroy(this);
        }
    }
}
