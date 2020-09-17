using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsounddelayed : MonoBehaviour
{
    public AudioSource myAudio;
    CameraManager cameramanager;
    // Start is called before the first frame update
    void Start()
    {
        myAudio.PlayDelayed(8.0f);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
