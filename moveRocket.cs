using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class moveRocket : MonoBehaviour
{
    Transform target;
    public float forwardSpeed = 7;
    public int rightTurnSpeed = 180;
    public int leftTurnSpeed = 180;
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
                transform.Translate(0, forwardSpeed * Time.deltaTime, 0);
        }
        else
        {
            
        }
        if (Input.GetKey("left"))
        {
            if (leftTurnSpeed > 0)
            {
                transform.Rotate(new Vector3(0, 0, leftTurnSpeed*Time.deltaTime));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -leftTurnSpeed * Time.deltaTime));
            }
        }
        if (Input.GetKey("right"))
        {
            if (rightTurnSpeed > 0)
            {
                transform.Rotate(new Vector3(0, 0, -rightTurnSpeed * Time.deltaTime));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, rightTurnSpeed * Time.deltaTime));
            }
        }
    }

}
