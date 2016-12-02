using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Game_Controller : MonoBehaviour 
{
	//Public Instance Variables
	[Header ("User Interface")]
	public Button OpenScreen;
	public Button Options;
	public Button StartGame;

	// Use this for initialization
	void Start () 
	{
		//These check for current scene
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void OptionsButton_Click ()
	{
		SceneManager.LoadScene ("Options_Screen");
	}

	public void StartButton_Click ()
	{
		SceneManager.LoadScene (""); // Enter the scenes name of the main game
	}

	public void BackButton_Click ()
	{
		SceneManager.LoadScene ("Open_Screen");
	}
}
