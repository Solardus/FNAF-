using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraControl : MonoBehaviour
{
   
    public bool isRotating = false;
    public float timetoPause = 1.0f;

    public Transform startTransform;
    public Transform endTransform;
    protected Quaternion startAngle;
    [SerializeField]
    protected bool currentDirection = true;


    // Start is called before the first frame update
    void Start()
    {
        startAngle = transform.rotation;
        StartCoroutine("cameraroatation");
    }
    Coroutine camerarotation()
    {
        while(true)
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (currentDirection)
        {

        }
        else
        {

        }
    }
}
