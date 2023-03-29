using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TexTest : MonoBehaviour
{
    [SerializeField] private TMP_Text tmpxt;
    [SerializeField] private string txt;
    [SerializeField] private Color color;

    // Start is called before the first frame update
    void Start()
    {
        tmpxt.text = txt;
        tmpxt.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
