using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStart : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        // if (Input.anyKeyDown || Input.touchCount > 0)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
