using UnityEngine;
using System.Collections;

public class EndGUI : MonoBehaviour {
	private float w,h;
	private GameObject back_obj;
	public GUIText target;
	// Use this for initialization
	void Start () {
		h = Screen.height;
		w = Screen.width;

		target.text = passed_obstacles.OBSTACLES_PASSED.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Box (new Rect ((w/2)-105, (h/2)+60, 210, 50), "");
		if (GUI.Button (new Rect ((w/2)-95, (h/2)+70, 190, 20), "Main Screen")) {
			Application.LoadLevel("MainScene");
		}
	}
}
