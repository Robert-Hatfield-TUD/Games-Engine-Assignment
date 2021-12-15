/*

This is the script to handle the main audio for the game when started

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameScript : MonoBehaviour
{
    // Adding audio object to play
    public AudioSource audioS;

    void Start()
    {
        // Playing audio and changing volume to 20%
        audioS.Play();
        audioS.volume = 0.2f;
    }
}