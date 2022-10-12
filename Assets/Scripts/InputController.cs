using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public TMP_InputField time, speed, distance;

    public (float, float, float) GetInput()
    {
        (float, float, float) result;
        if (!float.TryParse(time.text, out result.Item1))
        {
            result.Item1 = 0;
        };
        if (!float.TryParse(speed.text, out result.Item2))
        {
            result.Item2 = 0;
        };
        if (!float.TryParse(distance.text, out result.Item3))
        {
            result.Item3 = 0;
        };
        
        return result;
    }
}
