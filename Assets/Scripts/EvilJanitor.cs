using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EvilJanitor : MonoBehaviour
{
    public Animator anim;

    public int saudeMax = 2100;
    int saudeAtual;
    public GameObject oLente, oAlca, oculos, player;


    // Start is called before the first frame update
    void Start()
    {
        saudeAtual = saudeMax;
    }

    public void LevaDano(int dano)
    {
        saudeAtual -= dano;
        SoundManager.PlaySound("AcerteiAlgo");

        // anim.SetTrigger("Ferido");

        if (saudeAtual <= 0)
            Desmaio();
    }

    void Desmaio()
    {
        anim.SetBool("Desmaio", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        player.GetComponent<Animator>().SetBool("Glasses", true);

        WinGame();
    }

    void WinGame()
    {
        Destroy(gameObject, 0.75f);
        oAlca.SetActive(false);
        oLente.SetActive(false);
        oculos.SetActive(true);
        SoundManager.PlaySound("Oculos");
        //SceneManager.LoadScene("WinCondition");
    }
}
