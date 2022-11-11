using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RemoveObjectPlus : MonoBehaviour
{
    public Text Text;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PointCounter.points += 10;
            Text.text = PointCounter.points.ToString();
            Destroy(gameObject);
        }
    }
}
