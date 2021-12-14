using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameScript : MonoBehaviour
{
    public GameObject scoreField;
    public AudioSource audioS;

    void Start()
    {
        audioS.Play();
        audioS.volume = 0.2f;
    }

    void Update()
    {

    }
}