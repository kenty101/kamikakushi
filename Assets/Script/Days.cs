using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Days : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _daysText;


    public void SetDays(int day)
    {
        _daysText.text = "Žc‚è" + day + "‰ñ";
    }

}
