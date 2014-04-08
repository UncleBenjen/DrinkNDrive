using UnityEngine;
using System.Collections;


public class destroy : MonoBehaviour {
	public int obstacle_passed =0;
	public bool hard_mode = false;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(!hard_mode){
			Destroy(other.gameObject); 
		}

		obstacle_passed++;
		passed_obstacles.OBSTACLES_PASSED=obstacle_passed;
	}
}
