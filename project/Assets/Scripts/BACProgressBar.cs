using UnityEngine;
using System.Collections;

public class BACProgressBar : MonoBehaviour {

	public GUIStyle progress_empty;
	public GUIStyle progress_full;
	private GUIStyle usedColor;
	public GUIText bacLevel;
	
	//current progress
	public float barDisplay;
	public bool barShow;
	
	Vector2 pos = new Vector2(10,50);
	Vector2 size = new Vector2(200,50);
	
	public Texture2D emptyTex;
	public Texture2D fullTex, progress_y, progress_r, progress_g;
	public GameLogicController gameLogicController;
	
	void OnGUI()
	{
		if(barShow){
		//draw the background:
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y), emptyTex, progress_empty);
		
		GUI.Box(new Rect(pos.x, pos.y, size.x, size.y), fullTex, progress_full);
		
		//draw the filled-in part:
		GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
		
		GUI.Box(new Rect(0, 0, size.x, size.y), fullTex, progress_full);
		
		GUI.EndGroup();
		GUI.EndGroup();
		}
	}
	
	void Update()
	{
		setColorProgress ();
		//the player's health
		barDisplay = gameLogicController.bac * 5;
		barShow = gameLogicController.playClick;
		if (barShow) {
			bacLevel.text = "B.A.C: "+gameLogicController.bac.ToString() + " %";
				}
		bacValue.bac = gameLogicController.bac;
	}
	void setColorProgress(){
		//char c = gameLogicController.color;
		float bac = gameLogicController.bac;
		if (bac <0.079f)
		{
			fullTex = progress_g;
		} 
		else if (bac>0.09f) 
		{
			fullTex = progress_r;
				}
		else
		{
			fullTex = progress_y;
		}
	}
}
