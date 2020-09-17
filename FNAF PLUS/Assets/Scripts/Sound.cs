using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("myAudio", 540.0f);
    }
    void playAudio()
    {
        myAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
