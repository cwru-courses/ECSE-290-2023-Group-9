using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Dialog, Puzzle}
public class SceneController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerController;

    GameState state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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


