using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownTest : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        dropdown.ClearOptions();
        var data1 = new TMP_Dropdown.OptionData("Brotherhood of Steel");
        var data2 = new TMP_Dropdown.OptionData("Enclave");
        var data3 = new TMP_Dropdown.OptionData("NCR");
        var list = new List<TMP_Dropdown.OptionData>{data1 ,data2 ,data3};
        dropdown.AddOptions(list);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetSelectedDropdown(int value)
    {
        Debug.Log(dropdown.options[value]);
        Debug.Log(dropdown.itemText.text);
    }
}
