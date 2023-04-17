using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;
    public TextMeshProUGUI dialogText;

    

    public string[] lines;
    private int index;
    private bool speech;

    private int clicks;

    //public static DialogManager Instance {  get; private set; }

    //Audio Playing On Every Character
    [Header("Audio")]
    [SerializeField] private AudioClip dialogueTypingSoundClip;
    private AudioSource audioSource;

    private void Start()
    {
        speech = false;
        audioSource = this.gameObject.AddComponent<AudioSource>();
    }
    
    public void ShowDialog(string[] givenLine)
    {
        DoorZero.SetClickFalse(); 
        clicks = 0;
        dialogText.text = string.Empty;
        speech = true;
        lines = givenLine;
        index = 0;
        dialogBox.SetActive(true);
        StartCoroutine(TypeDialog());
    }


    // Update is called once per frame
    void Update()
    {
        if (speech) {
            if (Input.GetMouseButtonDown(0))
            {
                clicks++;
                if (dialogText.text == lines[index])
                {
                    NextLines();
                }
                else if (clicks >1)
                {
                    //Debug.Log("HERE");
                    StopAllCoroutines();
                    dialogText.text = lines[index];
                }
            }
        }
    }


    IEnumerator TypeDialog()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            int counter = 0;
            dialogText.text += c;
            yield return new WaitForSeconds(.06f);
            if (counter % 2 == 0)
            {
                audioSource.PlayOneShot(dialogueTypingSoundClip);
            }
            counter++;
        }
    }

    void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogText.text = string.Empty;
            StartCoroutine(TypeDialog());
        }
        else
        {
            dialogBox.SetActive(false);
            speech = false;
            DoorZero.SetClickTrue();
        }
    }

}
