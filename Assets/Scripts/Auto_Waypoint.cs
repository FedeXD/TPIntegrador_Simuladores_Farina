using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Waypoint : MonoBehaviour
{
    public float velocidad;

    public Transform objetivo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "waypoint")
        {
            objetivo = collider.gameObject.GetComponent<Waypoints>().waypointProximo;
            transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
            
        }
    }
}
