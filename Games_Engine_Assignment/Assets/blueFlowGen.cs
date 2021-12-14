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
    public GameObject bFlow;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject bFlow = Instantiate(bFlower);
        //bFlow.transform.parent = transform;
        //bFlow.transform.localPosition = new Vector3(135, 17, 213);
        //bFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
        //var bFlowerG = Instantiate(bFlower, new Vector3(135, 11, 213), Quaternion.identity);
        Debug.Log("Flower started");

        //StartCoroutine(moveBack(bFlow));
        //bFlowerG.transform.parent = terra.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (set <= 0)
        {
            bFlow = Instantiate(bFlower);
            bFlow.transform.parent = transform;
            bFlow.transform.localPosition = new Vector3(135, 10, 170);
            bFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
            set++;
        }
        //bFlow.transform.position.z = bFlow.transform.position.x - 0.020f;
        StartCoroutine(moveBack(bFlow));
    }

    IEnumerator moveBack(GameObject gObj)
    {
        zLoc = gObj.transform.position.z;
        if (gObj.transform.position.z < 247)
        {

            zLoc = zLoc + 0.28f;

            gObj.transform.localPosition = new Vector3(135, 17, zLoc);
            Debug.Log(gObj.transform.position.z);
        }
        else
        {
            Destroy(gObj);
            //insFlower();
        }
        yield return new WaitForSeconds(0);

    }

    //} 243.14 z
    // 11.42 y
}
