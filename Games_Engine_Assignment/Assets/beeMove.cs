using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beeMove : MonoBehaviour
{

    Vector3 mVec;
    public int score = 0;
    public int scoreTemp = 0;
    public int scoreStart = 0;
    public GameObject Name;
    public GameObject Scores;
    public Text scoreSet;
    public AudioSource polGet;

    void Start()
    {

    }

    void Update()
    {
        mVec = transform.localPosition;

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
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Scores.SetActive(true);
        }

        if (other.gameObject.name == "blueFlowerR(Clone)")
        {
            Name = GameObject.Find("blueFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                polGet.volume = 0.1f;
                polGet.Play();
            }
        }
        if (other.gameObject.name == "purpleFlowerR(Clone)")
        {
            Name = GameObject.Find("purpleFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                polGet.volume = 0.1f;
                polGet.Play();
            }
        }
        if (other.gameObject.name == "orangeFlowerR(Clone)")
        {
            Name = GameObject.Find("orangeFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                polGet.volume = 0.1f;
                polGet.Play();
            }
        }

        scoreSet.text = "Score: " + score;
    }
}