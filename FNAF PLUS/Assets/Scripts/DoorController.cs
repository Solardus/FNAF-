using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public bool doorIsOpening;
    public bool doorIsClosing;
    public bool isOpen = false;

    
    void Update()
    {
        if (doorIsOpening == true)
        {
            door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if(door.transform.position.y > 4.17f)
        {
            doorIsOpening = false;
            isOpen = true;
        }
        if (doorIsClosing == true)
        {
            door.transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
        if (door.transform.position.y < 1.402f)
        {
            doorIsClosing = false;
            isOpen = false;
        }

    }
    private void OnMouseDown()
    {
        if (isOpen)
        {
            doorIsClosing = true;
        }
        else
        {
            doorIsOpening = true;
        }
        
    }
    
}
