/*

This is the script that mainly handles the movement of the bee however it also handles the display of the score and also other text objects

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beeMove : MonoBehaviour
{

    // Setting all the variables/Objects to be used later in the script 
    Vector3 mVec;
    public int score = 0;
    public int scoreTemp = 0;
    public int scoreStart = 0;
    public GameObject Name;
    public GameObject Scores;
    public GameObject End;
    public Text scoreSet;
    public AudioSource polGet;

    void Update()
    {
        // Filling Vector3 with current position in game of the bee
        mVec = transform.localPosition;

        // If statements to keep bee in the allowed area of the screen
        if (mVec.x <= 141)
        {
            mVec.x -= Input.GetAxis("Horizontal") * Time.deltaTime * 5;
            transform.localPosition = mVec;
        }
        else
        {
            mVec.x = mVec.x - 0.09f;
            transform.localPosition = mVec;
        }

        if (mVec.x >= 125)
        {
            mVec.x -= Input.GetAxis("Horizontal") * Time.deltaTime * 5;
            transform.localPosition = mVec;
        }
        else
        {
            mVec.x = mVec.x + 0.09f;
            transform.localPosition = mVec;
        }
        // If statement to call coroutine to start the end of the game
        if (score == 65)
        {
            StartCoroutine(EndPollen());
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Scores.SetActive(true);
        }
    }

    // OnTrigger function to check for collisions with the flowers in game 
    void OnTriggerEnter(Collider other)
    {
        // If statement to play collection sound
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            polGet.volume = 0.1f;
            polGet.Play();
        }
        // If for collision with the blue flower
        if (other.gameObject.name == "blueFlowerR(Clone)")
        {
            Name = GameObject.Find("blueFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }
        // If for collision with the purple flower
        if (other.gameObject.name == "purpleFlowerR(Clone)")
        {
            Name = GameObject.Find("purpleFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }
        // If for collision with the orange flower
        if (other.gameObject.name == "orangeFlowerR(Clone)")
        {
            Name = GameObject.Find("orangeFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }
        // Setting the new score after each flower collected
        scoreSet.text = "Score: " + score;
    }

    // Coroutine to print final text at the end
    IEnumerator EndPollen()
    {
        Scores.SetActive(false);
        yield return new WaitForSecondsRealtime(4);
        End.SetActive(true);
    }
}