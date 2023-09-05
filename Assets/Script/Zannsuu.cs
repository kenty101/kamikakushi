using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Zannsuu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _zannsuuText;

    public void SetZannsuu(int zannsuu)
    {
        _zannsuuText.text = "c‚è" + zannsuu@+ "‰ñ";
    }

}
