using HappyHarvest;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortableShop : MonoBehaviour
{
    public AudioClip Cow_Bell;

    public AudioSource AudioSource;

    public void OnClick()
    {
        UIHandler.OpenMarket();
        
        AudioSource.clip = Cow_Bell;
        AudioSource.Play();
    }
}
