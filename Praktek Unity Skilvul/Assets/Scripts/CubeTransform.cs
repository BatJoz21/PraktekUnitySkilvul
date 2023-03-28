using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.gameObject.name);
        Debug.Log(this.transform.position);
        Debug.Log(this.transform.rotation);
        Debug.Log(this.transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(0.01f, 0, 0);
    }
}
