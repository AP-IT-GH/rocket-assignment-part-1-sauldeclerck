using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        PointCounter.totalpoints += PointCounter.points;
        PointCounter.points = 0;
        SceneManager.LoadScene(sceneName);
    }
}
