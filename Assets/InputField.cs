using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] InputField input;
    [SerializeField] Text textview;
    [SerializeField] string text;

    public void SetData()
    {
        string Data = input.text;
        PlayerPrefs.SetString("InputData", Data);
    }
    public void ShowData()
    {
        textview.text = PlayerPrefs.GetString("InputData");
    }
}
