using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxyScript : MonoBehaviour
{
    private Transform startTransform;
    public Transform target;
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        startTransform = this.GetComponent<Transform>();
        x = startTransform.position.x;
        y = startTransform.position.y;
        z = startTransform.position.z;
    }

    public void OnCollisionEnter(Collision collision)
    {
        startTransform = this.GetComponent<Transform>();
        Vector3 vector3 = new Vector3();
        vector3.x = x;
        vector3.y = y;
        vector3.z = z;
        startTransform.position = vector3;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        transform.LookAt(target, Vector3.left);
    }
}
