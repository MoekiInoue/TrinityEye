using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class ColliderChecker1 : MonoBehaviour
{
    public GameObject[] targets;
    public List< Collider> targetColliders = new List<Collider>();
    public OVRPlayerController characterController;
    public ChangeTheCharactor changeTheCharactor;
    public Fadeout Fadeout;
    public PlayableDirector director;
    public GameObject timer;
    public GameObject cameraRigObj;
    public GameObject filter;
    public GameObject filter2;

    void Start()
    {
        foreach (GameObject obj in targets )
        {
            targetColliders.Add(obj.GetComponentInChildren<Collider>());
        }
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetColliders.Contains(other))
        {
            other.GetComponentInParent<Rigidbody>().useGravity = false;
            other.GetComponent<Collider>().enabled = false;

            targetColliders.Remove(other);
            if (targetColliders.Count() <= 0)
            {
                // クリア処理
                Debug.Log("クリアーーーーーーーーーーーーーーーーーー");
                characterController.enabled = false;
                changeTheCharactor.enabled = false;
                Fadeout.enabled = true;
                director.Play();
                timer.SetActive(false);
                cameraRigObj.transform.localPosition = new Vector3(-0.69f, -0.97f, -0.32f);
                filter.SetActive(false);
                filter2.SetActive(false);

            }
        }
    }
}
