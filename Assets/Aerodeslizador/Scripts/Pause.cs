using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    //[SerializeField] int sceneIndex;
    [SerializeField] GameObject panelPause;

    bool paused = false;
    // Update is called once per frame

    private void Awake()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ChangePaused();
            //panelPause.SetActive(true);
            
        }
    }

    public void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            panelPause.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void LoadNextScene(int sceneIndex)
    {

        SceneManager.LoadScene(sceneIndex);
    }
}
