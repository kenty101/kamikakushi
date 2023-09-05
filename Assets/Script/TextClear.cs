using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextClear : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public float d_color;


    public GameObject modoru;



    public void Update()
    {

        d_color += 0.005f;
        _text.faceColor = new Color(236, 41, 41, d_color);


        Invoke("modore", 4.0f);
  



    }
    public void modore()
    {
        modoru.SetActive(true); 
    }


}
