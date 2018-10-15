using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{

	public AudioSource audio_source;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {

				// Playing Audio Files Based On Touch
				if (hit.transform.name == "Cube_A") {
					audio_source.Play ();
				}

				if (hit.transform.name == "Cube_B") {
					audio_source.Play ();
				}

				if (hit.transform.name == "Cube_C") {
					audio_source.Play ();
				}

				if (hit.transform.name == "Cube_D") {
					audio_source.Play ();
				}

				if (hit.transform.name == "Cube_E") {
					audio_source.Play ();
				}

				if (hit.transform.name == "Cube_F") {
					audio_source.Play ();
				}

			}
		}

	}
}
