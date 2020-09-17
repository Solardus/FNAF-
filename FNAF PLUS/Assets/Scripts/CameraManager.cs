using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    List<Camera> lockedList = new List<Camera>();
    public Camera camerasecurityRoom;
    public Camera HallL;
    public Camera HallR;
    public Camera PR1;
    public Camera PR2;
    public Camera PR3;
    public Camera PR4;
    public Camera camera4A;
    public Camera camera4B;
    public Camera camera56;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;
    public Camera camera10;
    public GameObject CameraLocker;

    protected Camera[] cameras;


    [SerializeField]
    protected int currentCamera;

    private void Awake()
    {
        cameras = new Camera[12];
        cameras[0] = camerasecurityRoom;
        cameras[1] = HallL;
        cameras[2] = HallR;
        cameras[3] = PR1;
        cameras[4] = PR2;
        cameras[5] = PR3;
        cameras[6] = PR4;
        cameras[7] = camera4A;
        cameras[8] = camera4B;
        cameras[9] = camera56;
        cameras[10] = camera6;
        cameras[11] = camera7;
    }
    public void addCameraToLockList(int camera)
    {
        lockedList.Add(cameras[camera]);
    }
    public void removeCameraFromLockList(int camera)
    {
        lockedList.Remove(cameras[camera]);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void incCamera()
    {
        cameras[currentCamera].GetComponent <AudioListener>().enabled = false;
        cameras[currentCamera].enabled = false;

        while (true)
        {
            currentCamera++;
           

            if (currentCamera >= cameras.Length)
            {
                currentCamera = 0;
            }
            if(lockedList.Contains(cameras[currentCamera]))
            {
                continue;
            }
            cameras[currentCamera].enabled = true;
            cameras[currentCamera].GetComponent<AudioListener>().enabled = true;
            break;
        }
    }
    void decCamera()
    {
        cameras[currentCamera].GetComponent<AudioListener>().enabled = false;
        cameras[currentCamera].enabled = false;


        while (true)
        {
            currentCamera--;


            if (currentCamera < 0)
            {
                currentCamera = cameras.Length-1;
            }
            if (lockedList.Contains(cameras[currentCamera]))
            {
                continue;
            }
            cameras[currentCamera].enabled = true;
            cameras[currentCamera].GetComponent<AudioListener>().enabled = true;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKeyUp(KeyCode.UpArrow))
      {
            incCamera();
      }
      if (Input.GetKeyUp(KeyCode.DownArrow))
      {
            decCamera();
      }





    }
}
