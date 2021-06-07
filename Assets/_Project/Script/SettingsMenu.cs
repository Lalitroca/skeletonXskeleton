using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class SettingsMenu : MenuVirtualController
{
    [Header("UI Objects")]
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private Slider _sound = null;
    [SerializeField] private TMP_Text _soundNumberText = null;
    [SerializeField] private Slider _arrows = null;
    [SerializeField] private TMP_Text _arrowNumberText = null;
    [SerializeField] private Button _matchTimeRightButton = null;
    [SerializeField] private Button _matchTimeLeftButton = null;
    [SerializeField] private TMP_Text _matchTimeText = null;
    [SerializeField] private Button _constantRunRightButton = null;
    [SerializeField] private Button _constantRunLeftButton = null;
    [SerializeField] private TMP_Text _constantRunText = null;
    [SerializeField] private TMP_Text[] _menuOptions = null;
    [SerializeField] private Button _confirmSettingsButton = null;
    [SerializeField] private Button _cancelSettingsButton = null;
    [SerializeField] private Color _buttonHoverColor = Color.white;
    [SerializeField] private Color _buttonNormalColor = Color.white;

    [Header("UI Controller Objects")]
    private InputAction _menuInputMoveSideways;
    [SerializeField] private int[] _possibleMatchTimes = null;
    [SerializeField] private string[] _possibleRunChoices = null;
    private int _chosenMatchTime = 0;
    private int _chosenRunChoices = 0;

    protected override void OnEnable()
    {
        base.OnEnable();
        _menuInputMoveSideways.performed += SelectNextOption;
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        _menuInputMoveSideways.performed -= SelectNextOption;
    }
    protected override void Initialize()
    {
        base.Initialize();

        _maxMenuOptions = _menuOptions.Length;

        _menuInputMoveSideways = _inputs.menuInputs.menuChoose;

        _matchTimeLeftButton.onClick.AddListener(delegate{MatchTimeHandler(-1);});
        _matchTimeRightButton.onClick.AddListener(delegate{MatchTimeHandler(1);});
        _constantRunLeftButton.onClick.AddListener(delegate{ConstantRunningHandler(-1);});
        _constantRunRightButton.onClick.AddListener(delegate{ConstantRunningHandler(1);});
        _confirmSettingsButton.onClick.AddListener(ConfirmChanges);
        _cancelSettingsButton.onClick.AddListener(ClosePanel);
    }
    protected override void SetUpMouseHover()
    {
        for(int i = 0; i < _maxMenuOptions; i++)
        {
            _menuOptions[i].gameObject.GetComponentInParent<HoverOverElement>().Initialize(i, this);
        }
    }
    protected override void ConfirmMenuOption()
    {
        if(_menuSelector == 4)
        {
            ClosePanel();
            return;
        }
        else if(_menuSelector == 5)
        {
            ConfirmChanges();
            return;
        }
    }
    protected override void ChangeHoveredButtonColor()
    {
        for (var i = 0; i < _maxMenuOptions; i++)
        {
            if(_menuSelector == i)
            {
                if(i >= _maxMenuOptions - 2)
                {
                    _menuOptions[i].transform.parent.GetComponent<Button>().GetComponent<Image>().color = _buttonHoverColor;
                }
                else
                {
                    _menuOptions[i].color = _hoverColor;
                }
            } else
            {
                if(i >= _maxMenuOptions - 2)
                {
                    _menuOptions[i].transform.parent.GetComponent<Button>().GetComponent<Image>().color = _buttonNormalColor;
                }
                else
                {
                    _menuOptions[i].color = _normalColor;
                }
            }
        }
    }

    private void Update()
    {
        _soundNumberText.text = _sound.value.ToString();
        _arrowNumberText.text = _arrows.value.ToString();
        AudioListener.volume = _sound.value/100;
    }

    private void SelectNextOption(InputAction.CallbackContext movement)
    {
        switch(_menuSelector)
        {
            case 0:
            {
                _sound.value += movement.ReadValue<float>();
                break;
            }
            case 1:
            {
                _arrows.value += movement.ReadValue<float>();
                break;
            }
            case 2:
            {
                MatchTimeHandler((int)movement.ReadValue<float>());
                break;
            }
            case 3:
            {
                ConstantRunningHandler((int)movement.ReadValue<float>());
                break;
            }
            case 4:
            {
                if(movement.ReadValue<float>() > 0)
                {
                    _menuSelector ++;
                    ChangeHoveredButtonColor();
                }
                break;
            }
            case 5:
            {
                if(movement.ReadValue<float>() < 0)
                {
                    _menuSelector --;
                    ChangeHoveredButtonColor();
                }
                break;
            }
            default:
            {
                Debug.Log("Menu selection not recognized");
                break;
            }
        }
    }
    private void MatchTimeHandler(int direction)
    {
        _chosenMatchTime += direction;
        if(_chosenMatchTime < 0)
        {
            _chosenMatchTime = _possibleMatchTimes.Length;
        } else if(_chosenMatchTime > _possibleMatchTimes.Length)
        {
            _chosenMatchTime = 0;
        }
        if(_chosenMatchTime == _possibleMatchTimes.Length)
        {
            _matchTimeText.text = "ENDLESS";
        } else
        {
            _matchTimeText.text = _possibleMatchTimes[_chosenMatchTime] + " MIN";
        }
    }

    private void ConstantRunningHandler(int direction)
    {
        _chosenRunChoices += direction;
        if(_chosenRunChoices < 0)
        {
            _chosenRunChoices = _possibleRunChoices.Length - 1;
        } else if(_chosenRunChoices > _possibleRunChoices.Length - 1)
        {
            _chosenRunChoices = 0;
        }
        _constantRunText.text = _possibleRunChoices[_chosenRunChoices];
    }

    private void GetInformation()
    {
        _arrows.value = (float)Configurations.configs.StartingAmmo;
        _sound.value = Configurations.configs.SoundVolume * 100;

        if(Configurations.configs.EndlessGameMode)
        {
            _chosenMatchTime = _possibleMatchTimes.Length; 
        } else
        {
            for(int i = 0; i < _possibleMatchTimes.Length; i++)
            {
                if(_possibleMatchTimes[i] * 60 == Configurations.configs.MatchTime)
                {
                    _chosenMatchTime = i;
                }
            }
        }
        if (Configurations.configs.ConstantRunning)
        {
            _chosenRunChoices = 1;
        } else
        {
            _chosenRunChoices = 0;
        }
    }

    private void ConfirmChanges()
    {
    
        Configurations.configs.StartingAmmo = (int)_arrows.value;
        Configurations.configs.SoundVolume = _sound.value / 100;
        if(_chosenRunChoices == 0)
        {
            Configurations.configs.ConstantRunning = true;
        } else
        {
            Configurations.configs.ConstantRunning = false;
        }
        if(_chosenMatchTime == _possibleMatchTimes.Length)
        {
            Configurations.configs.EndlessGameMode = true;
        } else
        {
            Configurations.configs.MatchTime = _possibleMatchTimes[_chosenMatchTime] * 60;
            Configurations.configs.EndlessGameMode = false;
        }
        Configurations.configs.Save();
        ClosePanel();
    }

    private void ClosePanel()
    {
        AudioListener.volume = Configurations.configs.SoundVolume;
        _mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
