using UnityEngine;
using System.Collections;
using System;

public class driveGUI : MonoBehaviour {
	public bool gui_is_on = true;

	// Use this for initialization
	public GUIText targetGuiText;
	public GUIText time_gui;
	public GameObject back;
	public GameObject obstacles;
	public GameObject time;

	public DateTime start;
	public DateTime delta;

	void Start()
	{
		obstacles = GameObject.Find("obstacle_text");
		targetGuiText=obstacles.GetComponent<GUIText>();
		time = GameObject.Find ("time_text");
		time_gui = time.GetComponent<GUIText>();
		back = GameObject.Find("back");

		start = System.DateTime.Now;
	}
	// Update is called once per frame
	void Update () {
		time_gui.text = (System.DateTime.Now - start).ToString();
		targetGuiText.text = back.GetComponent<destroy>().obstacle_passed.ToString();
	}

	void OnGUI()
	{

		
	}
}
