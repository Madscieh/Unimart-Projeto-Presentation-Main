using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCombat : MonoBehaviour
{
    public Animator anim;

    public Transform arma;
    public Transform monster;
    public LayerMask Player;

    public float alcance = 1f;
    public int dano = 40;

    public float cadenciaDeAtaque = 2f;
    float tempoProximoAtaque = 0f;
    float horizontal;
    float vertical;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)
            if (horizontal != 0)
                arma.position = new Vector3(horizontal / 2, 0, 0) + monster.position;
            else
                arma.position = new Vector3(0, vertical, 0) + monster.position;

        if (Time.time >= tempoProximoAtaque)
        {
            Attack();
            //AttackBox();
            tempoProximoAtaque = Time.time + 1f / cadenciaDeAtaque;
        }
    }
    void Attack()
    {
        anim.SetTrigger("Ataque");
        Collider2D[] acerto = Physics2D.OverlapCircleAll(arma.position, alcance, Player);
        for (int indice = acerto.Length - 1; indice >= 0; indice--)
        {
            //Se vc tivesse feito uma classe com um detroy abstrato, não precisava
            //ficar checando para ver se tem o componente...
            if (acerto[indice].GetComponent<Player>() != null)
                acerto[indice].GetComponent<Player>().LevaDano(dano);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (arma == null)
            return;
        Gizmos.DrawWireSphere(arma.position, alcance);
    }
}