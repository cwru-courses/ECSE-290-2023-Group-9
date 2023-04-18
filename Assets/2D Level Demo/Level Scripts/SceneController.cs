using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { FreeRoam, Dialog, Puzzle}
public class SceneController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerController;
    public static bool drawn = false;

    public static void setDrawn()
    {
        drawn = true;
    }
    GameState state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drawn)
        {
            SceneManager.LoadScene(sceneName: "End Scene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit Pressed!");
        }

        if (state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        } else if (state == GameState.Dialog)
        {

        } else if (state == GameState.Puzzle)
        {
        }
    }
}


