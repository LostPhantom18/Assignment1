using HappyHarvest;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortableShop : MonoBehaviour
{
    private AudioClip Cow_Bell;

    private AudioSource AudioSource;


    public void OnClick()
    {
        UIHandler.OpenMarket();
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip = Cow_Bell;
        AudioSource.Play();
    }
}
