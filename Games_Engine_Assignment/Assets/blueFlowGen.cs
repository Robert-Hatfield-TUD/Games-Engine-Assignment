/*

This is the script to check if the object for the flower is enabled and then to change its position if has been disabled

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueFlowGen : MonoBehaviour
{
    // Setting variables/objects
    public GameObject bFlower;
    public int maxX = 141;
    public int minX = 125;
    public int set = 0;
    public float zLoc;
    public float yLoc;
    public float xLoc;
    public GameObject bFlow;

    public float rando;
    public beeMove score;

    void Start()
    {
        bFlow = Instantiate(bFlower);
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
            bFlow.SetActive(true);
            rando = Random.Range(minX, maxX);
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

            if (bFlow.transform.position.z < 247)
            {
                zLoc = zLoc + 0.3f;
                bFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);
            }
            else
            {
                bFlow.SetActive(false);
            }
        }
        else
        {
            if (score.score < 65)
            {
                set = 0;
                StartCoroutine(flowerSpawn());
            }
        }
    }

    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(1);
        insBlueFlower();
    }
}