using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;
    [SerializeField] Image Image;
    // Start is called before the first frame update
    void Start()
    {
        if (dropdown.value == 0)
        {
            Image.color = Color.red;
        }
        else if (dropdown.value == 1)
        {
            Image.color = Color.green;
        }
        else if (dropdown.value == 2)
        {
            Image.color = Color.yellow;
        }
        else 
                { 
                Image.color = Color.black;
                }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
