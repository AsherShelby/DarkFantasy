using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public string selfName;
    public Toggle toggle;
    public Text itemName;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        UpdateColorAndItemName(toggle.isOn);
        toggle.onValueChanged.AddListener(UpdateColorAndItemName);
    }
    
    public void UpdateColorAndItemName(bool isOn)
    {
        if (isOn)
        {
            toggle.targetGraphic.color = toggle.colors.selectedColor;
            itemName.text = selfName;
        }
        else
        {
            toggle.targetGraphic.color = toggle.colors.disabledColor;
        }
    }
    
}
