using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookswith : MonoBehaviour
{
    public GameObject bookshelf;
    public AudioClip Ugokuoto;
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
        if(other.CompareTag("book")==true && count == 0)
        {
            bookshelf.GetComponent<Animator>().enabled = true;
            audioSource.PlayOneShot(Ugokuoto);
            count = 1;
        }

        
      
    }
}
