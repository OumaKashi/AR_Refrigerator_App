using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TempratureManager : MonoBehaviour
{
    [SerializeField]
    private float max;

    [SerializeField]
    private TextMeshProUGUI heatTMP;

    public void AssignHeat(float delta)
    {
        var totalHeat = delta * max;
        heatTMP.text = ((int)totalHeat).ToString() + "°C";
    }
}