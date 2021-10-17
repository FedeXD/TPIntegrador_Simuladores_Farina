using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarAtras : MonoBehaviour
{
	public void MirarJugador() //La cámara rota dependiendo a qué dirección vaya el jugador, es decir, si la cámara gira a la izquierda, la cámara rotará a la izquierda
	{
		Vector3 mirarDireccion = 2* Jugador.position - transform.position; //La cámara sigue al jugador y gira cuando el jugador lo hace
		Quaternion rotacion = Quaternion.LookRotation(mirarDireccion, Vector3.up); //Rotación de la cámara
		transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, desplazamientoVelocidad * Time.deltaTime); //Dependiendo la velocidad a la que gire, la cámara girará más o más lento
	}

	public void MoverHaciaJugador() //La cámara siempre sigue al jugador
	{
		Vector3 posicionJugador = Jugador.position + Jugador.forward * offset.z + Jugador.right * offset.x + Jugador.up * offset.y;
		transform.position = Vector3.Lerp(transform.position, posicionJugador, velocidadSeguimiento * Time.deltaTime);
	}

	private void FixedUpdate()
	{
		MirarJugador();
		MoverHaciaJugador();
	}

	public Transform Jugador;
	public Vector3 offset;
	public float velocidadSeguimiento = 10;
	public float desplazamientoVelocidad = 10;
}
