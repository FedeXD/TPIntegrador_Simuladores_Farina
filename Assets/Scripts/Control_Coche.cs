using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public static Rigidbody rb;
    public int vidaMaxima = 100;
    public int vida;

    public BarraDeVida barraDeVida;
    
    public void Start()
    {
        controlCoche = this;
        rb = GetComponent<Rigidbody>();
        vida = vidaMaxima;
        barraDeVida.VidaMaxima(vidaMaxima);

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

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            RecibirDaño(5);

        }
        

    }

    public void RecibirDaño(int daño)
    {
        vida -= daño;
        barraDeVida.Vida(vida);
    }


}



