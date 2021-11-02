using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Control_AutoTrafico : MonoBehaviour
{
    public GameObject[] prefabAuto;

    Rigidbody rb;

    public float velocidad;
    public float rotacion;
    public float velocidadMaxima;

    public Vector3 movimiento;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Movimiento(Vector3 movimientoInput)
    {
        this.movimiento = movimientoInput;
    }

    private void FixedUpdate()
    {
        if(rb.velocity.magnitude < velocidadMaxima)
        {
            rb.AddForce(movimiento.z * transform.forward * velocidad);
        }
        rb.AddTorque(movimiento.x * Vector3.forward * rotacion * movimiento.z);
    }
}
