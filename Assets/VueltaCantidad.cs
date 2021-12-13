using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VueltaCantidad : MonoBehaviour
{
    public GameObject contadorVueltas;
    public int vueltasHechas;
    public BoxCollider colliderVuelta;
    public Rigidbody Coche;

    void Start()
    {
        colliderVuelta.GetComponent<BoxCollider>().enabled = true;
    }

    void Update()
    {
        if(vueltasHechas == 4)
        {
            Coche.GetComponent<Rigidbody>().isKinematic = true;
            colliderVuelta.GetComponent<BoxCollider>().enabled = false;
            SceneManager.LoadScene(4);
        }
    }

    IEnumerator OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "VueltaCompleta")
        {
            vueltasHechas += 1;
            colliderVuelta.GetComponent<BoxCollider>().enabled = false;
            yield return new WaitForSeconds(1f);
            colliderVuelta.GetComponent<BoxCollider>().enabled = true;
            contadorVueltas.GetComponent<Text>().text = "" + vueltasHechas;
        }
    }
}
