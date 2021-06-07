using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenu : MonoBehaviour
{
    [SerializeField] private string menuScene = "StartMenu";
    public void GoBack()
    {
        SceneManager.LoadSceneAsync(menuScene);
    }
}
