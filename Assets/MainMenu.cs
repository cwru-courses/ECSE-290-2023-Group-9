using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "level0Negative");
        BGmusic.instance.GetComponent<AudioSource>().Pause();
    }

    public void SwitchToStart()
    {
        SceneManager.LoadScene(sceneName: "Start");
    }

    public void SwitchToInstruction()
    {
        SceneManager.LoadScene(sceneName: "Instruction");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Successful Quit!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit Pressed!");
        }
    }

}
