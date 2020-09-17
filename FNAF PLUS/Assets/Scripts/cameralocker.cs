using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralocker : MonoBehaviour
{
    [SerializeField] int i = 0;
    [SerializeField] int x = 0;
    [SerializeField] int c = 0;
    [SerializeField] int f = 0;
    [SerializeField] int g = 0;
    [SerializeField] int h = 0;
    [SerializeField] int j = 0;
    [SerializeField] int k = 0;
    [SerializeField] int l = 0;
    [SerializeField] int z = 0;
    [SerializeField] int xx = 0;
    [SerializeField] int cc = 0;
    public CameraManager cameramanager;
    // Start is called before the first frame update
    void Start()
    {
        cameramanager.addCameraToLockList(i);
        cameramanager.addCameraToLockList(x);
        cameramanager.addCameraToLockList(c);
        cameramanager.addCameraToLockList(f);
        cameramanager.addCameraToLockList(g);
        cameramanager.addCameraToLockList(h);
        cameramanager.addCameraToLockList(j);
        cameramanager.addCameraToLockList(k);
        cameramanager.addCameraToLockList(l);
        cameramanager.addCameraToLockList(z);
        cameramanager.addCameraToLockList(xx);
        cameramanager.addCameraToLockList(cc);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
