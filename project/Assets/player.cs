using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	private float steer = 0;
	private float drunk = 0;
	public float turn_speed=5;
	public float forward_speed =5;
	// Use this for initialization
	void Start () {
		Vector3 eulerAngles = transform.rotation.eulerAngles;
		eulerAngles = new Vector3(0, eulerAngles.y, 0);
		transform.rotation = Quaternion. Euler(eulerAngles);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//float forward_control = Input.GetAxis("Vertical")*forward_speed;
		float turn_control = Input.GetAxis("Horizontal")*turn_speed;
		
		
		transform.Rotate(0,turn_control,0);
		
		rigidbody.position += Vector3.forward * -turn_control;
		///GetInput();
	}

	void GetInput()
	{
		steer = -Input.GetAxis("Horizontal")*turn_speed;
	}

	void ApplySteering()
	{
		transform.Rotate(0,-steer,0);

		
	}

	void FixedUpdate()
	{	
		ApplySteering();
	}
}
