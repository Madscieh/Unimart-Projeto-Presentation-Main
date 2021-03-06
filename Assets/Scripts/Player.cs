﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator anim;

    public int saudeMax = 2000;
    int saudeAtual;

    // Start is called before the first frame update
    void Start()
    {
        saudeAtual = saudeMax;
    }

    public void LevaDano(int dano)
    {
        saudeAtual -= dano;
        SoundManager.PlaySound("AcerteiAlgo");

        if (saudeAtual <= 0)
        {
            SceneManager.LoadScene("MainMenu");
            Desmaio();
        }
    }

    void Desmaio()
    {
        anim.SetBool("Perdeu", true);
        SceneManager.LoadScene("MainMenu");
    }
}
