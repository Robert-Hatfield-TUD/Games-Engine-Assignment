/*

This is the script for the menu screen which simply displays a play and exit button

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScreen : MonoBehaviour
{
    // Function to set thte active scene when play pressed
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // When the game is built and ran as an executeable this will exit the game when the exit button is pressed
    public void exitGame()
    {
        Application.Quit();
    }
}