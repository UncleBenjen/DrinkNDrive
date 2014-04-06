using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	public StartMenu startMenu;
	void OnMouseDown() {
		Debug.Log ("Click Play");
		startMenu.display = true;
		Destroy (gameObject);
	}
}
