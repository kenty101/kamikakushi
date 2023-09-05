using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Out : MonoBehaviour
{
    Black black;
    ChoiceMove choice;
    public GameObject panelfade;


    // Start is called before the first frame update
    void Start()
    {
        black = GameObject.Find("Blackout").GetComponent<Black>();
        choice = GameObject.Find("Canvas").GetComponent<ChoiceMove>();
        Invoke("fade", 1.0f);
        Invoke("chenge", 2.0f);

        panelfade.SetActive(true);


    }


    public void fade()
    {
        black.fadeout = true;
        black.Update();
    }

    public void chenge()
    {

        choice.god();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
