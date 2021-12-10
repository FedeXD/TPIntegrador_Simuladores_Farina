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
    public Rigidbody Coche;


    void Start()
    {
        Coche.GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(CuentaRegresivaEnumerator());

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
        cuentaRegresivaListo.Play();
        tiempoCarrera.SetActive(true);
        Coche.GetComponent<Rigidbody>().isKinematic = false;

    }

}
