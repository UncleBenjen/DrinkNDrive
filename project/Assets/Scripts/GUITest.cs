using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
	public bool display = false;
	private float w, h;
	public GameLogicController gameLogicController;


	void Start(){
		w = Screen.width;
		h = Screen.height;
	}

	void Update(){
		display = gameLogicController.playClick;
	}

	void OnGUI () {
		GUI.backgroundColor = Color.yellow;
		GUI.color = Color.green;
		if (display) {
						// Make a background box
			GUI.Box (new Rect (10, (h/2)-200+40, 220, 190), "Bar Menu");
		
						// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, (h/2)-170+40, 190, 20), "Bottle of beer: 341 ml (12 oz.)")) {
				Debug.Log("Beer");
				gameLogicController.AddDrink(1);
						}
		
						// Make the second button.
			if (GUI.Button (new Rect (20, (h/2)-140+40, 190, 20), "Glass of wine: 148 ml (5 oz.)")) {
				Debug.Log("Shot");
				gameLogicController.AddDrink(2);
						}
					// Make the second button.
			if (GUI.Button (new Rect (20, (h/2)-110+40, 190, 20), "Shot of spirits: 44 ml (1.5 oz.)")) {
				Debug.Log("Wine");
				gameLogicController.AddDrink(3);
					}
			if (GUI.Button (new Rect (20, (h/2)-80+40, 190, 20), "Socialize: 20 mins")) {
				Debug.Log("socialize");
				gameLogicController.addDrinkType(4);
			}
			if (GUI.Button (new Rect (20, (h/2)-50+40, 190, 20), "Dance: 15 mins")) {
				Debug.Log("Dance");
				gameLogicController.addDrinkType(5);
			}



			// ---- go home button

			GUI.Box (new Rect (400, (h/2)-20, 220, 50), "");
			if (GUI.Button (new Rect (410, (h/2)-10, 190, 20), "Go Home")) {
				Debug.Log("Drive Home");
				Application.LoadLevel("drivingGame");
			}
				}
	}
}
