using UnityEngine;

public class ResetRocket : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Finish")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            gameObject.transform.SetPositionAndRotation(new Vector3(4f, 0.5f, -2.5f), new Quaternion(0f,0f,0f,0f));
        }
    }
}