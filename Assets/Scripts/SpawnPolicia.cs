using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPolicia : MonoBehaviour
{
    public GameObject patrulla;
    void Start()
    {
        Instantiate(patrulla,transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
