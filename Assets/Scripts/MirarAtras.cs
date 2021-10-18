using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarAtras : MonoBehaviour
{
    public Transform Auto;

    float rotaciónX, rotaciónY, rotaciónZ;
    void Start()
    {

    }


    void Update()
    {
        rotaciónX = Auto.eulerAngles.x;
        rotaciónY = Auto.eulerAngles.y;
        rotaciónZ = Auto.eulerAngles.z;

        transform.eulerAngles = new Vector3(rotaciónX - rotaciónX, rotaciónY, rotaciónZ - rotaciónZ);
    }
}
