﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Help screen script
/// </summary>
public class AnimaticScript : MonoBehaviour
{
	/// <summary>
	/// The start button Skin
	/// </summary>
	private GUISkin startBtn;
	public float button1YFB = 2;
	
	void Start()
	{
		//call this during start to load the resource for the button(s) you wish to create skins for
		startBtn = Resources.Load ("StartGame_Button_Skin") as GUISkin;
	}

	void OnGUI()
	{
		//change the next gui function called
		GUI.skin = startBtn;

		const int buttonWidth = 120;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(Screen.height) - (buttonHeight * button1YFB),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,""))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			int i = Application.loadedLevel;
			Application.LoadLevel(i+1);
		}
	}
}