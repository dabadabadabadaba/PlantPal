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

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Water") 
		{
			AddHealth(5);
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