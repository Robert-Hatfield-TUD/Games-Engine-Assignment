using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpFlowGen : MonoBehaviour
{
    public GameObject pFlower;
    public int maxX = 141;
    public int minX = 125;
    public int set = 0;
    public float zLoc;
    public float yLoc;
    public float xLoc;
    public GameObject pFlow;

    public float rando;

    void Start()
    {
        //Debug.Log("Flower started");
        insPurpFlower();
    }

    void Update()
    {
        desPurpFlower();
    }

    public void insPurpFlower()
    {
        if (set <= 0)
        {

            rando = Random.Range(minX, maxX);
            pFlow = Instantiate(pFlower);
            pFlow.transform.parent = transform;
            pFlow.transform.localPosition = new Vector3(rando, 13, 170);
            pFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
            set++;
        }
    }

    public void desPurpFlower()
    {
        if (pFlow.active)
        {
            zLoc = pFlow.transform.position.z;
            yLoc = pFlow.transform.position.y;
            xLoc = pFlow.transform.localPosition.x;

            if (pFlow.transform.position.z < 247)
            {

                zLoc = zLoc + 0.28f;

                pFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);

            }
            else
            {
                pFlow.SetActive(false);
            }
        }
        else
        {
            //Debug.Log("Flower disabled");
            set = 0;
            StartCoroutine(flowerSpawn());
        }
    }

    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(3);
        //Debug.Log("Flower ready for spawn");
        insPurpFlower();
    }

    //} 243.14 z
    // 11.42 y
}