using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI21 : MonoBehaviour
{
    public string Click;
    public string Enter;
    public string Exit;
    public Text myText;
    

    void Start()
    {
        myText = GameObject.Find("Text21").GetComponent<Text>();
       }

    
    public void DrawTextClick()
    {
        myText.text = Click;
    }

    public void DrawTextEnter()
    {
        myText.text = Enter;
    }

    public void DrawTextExit()
    {
        myText.text = Exit;
    }
}
