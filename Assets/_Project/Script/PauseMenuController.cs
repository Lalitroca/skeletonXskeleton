using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MenuVirtualController
{
    [SerializeField] private MatchManager _matchManager = null;

    protected override void Initialize()
    {
        base.Initialize();
        buttons[0].onClick.AddListener(Continue);
        buttons[1].onClick.AddListener(StopMatch);
        buttons[2].onClick.AddListener(Quit);
    }
    protected override void ConfirmMenuOption()
    {
        switch(_menuSelector)
        {
            case 0:
            {
                Continue();
                break;
            }
            case 1:
            {
                StopMatch();
                break;
            }
            case 2:
            {
                Quit();
                break;
            }
            default:
            {
                Debug.Log("Button shouldn't exist");
                break;
            }
        }
    }

    private void Continue()
    {
        _matchManager.PauseMatch(false);
    }

    private void StopMatch()
    {
        _matchManager.PauseMatch(false);
        _matchManager.EndMatch();
    }

    private void Quit()
    {
        _matchManager.PauseMatch(false);
        Application.Quit();
    }
}
