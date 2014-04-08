﻿using UnityEngine;
using System.Collections;

public class spawn_object : MonoBehaviour {
	public GameObject object_to_spawn;
	public bool should_spawn = true;
	public int wait_time = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (wait_time<0){
			GameObject temp = Instantiate(object_to_spawn, new Vector3(40,-6,Random.Range(-10,10)), Quaternion.identity) as GameObject;
			temp.transform.parent = GameObject.Find("ground/street").transform;
			wait_time = Random.Range(0,100);
		}
		else{
			wait_time--;
		}
	}
}
