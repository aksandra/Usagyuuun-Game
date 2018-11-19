using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed;
	public float jump;
	
	void Start () {
		if(Input.GetKey(KeyCode.W))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,jump);
		}
		if(Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed,GetComponent<Rigidbody2D> ().velocity.y);
		}
		if(Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed,GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	
	
	void Update () {
		
	}
}
