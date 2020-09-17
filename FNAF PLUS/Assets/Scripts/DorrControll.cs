using System.Collections;
using UnityEngine;

public class DorrControll : MonoBehaviour
{

    public GameObject Door;
    public bool doorIsOpening;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);

        }
        if(Door.transform.position.y > -6.6)
        {
            doorIsOpening = false;
        }
    }
    void OnMouseDown()
    {
        doorIsOpening = true;
    }
}
