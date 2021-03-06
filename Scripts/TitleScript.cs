﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Title screen script
/// </summary>
public class TitleScript : MonoBehaviour
{
	/// <summary>
	/// The next button skin
	/// </summary>
	private GUISkin nextBtn;
	private GUISkin exitBtn;
	
	public float button1YFB = 4;
	
	public float button2YFB = 2;

	void Start()
	{
		//call this during start to load the resource for the button(s) you wish to create skins for
		nextBtn = Resources.Load ("Next_Button_GUI") as GUISkin;
		exitBtn = Resources.Load ("EndGame_Button_Skin") as GUISkin;
	}

	void OnGUI()
	{
		//change the next gui function called
		GUI.skin = nextBtn;

		const int buttonWidth = 120;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect1 = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(Screen.height) - (buttonHeight * button1YFB),
			buttonWidth,
			buttonHeight
			);
		
		// next button
		if(GUI.Button(buttonRect1,""))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			int i = Application.loadedLevel;
			Application.LoadLevel(i+1);
		}

		GUI.skin = exitBtn;
		Rect buttonRect2 = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(Screen.height) - (buttonHeight * button2YFB),
			buttonWidth,
			buttonHeight
			);
		
		// next button
		if(GUI.Button(buttonRect2,""))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
		}
	}
}