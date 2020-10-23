using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oculos : MonoBehaviour
{
    public GameObject oculos;
    public GameObject playerOculos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            oculos.SetActive(false);
            playerOculos.SetActive(true);
            SoundManager.PlaySound("Oculos");
        }
    }
}
