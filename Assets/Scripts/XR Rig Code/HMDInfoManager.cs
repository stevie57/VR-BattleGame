﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log($"is device active {XRSettings.isDeviceActive}");
        //Debug.Log($"device name is : {XRSettings.loadedDeviceName} ");
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset plugged");
        }
        else if(XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Using Mock HMD");
        }
        else
        {
            Debug.Log($"We have a headset - {XRSettings.loadedDeviceName}");
        }


    }
}
