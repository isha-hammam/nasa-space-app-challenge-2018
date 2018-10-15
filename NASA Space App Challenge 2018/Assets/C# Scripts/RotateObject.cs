using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

	float RotationSpeed	= 500;

	public void OnMouseDrag ()
	{
		float RotationX = Input.GetAxis ("Mouse X") * RotationSpeed * Mathf.Deg2Rad;
		//float RotationY = Input.GetAxis ("Mouse Y") * RotationSpeed * Mathf.Deg2Rad;

		transform.Rotate (Vector3.up, -RotationX);
		//transform.Rotate (Vector3.right, RotationY);
	}

}
