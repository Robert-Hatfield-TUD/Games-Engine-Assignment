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
    // Start is called before the first frame update
    void Start()
    {
        var bFlowerG = Instantiate(bFlower, new Vector3(135, 11, 213), Quaternion.identity);
        Debug.Log("Flower started");

        bFlowerG.transform.parent = terra.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //} 243.14 z
    // 11.42 y
}
