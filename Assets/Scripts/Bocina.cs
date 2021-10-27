using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bocina : MonoBehaviour
{

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    public void PulsarBocina()
    {
        audioSource.Play();
    }

    public void DetenerBocina()
    {
        audioSource.Stop();
    }
}
