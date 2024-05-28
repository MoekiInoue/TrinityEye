using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChecker : MonoBehaviour
{
    public GameObject[] targets;
    //public int counter = 0;
    private List< Collider> targetColliders = new List<Collider>();


    void Start()
    {
        foreach (GameObject obj in targets )
        {
            targetColliders.Add(obj.GetComponentInChildren<Collider>());
        }

        //counter = targets.Length;
        //targetColliders = new Collider[targets.Length];
        //for (int i = 0; i < targets.Length; i++)
        //{
        //    targetColliders[i] = targets[i].GetComponentInChildren<Collider>();
        //}
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetColliders.Contains(other))
        {



            targetColliders.Remove(other);
            if (targetColliders.Count() <= 0)
            {
                Debug.Log("ƒNƒŠƒA");
                NazoChacker.Crear();
            }
        }
    }
}
