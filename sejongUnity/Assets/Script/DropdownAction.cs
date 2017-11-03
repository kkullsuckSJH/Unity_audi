using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownAction : MonoBehaviour {

    List<string> names = new List<string>() { "1 floor", "2 floor", "3 floor" };

    public Dropdown dropdown;
    public Canvas firstFCanvas;
    public Canvas secondFCanvas;
    public Canvas thirdFCanvas;

    public void DropdownIndexChanged(int index)
    {
        if(index == 0)
        {
            firstFCanvas.enabled = true;
            secondFCanvas.enabled = false;
            thirdFCanvas.enabled = false;
        }
        else if (index == 1)
        {
            firstFCanvas.enabled = false;
            secondFCanvas.enabled = true;
            thirdFCanvas.enabled = false;
        }
        else if (index == 2)
        {
            firstFCanvas.enabled = false;
            secondFCanvas.enabled = false;
            thirdFCanvas.enabled = true;
        }

    }

    void Start()
    {
        dropdown.AddOptions(names);
    }
}
