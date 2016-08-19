using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour 
{
	public void LoadLevel(string _levelName)
	{
		SceneManager.LoadScene (_levelName);
	}
}
