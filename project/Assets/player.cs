using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	private float steer = 0;
	private float drunk = 0;

	// Use this for initialization
	void Start () {
		Vector3 eulerAngles = transform.rotation.eulerAngles;
		eulerAngles = new Vector3(0, eulerAngles.y, 0);
		transform.rotation = Quaternion. Euler(eulerAngles);
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetInput();
	}

	void GetInput()
	{
		steer = -Input.GetAxis("Horizontal");
	}

	void ApplySteering()
	{
		//transform.RotateAround (Vector3.zero, Vector3.up, 20 * steer);
		rigidbody.position += Vector3.forward * steer;
		
	}

	void FixedUpdate()
	{	
		ApplySteering();
	}
}
