using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightVoice : MonoBehaviour
{

    public GameObject Right;
    public AudioClip Voice;
    AudioSource audioSource;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("item") == true && count == 0)
        {
            audioSource.PlayOneShot(Voice);
            count = 1;
        }
    }
}
