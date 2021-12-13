using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAuto : MonoBehaviour
{
    public GameObject AutoAmarillo;
    public GameObject AutoAzul;
    public GameObject AutoRojo;
    public GameObject AutoVerde;
    public int ImportarAuto;
    void Start()
    {
        ImportarAuto = SeleccionarAuto.TipoAuto;
        if (ImportarAuto == 1)
        {
            AutoAmarillo.SetActive(true);
        }
        if (ImportarAuto == 2)
        {
            AutoAzul.SetActive(true);
        }
        if (ImportarAuto == 3)
        {
            AutoRojo.SetActive(true);
        }
        if (ImportarAuto == 4)
        {
            AutoVerde.SetActive(true);
        }
    }
}
