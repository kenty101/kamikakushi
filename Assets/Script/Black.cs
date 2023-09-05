using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Black : MonoBehaviour
{


    public GameObject Panelfade;

    Image fadealpha;

    public  float alpha;
    public  bool fadeout;
    public bool fadein;




    // Start is called before the first frame update
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>();
        alpha = fadealpha.color.a;
        

    }

    public void Update()
    {
        if(fadeout == true)
        {
            FadeOut();
        }
        if(fadein == true)
        {
            FadeIn();
        }
    }
    public void FadeOut()
    {
        alpha += 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if(alpha >= 1)
        {


            fadeout = false;
            Invoke("FadeIn", 1.0f);

        }

    }
    public void FadeIn()
    {

            alpha = 0;
            fadealpha.color = new Color(0, 0, 0, alpha);



    }
}
