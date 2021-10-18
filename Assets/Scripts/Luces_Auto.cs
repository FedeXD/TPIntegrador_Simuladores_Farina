using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces_Auto : MonoBehaviour
{
    public Renderer luzTraseraIzq;
    public Renderer luzTraseraDer;
    public Renderer luzFrontalIzq;
    public Renderer luzFrontalDer;
    public Material lucesTraserasON;
    public Material lucesTraserasOFF;
    public Material lucesFrontalesON;
    public Material lucesFrontalesOFF;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            luzTraseraIzq.material = lucesTraserasON;
            luzTraseraDer.material = lucesTraserasON;
        }
        else
        {
            luzTraseraIzq.material = lucesTraserasOFF;
            luzTraseraDer.material = lucesTraserasOFF;
        }

        if (Input.GetKeyDown("1"))
        {
            luzFrontalIzq.material = lucesFrontalesON;
            luzFrontalDer.material = lucesFrontalesON;
        }
        if (Input.GetKeyDown("2"))
        {
            luzFrontalIzq.material = lucesFrontalesOFF;
            luzFrontalDer.material = lucesFrontalesOFF;
        }
        
    }


}
