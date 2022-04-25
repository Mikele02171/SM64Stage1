using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarScript : MonoBehaviour
{
     void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        SceneManager.LoadScene("LevelComplete");
    }
}
