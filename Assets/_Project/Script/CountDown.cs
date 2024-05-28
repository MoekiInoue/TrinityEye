using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;


public class CountDown : MonoBehaviour
{
    public float time = 0f;
    private bool isTimeuUp = false;
    public Fadeout Fadeout;
    public PlayableDirector director;
    public OVRPlayerController characterController;
    public ChangeTheCharactor changeTheCharactor;
    public GameObject filter;
    public GameObject filter2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeuUp == false)
        {
            time -= Time.deltaTime;
        }

        if (time < 0f && isTimeuUp == false)
        {
            TimeOver();
            time = 0f;
            isTimeuUp = true;
        }
        
    }

    public void TimeOver()
    {
        Debug.Log("time over ---------------");
        Fadeout.enabled = true;
        director.Play();
        characterController.enabled = false;
        changeTheCharactor.enabled = false;
        filter.SetActive(false);
        filter2.SetActive(false);

    }
}
