using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
	public bool display = false;
	private bool male, female;
	public GameObject maleObj, femaleObj;
	public Transform trans;
	public GameLogicController gameLogicController;
	private float w, h;
	// Use this for initialization
	void Start () {
		w = Screen.width;
		h = Screen.height;
		male = female = false;
	}

	void OnGUI () {
		GUI.backgroundColor = Color.yellow;
		GUI.color = Color.green;
		if (display) {
			// Make a background box
			GUI.Box (new Rect ((w/2)+20, (h/2)-200, 220, 120), "Genre");
			
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect ((w/2)+30, (h/2)-170, 190, 20), "Male")) {
				Debug.Log("Male");
				gameLogicController.genre = "male";
				Instantiate(maleObj, trans.position, trans.rotation);
				maleObj.animation.Play();
				display=false;
				male=true;
				gameLogicController.GetDrinks();
			}
			
			// Make the second button.
			if (GUI.Button (new Rect ((w/2)+30, (h/2)-140, 190, 20), "Female")) {
				Debug.Log("Female");
				gameLogicController.genre = "female";
				Instantiate(femaleObj, trans.position, trans.rotation);
				display=false;
				female=true;
				gameLogicController.GetDrinks();
			}
		}
		if(male)
		{
			showMaleWeight();
		}
		if (female) {
			shoeFemaleWeight();		
		}

	}

	void showMaleWeight(){
		// Make a background box
		GUI.Box (new Rect ((w/2)-20, (h/2)-200, 220, 200), "Choose your weight:");

		if (GUI.Button (new Rect ((w/2)-10, (h/2)-170, 190, 20), "165 lbs")) {
			Debug.Log("165");
			gameLogicController.weight = 0;
			finish();
		}
		
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-140, 190, 20), "180 lbs")) {
			Debug.Log("180");
			gameLogicController.weight = 1;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-110, 190, 20), "195 lbs")) {
			Debug.Log("195");
			gameLogicController.weight = 2;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-80, 190, 20), "210 lbs")) {
			Debug.Log("210");
			gameLogicController.weight = 3;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-50, 190, 20), "225 lbs")) {
			Debug.Log("225");
			gameLogicController.weight = 4;
			finish();
		}
	}
	void shoeFemaleWeight()
	{

		// Make a background box
		GUI.Box (new Rect ((w/2)-20, (h/2)-200, 220, 200), "Choose your weight:");
		
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-170, 190, 20), "100 lbs")) {
			Debug.Log("165");
			gameLogicController.weight = 0;
			finish();
		}
		
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-140, 190, 20), "115 lbs")) {
			Debug.Log("180");
			gameLogicController.weight = 1;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-110, 190, 20), "130 lbs")) {
			Debug.Log("195");
			gameLogicController.weight = 2;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-80, 190, 20), "145 lbs")) {
			Debug.Log("210");
			gameLogicController.weight = 3;
			finish();
		}
		if (GUI.Button (new Rect ((w/2)-10, (h/2)-50, 190, 20), "160 lbs")) {
			Debug.Log("225");
			gameLogicController.weight = 4;
			finish();
		}
	}
	void finish(){
		gameLogicController.playClick = true;
		male = false;
		female = false;
	}
}
