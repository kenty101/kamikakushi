using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float countdown = 5f;
    [SerializeField] private TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

        countdown -= Time.deltaTime;

        timeText.text = countdown.ToString("f1") ;
        if(countdown <= 0)
        {

            SceneManager.LoadScene("GameOver");
        }
        
    }
}
