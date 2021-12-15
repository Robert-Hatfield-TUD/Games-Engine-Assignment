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
    public beeMove score;

    void Start()
    {
        oFlow = Instantiate(oFlower);
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
            oFlow.SetActive(true);
            rando = Random.Range(minX, maxX);
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

                zLoc = zLoc + 0.3f;

                oFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);

            }
            else
            {
                oFlow.SetActive(false);
            }
        }
        else
        {
            if (score.score < 35)
            {
                set = 0;
                StartCoroutine(flowerSpawn());
            }
        }
    }

    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(2);
        insOranFlower();
    }
}
