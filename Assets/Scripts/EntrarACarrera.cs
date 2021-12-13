using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EntrarACarrera : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EntrarCarrera"))
        {
            SceneManager.LoadScene(2);
            
        }
    }
}
