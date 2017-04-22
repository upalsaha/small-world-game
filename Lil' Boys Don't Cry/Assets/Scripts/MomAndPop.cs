using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomAndPop : MonoBehaviour {

	public GameObject textBox;
	private GUIStyle style = new GUIStyle();
	public string[] textLines;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){

		style.fontSize = 20;
		GUI.Label(new Rect(300, 500, 100, 20), textLines[0], style);
 	}
}
