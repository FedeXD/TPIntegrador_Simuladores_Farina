using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Sonido_Auto : MonoBehaviour
{
    
    AudioSource audioSource;
    public float pitchDefault;
    private float pitchAuto;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = pitchDefault;
    }

    
    void Update()
    {
        pitchAuto = Control_Coche.controlCoche.velocidadCoche;
        if (pitchAuto < pitchDefault)
        {
            audioSource.pitch = pitchDefault;
        }
        else
        {
            audioSource.pitch = pitchAuto;
        }
        
    }

}
