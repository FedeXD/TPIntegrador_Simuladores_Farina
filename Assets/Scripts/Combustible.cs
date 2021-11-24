using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combustible : MonoBehaviour
{
    public float combustible = 150f;
    public Text combustibleT;
    private bool cocheAcelera;
    private float combustibleDecrece = 2f;
    public float intervalo = 1;
    public AudioClip combustibleRecargado;
    public Text naftaRecargada;
    private float aparecerTexto = 2f;
    private float desaparecerTexto;

    public static Combustible cmstible;
    void Start()
    {
        naftaRecargada.enabled = false;
        cmstible = this;
        combustibleDecrece = intervalo;
    }
    
    void Update()
    {
        if (cocheAcelera)
        {
            if(combustibleDecrece > 0)
            {
                combustibleDecrece -= Time.deltaTime;
            }
            else
            {
                combustibleDecrece = intervalo;
                combustible -= 1f;
            }

        }
        combustibleT.text = "Combustible: " + combustible;
    }

    public void movimientoCoche(bool seMueve)
    {
        cocheAcelera = seMueve;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Gasolinera")
        {
            combustible = 150f;
            AudioSource.PlayClipAtPoint(combustibleRecargado, transform.position);
            naftaRecargada.enabled = true;
            desaparecerTexto = Time.time + aparecerTexto;
            if (naftaRecargada.enabled && (Time.time >= desaparecerTexto))
            {
                naftaRecargada.enabled = false;

            }
            Destroy(collider.gameObject);
        }
    }
}
