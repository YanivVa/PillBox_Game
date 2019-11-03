using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour{
    AudioSource audioSource;
    int i = 0;
    
    // Start is called before the first frame update
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
       

    }
    public void playAndPause(){

        if (i == 0){
            audioSource.Pause();
            i = i + 1;
        }
        else{
            audioSource.Play();
            i = i - 1;
        }
    }
}
