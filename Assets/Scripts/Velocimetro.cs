using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Velocimetro : MonoBehaviour
{
    public Rigidbody coche;

    public float velocidadMaxima = 0.0f; 

    public float anguloMinimoFlecha;
    public float anguloMaximoFlecha;

    [Header("UI")]
    public Text velocimetro; 
    public RectTransform flecha; 

    private float velocidad = 0.0f;
    private void Update()
    {
        velocidad = coche.velocity.magnitude * 3.6f;

        if (velocimetro != null)
            velocimetro.text = ((int)velocidad) + " km/h";
        if (flecha != null)
            flecha.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(anguloMinimoFlecha, anguloMaximoFlecha, velocidad / velocidadMaxima));
    }
}
