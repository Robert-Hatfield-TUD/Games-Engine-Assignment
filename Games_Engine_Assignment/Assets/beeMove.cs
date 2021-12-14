using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beeMove : MonoBehaviour
{

    Vector3 mVec;
    public int score = 0;
    public int scoreTemp = 0;
    public int scoreStart = 0;
    public GameObject Name;
    public GameObject Scores;
    public Text scoreSet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

        if (Input.GetKeyDown("space"))
        {
            scoreSet.text = "Score: 0";
        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "blueFlowerR(Clone)")
        {
            Name = GameObject.Find("blueFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }
        if (other.gameObject.name == "purpleFlowerR(Clone)")
        {
            Name = GameObject.Find("purpleFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }
        if (other.gameObject.name == "orangeFlowerR(Clone)")
        {
            Name = GameObject.Find("orangeFlowerR(Clone)");
            Name.SetActive(false);
            score = score + 1;
        }


        Debug.Log(score);

        scoreSet.text = "Score: " + score;
    }

}
