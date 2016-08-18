using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour 
{


	public int maxHealth = 100;
	private int currentHealth;

	private Animator animator;

	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	public void TakeDamage (int _damage) 
	{
		currentHealth -= _damage;
		animator.SetTrigger("isHit");

		if (currentHealth <= 0) 
		{
			//Call Die Method
		}
		
	}
	void Die()
	{
		//Kill the Enemy
		//Play an animation
		//Instantiate a ragdoll

		//Destroy the Enemy GO
		Destroy(gameObject);
	}	
}
