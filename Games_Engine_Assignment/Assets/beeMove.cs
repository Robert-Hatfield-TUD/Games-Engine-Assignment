using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeMove : MonoBehaviour
{

    Vector3 mVec;
    public int score = 0;

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

    }

    void OnTriggerEnter(Collider other)
    {
        //score = score + 1;
        Debug.Log(" trig score: " + score);
        StartCoroutine(flowGet());
    }

    IEnumerator flowGet()
    {
        yield return new WaitForSeconds(2);
        score = score + 1;
    }
}
