using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(12.5f);
        SceneManager.LoadScene("Credits");
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
        //if (Input.GetKeyDown(KeyCode.U))
        //{
        //    Application.Quit();
        //    Debug.Log("Quit Pressed!");
        //}
    }
}
