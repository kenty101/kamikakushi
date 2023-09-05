using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Days1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _daysText;


    public void SetDays(int day)
    {
        _daysText.text = "écÇË" + day + "êl";
    }

}
