using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarVida : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vida;

    public BarraDeVida barraDeVida;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "ItemVida")
        {
            vida = vidaMaxima;
            barraDeVida.VidaMaxima(vidaMaxima);
            Destroy(collider.gameObject);
        }
    }

    void RecibirDaño(int damage)
    {
        vida -= damage;

        barraDeVida.Vida(vida);
    }


}
