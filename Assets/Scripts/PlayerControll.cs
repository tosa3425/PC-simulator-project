using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControll : MonoBehaviour
{
	[SerializeField] private FixedJoystick joy;
	[SerializeField] private Rigidbody rb;
	
	[SerializeField] private float speed;
	
    void FixedUpdate()
    {
		MovePlayer();
    }
	
	private void MovePlayer()
	{
		rb.velocity = new Vector3(joy.Horizontal * speed, rb.velocity.y, joy.Vertical * speed);
	}
}
