/*

This is the script to check if the object for the flower is enabled and then to change its position if has been disabled

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpFlowGen : MonoBehaviour
{
    // Setting variables/objects to be used in the script
    public GameObject pFlower;
    public int maxX = 141;
    public int minX = 125;
    public int set = 0;
    public float zLoc;
    public float yLoc;
    public float xLoc;
    public GameObject pFlow;

    public float rando;
    public beeMove score;

    // Instantiating the flower with the imported blender model of the flower and calling the flower to instantiate it
    void Start()
    {
        pFlow = Instantiate(pFlower);
        insPurpFlower();
    }

    // Update which calls the function to check if the flower is enabled and to move it
    void Update()
    {
        desPurpFlower();
    }

    // Function to enable the flower and then place it in a random spot on front of the bee
    public void insPurpFlower()
    {
        if (set <= 0)
        {
            pFlow.SetActive(true);
            rando = Random.Range(minX, maxX);
            pFlow.transform.parent = transform;
            pFlow.transform.localPosition = new Vector3(rando, 13, 170);
            pFlow.transform.rotation = Quaternion.Euler(-90, 0, 0);
            set++;
        }
    }

    // The function to move the flower and disables it if it passes the player
    public void desPurpFlower()
    {
        // If to check if it is enabled and then move is or disable it if need be
        if (pFlow.active)
        {
            zLoc = pFlow.transform.position.z;
            yLoc = pFlow.transform.position.y;
            xLoc = pFlow.transform.localPosition.x;

            if (pFlow.transform.position.z < 247)
            {

                zLoc = zLoc + 0.3f;

                pFlow.transform.localPosition = new Vector3(xLoc, yLoc, zLoc);

            }
            else
            {
                pFlow.SetActive(false);
            }
        }
        // Else which will only spawn the flower if the score is below 15 points
        else
        {
            if (score.score < 15)
            {
                set = 0;
                StartCoroutine(flowerSpawn());
            }
        }
    }

    // Coroutine which uses a timer to spawn the flower a specific time after it has been disabled
    IEnumerator flowerSpawn()
    {
        yield return new WaitForSecondsRealtime(3);
        insPurpFlower();
    }

}