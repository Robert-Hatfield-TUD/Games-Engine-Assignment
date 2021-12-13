using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSync : MonoBehaviour
{
    public virtual void currentBeat()
    {
        beatTimes = 0;
        m_isBeat = true;
    }

    public virtual void OnUpdate()
    {

        m_previousAudioValue = m_audioValue;
        m_audioValue = AudioSpectrum.spectrumValue;


        if (m_previousAudioValue > beatSensitivity &&
            m_audioValue <= beatSensitivity)
        {

            if (beatTimes > timeStep)
                currentBeat();
        }


        if (m_previousAudioValue <= beatSensitivity &&
            m_audioValue > beatSensitivity)
        {

            if (beatTimes > timeStep)
                currentBeat();
        }

        beatTimes += Time.deltaTime;
    }

    private void Update()
    {
        OnUpdate();
    }

    public float beatSensitivity;
    public float timeStep;
    public float timeToBeat;
    public float restSmoothTime;

    private float m_previousAudioValue;
    private float m_audioValue;
    private float beatTimes;

    protected bool m_isBeat;
}
