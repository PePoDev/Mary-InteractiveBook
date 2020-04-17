using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class p19_1 : MonoBehaviour
{
    public GameObject button;
    public RectTransform door;
    
    private int m_count = 0;

    public void CleanOne()
    {
        m_count++;
        if (m_count >= 4)
        {
            door.DOAnchorPosX(0, 1.5f);
            StartCoroutine(func());
        }

        IEnumerator func()
        {
            yield return new WaitForSeconds(2f);
            button.SetActive(true);            
        }
    }

}
