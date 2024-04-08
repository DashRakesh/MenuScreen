using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextMeshPro : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextElement;
 
    public void ButtonPress()
    {
        TextElement.text = "This is new Text";
        TextElement.textStyle = TMP_Style.NormalStyle;
        TextElement.fontStyle = FontStyles.Bold;
        TextElement.color = Color.red;
        TextElement.fontSize = 200f;
    }
}
