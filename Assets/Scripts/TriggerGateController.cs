using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGateController : MonoBehaviour
{
    [SerializeField]
    GameObject Gate;

    bool isOpened = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isOpened)
        {
            isOpened = true;
            Gate.transform.position += new Vector3(0,-7,6);
            Destroy(gameObject);


        }
    }
}
