using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamaras : MonoBehaviour
{
    public Camera[] Camaras; //Array para indicar la cantidad de cámaras que se utilizarán
    public int camaraIndex = 0; //Valor numérico de la cámara a la cual queremos acceder

    void Start()
    {
        Camaras [camaraIndex].gameObject.SetActive(true); 
        for (camaraIndex += 1; camaraIndex < Camaras.Length; camaraIndex++) 
        {
            Camaras[camaraIndex].gameObject.SetActive(false); 
        }
        camaraIndex = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))  //Botón derecho del mouse para cambiar de personaje
        {
            camaraIndex++;
            if (camaraIndex == Camaras.Length)
            {
                camaraIndex = 0;
                Camaras[Camaras.Length - 1].gameObject.SetActive(false); //Esto indica que si el Index es igual a la Length, se volverá al primer valor numérico haciendo un loop
            }
            Camaras[camaraIndex].gameObject.SetActive(true);
            if (camaraIndex != 0)
            {
                Camaras[camaraIndex - 1].gameObject.SetActive(false);
            }
        }
    }
}
