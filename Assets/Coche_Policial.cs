using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Coche_Policial : MonoBehaviour
{
    private NavMeshAgent Patrulla;

    public Transform Jugador;

    public Text juegoTerminado;
    public bool elJuegoEstaActivo;


    void Start()
    {
        Patrulla = GetComponent<NavMeshAgent>();
        juegoTerminado.gameObject.SetActive(false);
        elJuegoEstaActivo = true;

    }


    void Update()
    {
        Patrulla.SetDestination(Jugador.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            juegoTerminado.gameObject.SetActive(true);
            elJuegoEstaActivo = false;
            Control_Coche.rb.isKinematic = false;
        }
    }
}
