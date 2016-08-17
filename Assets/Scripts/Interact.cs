﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interact : MonoBehaviour 
{
	public string interactButton;
	public float interactDistance = 3f;
	public LayerMask interactLayer;
	public Image interactIcon;
	public bool isInteracting;

	// Use this for initialization
	void Start () 
	{
		if (interactIcon != null) 
		{
			interactIcon.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, interactDistance, interactLayer)) 
		{
			if (isInteracting == false) 
			{
				if (interactIcon != null) 
				{
					interactIcon.enabled = true;
				}
				if (Input.GetButtonDown(interactButton))
				{
					if(hit.collider.CompareTag("Door")) 
					{
					hit.collider.GetComponent<doorController>().changeDoorState();
					}
				}
			}
		}
	}
}
