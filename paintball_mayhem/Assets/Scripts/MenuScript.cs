using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public string sceneName;

    public void PlayGame()
    {
        sceneName = "Level_1";

        // Loads the desired scene based on the string value of sceneName
        SceneManager.LoadScene(sceneName);

        // Will confirm function is being hit on click
        Debug.Log("Game has Started!");
    }

    public void DisplayCredits()
    {
        sceneName = "Game_Credits";

        // Loads the desired scene based on the string value of sceneName
        SceneManager.LoadScene(sceneName);

        // Will confirm function is being hit on click
        Debug.Log("Game Controls Displayed!");
    }

    public void QuitGame()
    {
        // Quit game application
        Application.Quit();

        // Will confirm function is being hit on click
        Debug.Log("Game Ended!");
    }

    public void LoadMainMenu()
    {
        sceneName = "Main_Menu";

        // Loads the desired scene based on the string value of sceneName
        SceneManager.LoadScene(sceneName);

        // Will confirm function is being hit on click
        Debug.Log("Entered Main Menu!");
    }




}
