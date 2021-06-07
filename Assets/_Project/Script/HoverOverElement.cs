using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverElement : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private int _indexNumber;
    [SerializeField] private MenuVirtualController _menuController;

    public void Initialize(int indexNumber, MenuVirtualController controller)
    {
        _indexNumber = indexNumber;
        _menuController = controller;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _menuController.ChangeMenuSelector(_indexNumber);
    }
}
