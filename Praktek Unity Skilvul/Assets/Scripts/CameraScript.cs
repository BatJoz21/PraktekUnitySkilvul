using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] Transform bodyTransform;
    [SerializeField] private float sensitivity = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousex = Input.GetAxisRaw("Mouse X");
        var mousey = Input.GetAxisRaw("Mouse Y");

        bodyTransform.transform.Rotate(-mousey * sensitivity, mousex * sensitivity, 0);
    }
}
