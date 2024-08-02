using FMOD.Studio;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaAmbience : MonoBehaviour
{
    public string ambienceEventPath;
    private EventInstance ambienceEventInstance;

    [SerializeField]
    [Range(0, 4)]
    public float roomID;

    public static Action<float> onChangeArea;

    private void OnEnable()
    {
        onChangeArea += ChangeArea;
    }
    private void OnDisable()
    {
        onChangeArea -= ChangeArea;
    }
    void Start()
    {
        ambienceEventInstance = RuntimeManager.CreateInstance(ambienceEventPath);
        ambienceEventInstance.start();
    }

    public void ChangeArea(float areaID)
    {
        ambienceEventInstance.setParameterByName("Ambience", areaID);
    }
}
