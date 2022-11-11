using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevelOnTrigger : MonoBehaviour
{
    public string LevelToLoad;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            PointCounter.totalpoints += PointCounter.points;
            PointCounter.points = 0;
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
