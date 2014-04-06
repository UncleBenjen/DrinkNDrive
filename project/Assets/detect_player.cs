using UnityEngine;
using System.Collections;

public class detect_player : MonoBehaviour {
	public bool player_hit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Player"){
			//DO SOMETHING IF THE PLAYER HIT THE WALL
			player_hit=true;
		}

	}
}
