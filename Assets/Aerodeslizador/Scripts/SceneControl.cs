using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    [SerializeField] Slider loadBar;
    [SerializeField] GameObject loadPanel;

    public void LoadNextScene(int sceneIndex)
    {
        loadPanel.SetActive(true);
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!asyncOperation.isDone)
        {
            loadBar.value = asyncOperation.progress / 0.9f;
            yield return null;
        }
    }








    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        SceneManager.LoadScene(1) ;
    //    }

    //    if (Input.GetKeyDown(KeyCode.G))
    //    {
    //        SceneManager.LoadScene(0);
    //    }
    //}
}
