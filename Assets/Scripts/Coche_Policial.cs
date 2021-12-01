using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Coche_Policial : MonoBehaviour
{
    private NavMeshAgent Patrulla;

    public Transform Jugador;

    void Start()
    {
        Patrulla = GetComponent<NavMeshAgent>();


    }


    void Update()
    {
        Patrulla.SetDestination(Jugador.position);
    }

    
}
