using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] public string scene;
    private TMP_Text loadingText;
    private AsyncOperation asyncLoading;
    private void Awake()
    {
        loadingText = GetComponentInChildren<TMP_Text>();
        LoadScene();
    }

    private void LoadScene() {
        asyncLoading = SceneManager.LoadSceneAsync(scene);
        StartCoroutine(LoadingAnimation());
        
    }

    private IEnumerator LoadingAnimation () {
        while (!asyncLoading.isDone) {
            yield return new WaitForSeconds(1);
            if (loadingText.text.Length >= 10)
                loadingText.text = "Loading";
            else
                loadingText.text += ".";
            Debug.Log("loading...");
        }
    }
}
