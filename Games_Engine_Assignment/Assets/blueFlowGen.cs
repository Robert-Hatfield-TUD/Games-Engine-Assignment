using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueFlowGen : MonoBehaviour
{
    public GameObject bFlower;
    public GameObject pFlower;
    public GameObject terra;
    public int maxX = 141;
    public int minX = 125;
    public int set = 0;
    public float zLoc;
    public float yLoc;
    public float xLoc;
    public GameObject bFlow;

    public float rando;

    void Start()
    {
        Debug.Log("Flower started");
        insBlueFlower();
    }

    void Update()
    {
        desBlueFlower();
    }

    public void insBlueFlower()
    {
        if (set <= 0)
        {

            rando = Random.Range(minX, maxX);
            //Debug.Log("Random: " + rando);
            bFlow = Instantiate(bFlower);
            bFlow.transform.parent = transform;
            bFlow.transform.localPosition = new Vector3(rando, 13, 170);
            bFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
            set++;
        }
    }

    public void desBlueFlower()
    {
        if (bFlow.active)
        {
            zLoc = bFlow.transform.position.z;
            yLoc = bFlow.transform.position.y;
            xLoc = bFlow.transform.localPosition.x;

            //Debug.Log("y: " + yLoc);
            //Debug.Log("x: " + xLoc);

            if (bFlow.transform.position.z < 247)
            {

                zLoc = zLoc + 0.28f;

                bFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);
                //Debug.Log(bFlow.transform.position.z);
            }
            else
            {
                bFlow.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Flower disabled");
        }
    }

    //} 243.14 z
    // 11.42 y
}
