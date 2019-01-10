using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WskaznikiMenuOpcji : MonoBehaviour
{   
    
    
    Text napis;
    
    // Start is called before the first frame update
    void Start()
    {
       napis = GetComponent<Text>();
       // slider = GetComponent<Slider>();
       // suwakWartosc = slider.value;
       // suwakWartosc = (float)Math.Round(suwakWartosc * 100f) / 100f;
       // text.text = suwakWartosc.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void textUpdate(float value)
    {
       float wartosc = (float)Math.Round(value * 100f) / 100f;

       napis.text = wartosc.ToString();
    }
}
