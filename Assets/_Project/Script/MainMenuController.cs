using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MenuVirtualController
{
    [SerializeField] private GameObject _configrurationsMenu = null;

    protected override void Initialize()
    {
        base.Initialize();

        buttons[0].onClick.AddListener(GameStartHandler);
        buttons[1].onClick.AddListener(ConfigurationsOptionHandler);
        buttons[2].onClick.AddListener(QuitGameHandler);
    }

    protected override void ConfirmMenuOption()
    {
        switch(_menuSelector)
        {
            case 0:
            {
                GameStartHandler();
                break;
            }
            case 1:
            {
                ConfigurationsOptionHandler();
                break;
            }
            case 2:
            {
                QuitGameHandler();
                break;
            }
            default:
            {
                Debug.Log("Number " + _menuSelector + " does match any option");
                break;
            }
        }
    }

    private void GameStartHandler()
    {
        SceneManager.LoadSceneAsync("Loading");
    }

    private void ConfigurationsOptionHandler() 
    {
        _configrurationsMenu.SetActive(true);
        gameObject.SetActive(false);
    }

    private void QuitGameHandler()
    {
        Application.Quit();
    }
}
