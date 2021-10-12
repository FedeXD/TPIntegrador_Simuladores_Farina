using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Eje
{
    public WheelCollider ruedaIzquierda; 
    public WheelCollider ruedaDerecha;
    public bool motor; 
    public bool direccion; 
}

public class Control_Coche : MonoBehaviour
{
    public List<Eje> eje;
    public float potenciaMotor; 
    public float anguloDireccionMaximo; //el angulo de direccion maximo que la rueda puede tener para moverse de izquierda a derecha


    public static Control_Coche controlCoche;
    public float velocidadMaxima = 100;
    public float velocidadCoche;
    Rigidbody rb;
    
    public void Start()
    {
        controlCoche = this;
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        float motor = potenciaMotor * Input.GetAxis("Vertical");
        float direccion = anguloDireccionMaximo * Input.GetAxis("Horizontal");

        foreach (Eje eje in eje)
        {
            if (eje.direccion)
            {
                eje.ruedaIzquierda.steerAngle = direccion;
                eje.ruedaDerecha.steerAngle = direccion;
            }
            if (eje.motor)
            {
                eje.ruedaIzquierda.motorTorque = motor;
                eje.ruedaDerecha.motorTorque = motor;

                velocidadCoche = (rb.velocity.magnitude * 3.6f) / velocidadMaxima;
            }
        }

        if(motor == potenciaMotor)
        {
            Combustible.cmstible.movimientoCoche(true);
        }
        else
        {
            Combustible.cmstible.movimientoCoche(false);
        }
    }
}



