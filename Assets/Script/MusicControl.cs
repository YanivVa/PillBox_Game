﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public AudioClip otherClip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start(){
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update(){
        if (!audioSource.isPlaying){
            audioSource.clip = otherClip;
            audioSource.Play();
        }

    }
    public void pause(){


    }
}
