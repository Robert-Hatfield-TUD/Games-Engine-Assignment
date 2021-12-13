using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockPlace : MonoBehaviour
{

    public GameObject rock;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int min = 5, max = 256;
        int rand = Random.Range(min, max);
        min = 256 * i;
        max = 256 * i + 256;
        int randa = Random.Range(min, max);
        rock.transform.position = new Vector3(rand, 2, randa);
        i++;
    }
}
