using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	// [SerializeField] Slider (component name) slider (name in front of field);

	public void SetHealth(int health)
	{
		slider.value = health;

	}

}