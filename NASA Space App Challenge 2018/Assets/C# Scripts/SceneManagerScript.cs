using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OpenNewScene (string SceneName)
	{
		SceneManager.LoadScene (SceneName);
		Debug.Log ("Now Opening: " + SceneName);
	}

}
