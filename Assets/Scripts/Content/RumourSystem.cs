using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumourSystem : Reciever
{

    public Sprite[] result;

    public SpriteRenderer sr;
    public GameObject textParent;
    public GameObject bottonParent;
    void Start()
    {
        Receive += recieve;
    }
    private void recieve(int value)
    {
        sr.sprite = result[value];
        SetSenders(false);
        Invoke("Reborn", GameSystem.settings.流言CD);
    }
    public void SetSenders(bool active)
    {
        if (active)
        {
            textParent.SetActive(false);
            bottonParent.SetActive(true);
        }
        else
        {
            textParent.SetActive(true);
            bottonParent.SetActive(false);
        }
    }
    private void Reborn()
    {
        SetSenders(true);
    }
}
