using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeMove : MonoBehaviour
{

    Vector3 mVec;

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

        //243.14
        //transform.Translate(0, 0, Input.GetAxis("Horizontal") * speed * Time.deltaTime);

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //this.transform.Rotate(Vector3.up, -10);
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //this.transform.Rotate(Vector3.up, 10);
        //}
    }
}
