using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float steer = 0;
	public float turn_speed = 20;
	public float bac = 0;
	public float wait = 10;
	public float turn = 0;

	// Use this for initialization
	void Start () {
		Vector3 eulerAngles = transform.rotation.eulerAngles;
		eulerAngles = new Vector3(0, eulerAngles.y, 0);
		transform.rotation = Quaternion. Euler(eulerAngles);
		bac = bacValue.bac;
		Debug.Log (bac);
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetInput();
	}

	void FixedUpdate()
	{	
		ApplySteering();
		UpdateVehicle();
	}

	void GetInput()
	{
		steer = -Input.GetAxis ("Horizontal") * turn_speed;
	}

	void ApplySteering()
	{
		Vector3 move = new Vector3 (0.0f, 0.0f, steer);
		rigidbody.velocity = move * turn_speed;
		rigidbody.position = new Vector3 (
			0.0f,
			0.0f,
			Mathf.Clamp(rigidbody.position.z, -10, 10));

		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -1);
	}

	void UpdateVehicle() {
		if (wait < 0) {
			if (Random.value < 0.5) {
				turn = -1.0f * bac ;
				wait = 100 * bac;
			}
			else {
				turn = 1.0f * bac;
				wait = 100 * bac;
			}
		}
		else {
			rigidbody.position += Vector3.forward * turn;
			wait--;
		}
	}
}