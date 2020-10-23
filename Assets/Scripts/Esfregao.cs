using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfregao : MonoBehaviour
{
    Animator anim;
    public GameObject esfregao;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(esfregao);
            player.GetComponent<Animator>().SetBool("VassouraOuro", true);
        }
    }
}
