using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarAuto : MonoBehaviour
{
    public static int TipoAuto;
    public GameObject ImagenAuto;
    public void AutoAmarillo()
    {
        TipoAuto = 1;
        ImagenAuto.SetActive(true);
    }

    public void AutoAzul()
    {
        TipoAuto = 2;
        ImagenAuto.SetActive(true);
    }

    public void AutoRojo()
    {
        TipoAuto = 3;
        ImagenAuto.SetActive(true);
    }

    public void AutoVerde()
    {
        TipoAuto = 4;
        ImagenAuto.SetActive(true);
    }

}
