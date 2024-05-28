using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NazoChacker : MonoBehaviour
{
    private static int crearScore = 2;
    private static int nazoIndex = 0;
    public static AudioClip Akuoto;
    static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
    }

    public static void Crear()
    {
        if (++nazoIndex >= crearScore)
        {
            Debug.Log("‘S“ä‚ðƒNƒŠƒA‚µ‚½");

            audioSource.PlayOneShot(Akuoto);
            GameObject obj = GameObject.Find("TreasureChest");
            Destroy(obj);
            


        }
    }

}
