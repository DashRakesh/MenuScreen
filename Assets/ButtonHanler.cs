using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHanler : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Color leftClickcolor;
    [SerializeField] private Color rightClickcolor;

    private Image button;

    private void Start()
    {
        button = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            button.color = leftClickcolor;
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            button.color = rightClickcolor;
        }
    }
}
