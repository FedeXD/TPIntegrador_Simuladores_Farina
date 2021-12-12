using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaRegresiva : MonoBehaviour
{
    public GameObject cuentaRegresiva;
    public AudioSource contandoHaciaAtras;
    public AudioSource cuentaRegresivaListo;
    public GameObject tiempoCarrera;
    public GameObject oponente;
    public Rigidbody Coche;
    

    void Start()
    {
        StartCoroutine(CuentaRegresivaEnumerator());     
        Coche.GetComponent<Rigidbody>().isKinematic = true;
        oponente.GetComponent<Auto_Waypoint>().enabled = false;
    }

    IEnumerator CuentaRegresivaEnumerator()
    {
        tiempoCarrera.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        cuentaRegresiva.GetComponent<Text>().text = "3";
        contandoHaciaAtras.Play();
        cuentaRegresiva.SetActive(true);
        yield return new WaitForSeconds(1);
        cuentaRegresiva.SetActive(false);
        cuentaRegresiva.GetComponent<Text>().text = "2";
        contandoHaciaAtras.Play();
        cuentaRegresiva.SetActive(true);
        yield return new WaitForSeconds(1);
        cuentaRegresiva.SetActive(false);
        cuentaRegresiva.GetComponent<Text>().text = "1";
        contandoHaciaAtras.Play();
        cuentaRegresiva.SetActive(true);
        yield return new WaitForSeconds(1);
        cuentaRegresiva.SetActive(false);
        cuentaRegresiva.GetComponent<Text>().text = "YA";
        cuentaRegresivaListo.Play();
        cuentaRegresiva.SetActive(true);
        tiempoCarrera.SetActive(true);
        Coche.GetComponent<Rigidbody>().isKinematic = false;
        oponente.GetComponent<Auto_Waypoint>().enabled = true;
    }

}
