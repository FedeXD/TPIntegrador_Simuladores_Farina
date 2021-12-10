using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoCarrera : MonoBehaviour
{
    public static int minutos;
    public static int segundos;
    public static float milisegundos;
    public static string milisegundosDisplay;

    public GameObject minutosUI;
    public GameObject segundosUI;
    public GameObject milisegundosUI;

    void Awake()
    {
        minutos = 0;
        segundos = 0;
        milisegundos = 0;
    }
    
    void Update()
    {
        milisegundos += Time.deltaTime * 10;
        milisegundosDisplay = milisegundos.ToString("F0");
        milisegundosUI.GetComponent<Text>().text = "" + milisegundosDisplay;

        if(milisegundos >= 9)
        {
            milisegundos = 0;
            segundos += 1;
        }

        if(segundos <= 9)
        {
            segundosUI.GetComponent<Text>().text = "0" + segundos + ".";
        } 
        else
        {
            segundosUI.GetComponent<Text>().text = "" + segundos + ".";
        }

        if(segundos >= 60)
        {
            segundos = 0;
            segundos += 1;
            minutos += 1;
        }

        if(minutos <= 9)
        {
            minutosUI.GetComponent<Text>().text = "0" + minutos + ":";
        }
        else
        {
            minutosUI.GetComponent<Text>().text = "" + minutos + ":";
        }


    }
    
}
