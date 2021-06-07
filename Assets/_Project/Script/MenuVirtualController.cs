using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MenuVirtualController : MonoBehaviour
{
    [SerializeField] protected Color _normalColor = Color.white;
    [SerializeField] protected Color _hoverColor = Color.white;
    protected int _menuSelector = 0;
    protected InputControls _inputs;
    private InputAction _menuInputMove;
    private InputAction _menuInputSelect;
    protected int _maxMenuOptions;
    protected Button[] buttons;

    public void ChangeMenuSelector(int number)
    {
        _menuSelector = number;
        ChangeHoveredButtonColor();
    }
    protected virtual void OnEnable()
    {
        _inputs.menuInputs.Enable();

        _menuInputMove.performed += MoveMenuInputHandler;
        _menuInputSelect.performed += SelectMenuInputHandler;
    }

    protected virtual void OnDisable()
    {
        _menuInputMove.performed -= MoveMenuInputHandler;
        _menuInputSelect.performed -= SelectMenuInputHandler;

        _inputs.menuInputs.Disable();
    }
    protected virtual void Initialize()
    {        
        buttons = GetComponentsInChildren<Button>();

        _inputs = new InputControls();
        _menuInputMove = _inputs.menuInputs.menuSelect;
        _menuInputSelect = _inputs.menuInputs.menuConfirm;

        _maxMenuOptions = buttons.Length;
        SetUpMouseHover();
        ChangeHoveredButtonColor();
    }

    protected virtual void SetUpMouseHover()
    {
        for(int i = 0; i < _maxMenuOptions; i++)
        {
            HoverOverElement script = buttons[i].gameObject.AddComponent<HoverOverElement>();
            script.Initialize(i, this);
        }
    }

    protected void MoveMenuInputHandler(InputAction.CallbackContext movement)
    {
        _menuSelector -= (int) movement.ReadValue<float>();

        if (_menuSelector < 0)
        {
            _menuSelector = _maxMenuOptions - 1;
        } else if (_menuSelector > _maxMenuOptions - 1)
        {
            _menuSelector = 0;
        }
        ChangeHoveredButtonColor();
    }

    protected virtual void ChangeHoveredButtonColor()
    {
        for (var i = 0; i < buttons.Length; i++)
        {
            if (_menuSelector == i)
            {
                buttons[i].GetComponent<Image>().color = _hoverColor;
            } else
            {
                buttons[i].GetComponent<Image>().color = _normalColor;
            }
        }
    }
    protected virtual void ConfirmMenuOption() {}

    private void Awake()
    {
        Initialize();
    }
    private void SelectMenuInputHandler(InputAction.CallbackContext ctx)
    {
        ConfirmMenuOption();
    }
}
