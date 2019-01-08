using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WskaznikiMenuOpcji : MonoBehaviour
{   
    
    Text wartosc;
    // Start is called before the first frame update
    void Start()
    {
        wartosc = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void textUpdate(float value)
    {
        //masa.text = String.Format("{0:0.##}", value);
        value = (float)Math.Round(value * 100f) / 100f;
        wartosc.text = value.ToString();
    }
}
