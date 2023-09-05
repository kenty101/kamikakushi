using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Massage : MonoBehaviour
{
    public GameObject conversationTextObject;
    public Text conversationText;

    private void Start()
    {
        conversationText = conversationTextObject.GetComponent<Text>();
    }
    public void DisplayConversationMessage(string message)
    {
        conversationText.text = message;
    }


   
           

}


