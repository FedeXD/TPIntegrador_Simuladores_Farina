using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public float dinero = 1500f;
    public Text dineroTexto;

    void Update()
    {
        dineroTexto.text = " " + dinero;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            dinero -= 100f;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "ItemVida")
        {
            dinero -= 100f;
            
        }
    }
}
