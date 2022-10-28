using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class moveRocket : MonoBehaviour
{
    Transform target;
    public float forwardSpeed = 0.1f;
    public int rightTurnSpeed = 2;
    public int leftTurnSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = target.GetComponent<Rigidbody>();
        if (target.position.y < 0)
        {
            target.position.Set(target.position.x, 0f, target.position.z);
        }
        if (Input.GetKey("space"))
        {
                transform.Translate(0, forwardSpeed, 0);
        }
        else
        {
            
        }
        if (Input.GetKey("left"))
        {
            if (leftTurnSpeed > 0)
            {
                transform.Rotate(new Vector3(0, 0, leftTurnSpeed));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -leftTurnSpeed));
            }
        }
        if (Input.GetKey("right"))
        {
            if (rightTurnSpeed > 0)
            {
                transform.Rotate(new Vector3(0, 0, -rightTurnSpeed));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, rightTurnSpeed));
            }
        }
    }

}
