using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public GameObject texturaCamara;
    public GameObject camara;

    bool marchaAtras;

    void Start()
    {
        camara.SetActive(false);
        texturaCamara.SetActive(false);
        marchaAtras = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (marchaAtras == false)
            {
                camara.SetActive(true);
                texturaCamara.SetActive(true);
                marchaAtras = true;
            }
            else
            {
                camara.SetActive(false);
                texturaCamara.SetActive(false);
                marchaAtras = false;
            }

        }
    }
}
