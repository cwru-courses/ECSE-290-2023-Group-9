using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        // Find the game object by name
        GameObject obj = GameObject.Find("Background music");

        // If the object doesn't exist, create it
        if (obj == null)
        {
            // Load the prefab from the Resources folder
            GameObject prefab = Resources.Load<GameObject>("Prefabs/Background music");

            // Instantiate the prefab and assign it to the obj variable
            obj = Instantiate(prefab);

            // Rename the object to match its original name
            obj.name = "Background music";
        }
    }

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
            SceneManager.LoadScene(sceneName: "Start");
            Debug.Log("Quit Pressed!");
        }

        //FOR DEV USE! OR WINDOWS BUILD USE
        if (Input.GetKeyDown(KeyCode.U))
        {
            Application.Quit();
            Debug.Log("Quit Pressed!");
        }
    }

}
