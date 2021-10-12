using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallado : MonoBehaviour
{
    public Mesh[] meshes;
    void Start()
    {
        GetComponent<MeshFilter>().mesh = meshes[Random.Range(0, meshes.Length)];
    }

    
}
