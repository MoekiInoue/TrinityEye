using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkSound : MonoBehaviour
{
    public AudioClip walksound1;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vectorL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp))
        {
            //‰¹(sound1)‚ð–Â‚ç‚·
            audioSource.PlayOneShot(walksound1);
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown))
        {
            audioSource.PlayOneShot(walksound1);
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft))
        {
            audioSource.PlayOneShot(walksound1);
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight))
        {
            audioSource.PlayOneShot(walksound1);
        }
    }
}
