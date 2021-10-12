using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRetrovisor : MonoBehaviour
{
    public GameObject texturaRetrovisor;
    public GameObject retrovisor;

    bool marchaAtras;

    void Start()
    {
        retrovisor.SetActive(false);
        texturaRetrovisor.SetActive(false);
        marchaAtras = false;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (marchaAtras == false)
            {
                retrovisor.SetActive(true);
                texturaRetrovisor.SetActive(true);
                marchaAtras = true;
            }
            else
            {
                retrovisor.SetActive(false);
                texturaRetrovisor.SetActive(false);
                marchaAtras = false;
            }
            
        }
    }
}
