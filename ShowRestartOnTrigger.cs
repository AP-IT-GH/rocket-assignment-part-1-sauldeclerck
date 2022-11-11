using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRestartOnTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject victory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            player.SetActive(false);
            victory.SetActive(true);
        }
    }
}
