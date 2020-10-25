using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore : MonoBehaviour
{
    public Sprite ArvoreSemGalho;
    public GameObject playerOculos;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ArvoreSemGalho;
            playerOculos.SetActive(true);
            SoundManager.PlaySound("Oculos");
        }
    }
}
