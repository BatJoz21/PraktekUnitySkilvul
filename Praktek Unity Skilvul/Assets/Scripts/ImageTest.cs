using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTest : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite sprt;

    // Start is called before the first frame update
    void Start()
    {
        img.sprite = sprt;
        img.color = new Color(255, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
