using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(3);
    }

    public void EmpezarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void Volver()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Reintentar()
    {
        SceneManager.LoadScene(3);
    }
}



