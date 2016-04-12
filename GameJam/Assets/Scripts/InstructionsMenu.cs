using UnityEngine;
using System.Collections;

public class InstructionsMenu : MonoBehaviour 
{
	public string startLevel;
	public string Instructions;

	public GameObject InstructionsScreen;
	public GameObject MainMenuScreen;

	public void startGame()
	{
		Application.LoadLevel (startLevel);
	}

	public void instructionsGame()
	{
		InstructionsScreen.SetActive (true);
		MainMenuScreen.SetActive (false);
	}


	public void ReturnGame()
	{
		InstructionsScreen.SetActive (false);
		MainMenuScreen.SetActive (true);
	}
}

