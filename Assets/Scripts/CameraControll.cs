using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControll : MonoBehaviour
{
	void Update()
	{
		if (Input.touchCount > 0) 
		{
			Debug.Log("Global touch!");
		}
	}
}