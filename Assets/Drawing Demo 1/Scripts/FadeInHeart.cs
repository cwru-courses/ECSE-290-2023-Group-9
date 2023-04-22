using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FadeInHeart : MonoBehaviour
{

    private PlayableDirector director;
    public GameObject heartTimeline;
    private bool firstTime = true;


    // Start is called before the first frame update
    private void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.played += Director_Played;
        director.stopped += Director_Stopped;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void Director_Stopped(PlayableDirector obj)
    {
        heartTimeline.SetActive(true);
    }


    private void Director_Played(PlayableDirector obj)
    {
        heartTimeline.SetActive(false);
    }

    public void StartHeartTimeline()
    {
        if (CheckScript.drawing_3_Complete && firstTime)
        {
            firstTime = false;
            director.Play();
        }
    }
}
