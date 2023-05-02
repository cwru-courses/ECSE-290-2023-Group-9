using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class thankyou : MonoBehaviour
{
    public TextMeshProUGUI textComponent1;
    public TextMeshProUGUI textComponent2;
    public TextMeshProUGUI textComponent3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivateTextAfterDelay1());
        StartCoroutine(ActivateTextAfterDelay2());
        StartCoroutine(ActivateTextAfterDelay3());
        StartCoroutine(end1());
        StartCoroutine(end2());
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

    IEnumerator ActivateTextAfterDelay1()
    {
        yield return new WaitForSeconds(3.0f);
        textComponent1.gameObject.SetActive(true);
    }

    IEnumerator ActivateTextAfterDelay2()
    {
        yield return new WaitForSeconds(5f);
        textComponent2.gameObject.SetActive(true);
    }

    IEnumerator ActivateTextAfterDelay3()
    {
        yield return new WaitForSeconds(8.0f);
        textComponent1.gameObject.SetActive(false);
        textComponent2.gameObject.SetActive(false);
        textComponent3.gameObject.SetActive(true);
    }

    IEnumerator end1()
    {
        yield return new WaitForSeconds(13.5f);
        textComponent1.gameObject.SetActive(false);
        textComponent2.gameObject.SetActive(false);
        textComponent3.gameObject.SetActive(false);
    }

    IEnumerator end2()
    {
        yield return new WaitForSeconds(16.5f);
        SceneManager.LoadScene("Start");
        //Application.LoadLevel(0);
    }
}



