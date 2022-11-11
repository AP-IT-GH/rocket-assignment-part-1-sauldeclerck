using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveObjectMin : MonoBehaviour
{
    public Text Text;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PointCounter.points -= 10;
            Text.text = PointCounter.points.ToString();
            Destroy(gameObject);
        }
    }
}
