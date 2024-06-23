using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour
{
    public float coldTime = 2;
    private float timer = 0;
    public bool isColding = false;
    public KeyCode keyCode;

    PlayerControls inputActions;
    public Image coldMask;

    // Start is called before the first frame update
    void Start()
    {
        coldMask = transform.Find("ColdMask").GetComponent<Image>();
        coldMask.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            OnSkillClick();
        }
        UpdateColdValue();
    }

    public void OnSkillClick()
    {
        if (!isColding)
        {
            isColding = true;
            coldMask.fillAmount = 1;
        }
        else
        {
            return;
        }
    }

    public void UpdateColdValue()
    {
        if (isColding)
        {
            timer += Time.deltaTime;
            coldMask.fillAmount = (coldTime - timer) / coldTime;
            if (timer >= coldTime)
            {
                isColding = false;
                coldMask.fillAmount = 0;
                timer = 0;
            }
        }
    }
}
