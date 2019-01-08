using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SoundSliderValue : MonoBehaviour
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
        value *= 100;
        //masa.text = String.Format("{0:0.##}", value);
        value = Mathf.RoundToInt(value);
        wartosc.text = value.ToString();
    }
}
