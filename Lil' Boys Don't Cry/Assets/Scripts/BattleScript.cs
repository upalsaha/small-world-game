using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScript : MonoBehaviour {

	private GUIStyle defaultStyle = new GUIStyle();
	private GUIStyle boldStyle = new GUIStyle();
	private GUIStyle selectorStyle = new GUIStyle();

	AudioSource menuSound;


	/***States***/
	private int defaultState = 1;


	



	/****Default State****/
	private int insultSelection = 1;
	private int buffSelection = 2;
	private int itemSelection = 3;
	private int humdingerSelection = 4;
	private bool humdingerReady;




	/***Current Stuff****/
	public int currentState;
	public int currentSelection;

	// Use this for initialization
	void Start () {
		currentState = defaultState;
		currentSelection = 1;


		defaultStyle.fontSize = 20;	

		boldStyle.fontSize = 20;
		boldStyle.fontStyle = FontStyle.Bold;
		boldStyle.normal.textColor = Color.grey;

		selectorStyle.fontSize = 28;
		selectorStyle.fontStyle = FontStyle.Bold;

		menuSound = GetComponent<AudioSource>();

		humdingerReady = false;
	}
	
	// Update is called once per frame
	void Update () {
		/****Default State****/
		if(Input.GetKeyDown(KeyCode.W)) {
			menuSound.Play();
			if(currentSelection == buffSelection) {
				currentSelection = insultSelection;
			} else if(currentSelection == humdingerSelection) {
				currentSelection = itemSelection;
			}

		}
		if(Input.GetKeyDown(KeyCode.A)) {
			menuSound.Play();
			if(currentSelection == itemSelection) {
				currentSelection = insultSelection;
			} else if(currentSelection == humdingerSelection) {
				currentSelection = buffSelection;
			}
		}
		if(Input.GetKeyDown(KeyCode.S)) {
			menuSound.Play();
			if(currentSelection == insultSelection) {
				currentSelection = buffSelection;
			} else if(currentSelection == itemSelection && humdingerReady) {
				currentSelection = humdingerSelection;
			}
		}
		if(Input.GetKeyDown(KeyCode.D)) {
			menuSound.Play();
			if(currentSelection == insultSelection) {
				currentSelection = itemSelection;
			} else if(currentSelection == buffSelection && humdingerReady) {
				currentSelection = humdingerSelection;
			}
		}
	}

	void OnGUI(){
		/*
		if (GUI.Button(new Rect(300, 555, 75, 30), "insult"))
			Debug.Log("what is up my dude");

		if (GUI.Button(new Rect(400, 555, 75, 30), "defend"))
			Debug.Log("what is up my dudette");
		*/

		/****Default State****/
		if(currentState == defaultState) {
			GUI.Label(new Rect(245, 500, 100, 20), "Insult", defaultStyle);
			GUI.Label(new Rect(245, 550, 100, 20), "Raise Voice", defaultStyle);
			GUI.Label(new Rect(495, 500, 100, 20), "Use Item", defaultStyle);
			GUI.Label(new Rect(495, 550, 100, 20), "Humdinger!", boldStyle);

			if(currentSelection == insultSelection) {
				GUI.Label(new Rect(225, 495, 100, 20), ">", selectorStyle);
			}
			if(currentSelection == buffSelection) {
				GUI.Label(new Rect(225, 545, 100, 20), ">", selectorStyle);
			}
			if(currentSelection == itemSelection) {
				GUI.Label(new Rect(475, 495, 100, 20), ">", selectorStyle);
			}
			if(currentSelection == humdingerSelection) {
				GUI.Label(new Rect(475, 545, 100, 20), ">", selectorStyle);
			}
		}
	}
}
