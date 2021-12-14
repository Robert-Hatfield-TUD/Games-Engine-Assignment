using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameScript : MonoBehaviour
{
    AudioSource audioS;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioS.Play();
        audioS.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
