using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text juegoTerminado;
    public bool elJuegoEstaActivo;
    void Start()
    {
        juegoTerminado.gameObject.SetActive(false);
        elJuegoEstaActivo = true;
    }

    public void JuegoTerminado()
    {
        juegoTerminado.gameObject.SetActive(true);
        elJuegoEstaActivo = false;
    }

    
}
