using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "lightingSchedule_", menuName = "Scriptable Objects/Lighting/LightingSchedule")]
public class LightingSchedule : ScriptableObject
{
    public LightingBrightness[] lightingBrightnessesArray;
}

[System.Serializable]
public struct LightingBrightness
{
    public Month month;
    public int hour;
    public float lightIntensity;
}
