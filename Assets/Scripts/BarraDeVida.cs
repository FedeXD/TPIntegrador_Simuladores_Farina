﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void VidaMaxima(int vida)
	{
		slider.maxValue = vida;
		slider.value = vida;

		fill.color = gradient.Evaluate(1f);
	}

	public void Vida(int vida)
	{
		slider.value = vida;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
}
