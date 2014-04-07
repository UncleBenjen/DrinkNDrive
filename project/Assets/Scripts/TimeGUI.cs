using UnityEngine;
using System.Collections;

public class TimeGUI : MonoBehaviour {
	public GameLogicController gameLogicController;
	public GUIText guiText;
	// Use this for initialization
	void Start () {
		guiText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (gameLogicController.playClick)
		{
			guiText.text = "Time: h"+gameLogicController.drinkingTime/60+" m:"+(int)gameLogicController.drinkingTime%60;
		}
	}
}
