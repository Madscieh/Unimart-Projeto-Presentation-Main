﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject playerKey;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            key.SetActive(false);
            playerKey.SetActive(true);
            SoundManager.PlaySound("key");
        }
    }
}