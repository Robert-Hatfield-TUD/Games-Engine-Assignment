using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameScript : MonoBehaviour
{
    AudioSource audioS;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        AudioSource.volume = 0.5f;
        audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
