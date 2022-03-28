using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigHealth : MonoBehaviour
{
	public int health = 500;

	

	

	public void TakeDamage(int damage)
	{


		
		Destroy(gameObject);
	}

	
}
