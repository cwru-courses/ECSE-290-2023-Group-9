using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCamera : MonoBehaviour
{
    private Vector3 CameraPosition;
    public GameObject mainCam;

    public GameObject notebookSpot;
    public GameObject playerSpot;

    private static bool first;
    public DialogManager dM;
    public string[] drawTutorial;

    [Header("Page Flip Audio")]
    private AudioClip flipClip; //unserialized field
    [SerializeField] private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
        flipClip = audioSource.clip;
        audioSource.time = 1.05f;
        first = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NotebookMoment()
    {
        if (first)
        {
            dM.ShowDialog(drawTutorial);
            first = false;
        }
        mainCam.gameObject.transform.position = notebookSpot.gameObject.transform.position;
        MoveCamera.inNotebook = true;
        audioSource.Play();
    }

    public void PlayerMoment()
    {
        mainCam.gameObject.transform.position = playerSpot.gameObject.transform.position;
        MoveCamera.inNotebook = false;
        audioSource.Play();
    }
}
