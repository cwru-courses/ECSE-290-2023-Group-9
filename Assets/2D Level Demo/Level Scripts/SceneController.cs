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
        GameObject obj = GameObject.Find("Background music");
        // If the object exists, destroy it
        if (obj != null)
        {
            Destroy(obj);
        }
    }



    // Update is called once per frame
    void Update()
    {
        //if (drawn)
        //{
        //    SceneManager.LoadScene(sceneName: "End Scene");
        //}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: "Start");
            Debug.Log("Quit Pressed!");
        }
        //FOR DEV USE! OR WINDOWS BUILD USE
        //if (Input.GetKeyDown(KeyCode.U))
        //{
        //    Application.Quit();
        //    Debug.Log("Quit Pressed!");
        //}

        if (state == GameState.FreeRoam)
        {
            //playerController.HandleUpdate();
        } else if (state == GameState.Dialog)
        {

        } else if (state == GameState.Puzzle)
        {
        }
    }
}


