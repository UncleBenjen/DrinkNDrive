using UnityEngine;
using System.Collections;

public class move_ground : MonoBehaviour {
	public static int drunk_factor = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		//transform.Rotate(Time.deltaTime, 0, 0);
		transform.Rotate(0, Time.deltaTime*drunk_factor, 0, Space.Self);

	}


	//need to make better random acceleration function
	public int random_acceleration(){
		return Random.Range(0,drunk_factor);
	}
}
