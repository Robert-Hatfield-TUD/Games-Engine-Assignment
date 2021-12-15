/*

This is the script to check if the object for the flower is enabled and then to change its position if has been disabled

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oranFlowGen : MonoBehaviour
{
    // Setting variables/objects to be used in the script
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

    // Instantiating the flower with the imported blender model of the flower and calling the flower to instantiate it
    void Start()
    {
        oFlow = Instantiate(oFlower);
        insOranFlower();
    }

    // Update which calls the function to check if the flower is enabled and to move it
    void Update()
    {
        desOranFlower();
    }

    // Function to enable the flower and then place it in a random spot on front of the bee
    public void insOranFlower()
    {
        // If ensuring there is only one of each flower at a time
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

    // The function to move the flower and disables it if it passes the player
    public void desOranFlower()
    {
        // If to check if it is enabled and then move is or disable it if need be
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
        // Else which will only spawn the flower if the score is below 35 points
        else
        {
            if (score.score < 35)
            {
                set = 0;
                StartCoroutine(flowerSpawn());
            }
        }
    }

    // Coroutine which uses a timer to spawn the flower a specific time after it has been disabled
    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(2);
        insOranFlower();
    }
}
