using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnearCoche : MonoBehaviour
{
    public GameObject[] prefabCoches;
    void Start()
    {
        Instantiate(ElegirPrefabAuto(), transform);
    }

    private GameObject ElegirPrefabAuto()
    {
        var indexRandom = Random.Range(0, prefabCoches.Length);
        return prefabCoches[indexRandom];
    }
}
