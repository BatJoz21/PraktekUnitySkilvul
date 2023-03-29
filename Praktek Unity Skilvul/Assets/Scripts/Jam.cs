using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jam : MonoBehaviour
{
    [SerializeField] private Transform pivotDetik;
    [SerializeField] private Transform pivotMenit;
    [SerializeField] private Transform pivotJam;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float detik = 0;
        float menit = 0;
        float jam = 0;

        detik += - speed * Time.deltaTime;
        menit += - (speed - 80) * Time.deltaTime;
        jam += - (speed - 90) * Time.deltaTime;


        pivotDetik.Rotate(new Vector3(0, 0, detik));
        pivotMenit.Rotate(new Vector3(0, 0, menit));
        pivotJam.Rotate(new Vector3(0, 0, jam));
    }
}
