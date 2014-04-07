using UnityEngine;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.IO;

public class GameLogicController : MonoBehaviour {

	public bool playClick;
	public int weight;
	public int hour;
	public float bac;
	public string genre;
	public char color;

	public TextAsset GameAsset;

	private float nextDecreasee;
	public float decreaseRate;

	public int numberOfDrinks;
	public int drinkingTime;

	private List<List<string[]>> mdrinksList = new List<List<string[]>> ();

		
	// Use this for initialization
	void Start () {
		numberOfDrinks = 0;
		nextDecreasee = 0;
		playClick = false;
		hour = 0;
		bac = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextDecreasee && bac>0) {
			nextDecreasee = Time.time + decreaseRate;
			drinkingTime+=5;
		}
		if(playClick && numberOfDrinks>1){
		hour = (int) drinkingTime/60;
			if (hour >= mdrinksList[numberOfDrinks-1].Count)
				hour = mdrinksList[numberOfDrinks-1].Count-1;
		bac =(float) double.Parse(mdrinksList[numberOfDrinks-1][hour][weight]);
			bacValue.bac = bac;
			setColor();
		}
	}

	public void AddDrink(int type){

		addDrinkType (type);

		Debug.Log (mdrinksList[numberOfDrinks][hour][weight]);
		bac =(float) double.Parse(mdrinksList[numberOfDrinks][hour][weight]);

		numberOfDrinks++;
		if (numberOfDrinks >= mdrinksList.Count)
			numberOfDrinks = mdrinksList.Count-1;

	}
	public void addDrinkType(int type){
		if (type == 1) {//beer
			drinkingTime+=10;
				}
		else if(type == 2){//wine
			drinkingTime+=25;
		}
		else if(type == 3){//shot
			drinkingTime+=4;
		}
		else if(type == 4){
			drinkingTime+=20;
		}
		else if(type == 5){
			drinkingTime+=15;
		}
	}
	public void GetDrinks(){
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(GameAsset.text); // load the file.
		XmlNodeList drinksList = xmlDoc.GetElementsByTagName(genre); // array of the male or female nodes.
		foreach (XmlNode genreInfo in drinksList) 
		{
			XmlNodeList drinkscontent = genreInfo.ChildNodes;
			foreach (XmlNode levelsItens in drinkscontent) // levels itens nodes.
			{
				Debug.Log(levelsItens.InnerText);
				List<string[]> a = ParseLine(levelsItens.InnerText);
				mdrinksList.Add(a);

			}
	
		}
	}
	List<string[]> ParseLine(string line){
		List<string[]> list = new List<string[]>();
		string[] splitLine = line.Split (':');
		string[] bacHour = new string[5];
		int j = 0;
		for(int i=0; i<splitLine.Length; i++, j++){
			if(i%5==0)
			{
				bacHour = new string[5];
				list.Add(bacHour);

				j = 0;
			}
			bacHour[j]=splitLine[i];
			Debug.Log(bacHour[j]);

		}
		return list;
	}

	void setColor(){
		if (genre == "male") 
		{
			if(numberOfDrinks<5){
				color='g';
			}
			else if(numberOfDrinks>5){
				color='r';
			}
			else{
				color='g';
			}

		}
		if (genre == "female") 
		{
			if(numberOfDrinks<4){
				color='g';
			}
			else if(numberOfDrinks>4){
				color='r';
			}
			else{
				color='g';
			}
		}
	}
}
