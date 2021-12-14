using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oranFlowGen : MonoBehaviour
{
    public GameObject oFlower;
    public int maxX = 141;
    public int minX = 125;
    public int set = 0;
    public float zLoc;
    public float yLoc;
    public float xLoc;
    public GameObject oFlow;

    public float rando;

    void Start()
    {
        insOranFlower();
    }

    void Update()
    {
        desOranFlower();
    }

    public void insOranFlower()
    {
        if (set <= 0)
        {

            rando = Random.Range(minX, maxX);
            oFlow = Instantiate(oFlower);
            oFlow.transform.parent = transform;
            oFlow.transform.localPosition = new Vector3(rando, 13, 170);
            oFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
            set++;
        }
    }

    public void desOranFlower()
    {
        if (oFlow.active)
        {
            zLoc = oFlow.transform.position.z;
            yLoc = oFlow.transform.position.y;
            xLoc = oFlow.transform.localPosition.x;

            if (oFlow.transform.position.z < 247)
            {

                zLoc = zLoc + 0.28f;

                oFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);

            }
            else
            {
                oFlow.SetActive(false);
            }
        }
        else
        {
            set = 0;
            StartCoroutine(flowerSpawn());
        }
    }

    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(2);
        insOranFlower();
    }
}
