using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesDeGiro : MonoBehaviour
{
    public Renderer luzGiroIzq;
    public Renderer luzGiroDer;
    public Material luzGiroIzqON;
    public Material luzGiroIzqOFF;
    public Material luzGiroDerON;
    public Material luzGiroDerOFF;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LuzGiroIzquierda()
    {
        luzGiroIzq.material = luzGiroIzqON;
        luzGiroDer.material = luzGiroDerOFF;
    }

    public void LuzGiroDerecha()
    {
        luzGiroIzq.material = luzGiroIzqOFF;
        luzGiroDer.material = luzGiroDerON;
    }

    public void Intermitente()
    {
        luzGiroIzq.material = luzGiroIzqON;
        luzGiroDer.material = luzGiroDerON;
    }
}
