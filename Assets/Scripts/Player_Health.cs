using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour 
{


	public int maxHealth = 100;
	private int currentHealth;


	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;

	}

	// Update is called once per frame
	public void TakeDamage (int _damage) 
	{
		currentHealth -= _damage;


		if (currentHealth <= 0) 
		{
			//Call Die Method
			Die();
		}

	}
	void Die()
	{
		//Kill the Enemy
		//Play an animation
		//Instantiate a ragdoll

		//Destroy the Enemy GO
		Debug.Log("GAME OVER");
	}	
}
