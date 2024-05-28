using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharactor : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;

    // Start is called before the first frame update
    void Start()
    {
        Player1.SetActive(true);
        Player2.SetActive(false);
        Player3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Player1.SetActive(false);
            Player2.SetActive(true);

        }
    }
}
