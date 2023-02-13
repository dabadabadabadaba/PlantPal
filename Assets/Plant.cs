using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{

	public int currentHealth;
	public HealthBar healthBar;

    void Start()
    {
		currentHealth = 0;
		healthBar.SetHealth(currentHealth);
    }

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Water") 
		{
			AddHealth(5);
		}

		if (other.tag == "Sunlight")
		{
			Debug.Log("Sun for plant");
			AddHealth(2);
		}

		if (other.tag == "BaseballCap")
		{
			Debug.Log("BaseballCap for plant");
			AddHealth(5);
		}

		if (other.tag == "BowTie")
		{
			Debug.Log("BowTie for plant");
			AddHealth(3);
		}

		if (other.tag == "SunHat")
		{
			Debug.Log("SunHat for plant");
			AddHealth(4);
		}

		if (other.tag == "SantaHat")
		{
			Debug.Log("SantaHat for plant");
			AddHealth(3);
		}

		if (other.tag == "PartyHat")
		{
			Debug.Log("PartyHat for plant");
			AddHealth(6);
		}

		if (other.tag == "PirateHat")
		{
			Debug.Log("PirateHat for plant");
			AddHealth(8);
		}		
	}

	void AddHealth(int health)
	{
		currentHealth += health;
		healthBar.SetHealth(currentHealth);
	}
}

// public class Plant : MonoBehaviour
// {

// 	public int maxHealth = 100;
// 	public int currentHealth;

// 	public HealthBar healthBar;

//     // Start is called before the first frame update
//     void Start()
//     {
// 		currentHealth = maxHealth;
// 		healthBar.SetMaxHealth(maxHealth);
//     }

//     // Update is called once per frame
//     void Update()
//     {
// 		if (Input.GetKeyDown(KeyCode.Space))
// 		{
// 			TakeDamage(20);
// 		}
//     }

// 	void TakeDamage(int damage)
// 	{
// 		currentHealth -= damage;
// 		healthBar.SetHealth(currentHealth);
// 	}
// }