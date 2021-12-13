using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMain : MonoBehaviour
{

    private float[] a_AudioMain;
    private static float audioMainVal { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        a_AudioMain = new float[128];
    }

    // Update is called once per frame
    void Update()
    {

        AudioListener.GetSpectrumData(a_AudioMain, 0, FFTWindow.Hamming);

        if (a_AudioMain != null && a_AudioMain.Length > 0)
        {
            audioMainVal = a_AudioMain[0] * 100;
        }
    }
}
