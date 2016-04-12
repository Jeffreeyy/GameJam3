using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

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

	public void quitGame()
	{
		Debug.Log ("Game Exited");
		Application.Quit ();

	}

	public void ReturnGame()
	{
		InstructionsScreen.SetActive (false);
		MainMenuScreen.SetActive (true);
	}
}
