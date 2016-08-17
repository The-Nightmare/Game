using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mbdoorController : MonoBehaviour 
{
	public bool open = false; //this for saving the state of the door

	public float doorOpenAngle = 90f;

	public float doorClosedAngle = 0f;

	public float smooth = 2f;

	public void ChangeDoorState() {
		open = !open;
	}

	void Update () 
	{
		if(open) 
		{
			Quaternion targetRotationOpen = Quaternion.Euler(90, doorOpenAngle, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
		} 
		else 
		{
			Quaternion targetRotationClosed = Quaternion.Euler(90, doorClosedAngle, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
		}
	}
}
