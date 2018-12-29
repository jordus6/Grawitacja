using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Muzyka : MonoBehaviour
{
    // Reference to Audio Source component
    private AudioSource audioSrc;
    private float musicVolume = 1f;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;

 
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
