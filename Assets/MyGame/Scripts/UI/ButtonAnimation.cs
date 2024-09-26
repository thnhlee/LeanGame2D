using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
[AddComponentMenu("ThinhLe/ButtonAnimation")]

public class ButtonAnimation : MonoBehaviour, IPointerMoveHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("exit");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        Debug.Log("Di chuyen");
    }
}
