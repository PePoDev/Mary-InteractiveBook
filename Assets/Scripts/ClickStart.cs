using System;
using System.Collections;
using System.Collections.Generic;
using GameFlow;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStart : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }
}
