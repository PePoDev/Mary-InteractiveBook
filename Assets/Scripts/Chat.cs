using System.Collections;
using System.Collections.Generic;
using GameFlow;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Chat : MonoBehaviour
{
    public Transform content;
    public GameObject[] stickers;

    public UnityEvent onSend;
    
    public void AddSticker(int id)
    {
        Instantiate(stickers[id],content);
        onSend.Invoke();
    }
}
