using System.Collections;
using System.Collections.Generic;
using EModules.EModulesInternal;
using UnityEngine;
using UnityEngine.UI;

public class p21 : MonoBehaviour
{
    public Image image;
    public Sprite[] images;
    public GameObject buttonNext;
    
    private int m_index = 0;
    private int m_count = 0;
    
    public void Slide(int i)
    {
        m_count++;
        if (m_count > 3)
        {
            buttonNext.SetActive(true);
        }

        m_index += i;
        if (m_index < 0) m_index = 0;
        else if (m_index >= images.Length) m_index = images.Length - 1;

        image.overrideSprite = images[m_index];
    }
}
