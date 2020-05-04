using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Vector2 gravity;
    [SerializeField] Vector3 movementForce;
    public bool jumping = false;
    public bool falling = false;
    /*public float speed = 0f;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float acceleration = 10;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void FixedUpdate()
    {
        if (Input.GetKey("z"))
        {
            this.GetComponent<Rigidbody>().AddForce(0, gravity.y, 0, ForceMode.Impulse);
            jumping = true;
        }
        else
        {
            jumping = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(movementForce.x * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(-movementForce.x * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, movementForce.z * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, -movementForce.z * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("x") /*&& speed > maxSpeed*/)
        {
            falling = true;
            // speed = speed - acceleration * Time.deltaTime;

            this.GetComponent<Rigidbody>().AddForce(0, gravity.x /*+ speed * Time.deltaTime*/ , 0, ForceMode.Acceleration);
           
        }
        else if (Input.GetKeyUp("x"))
        {
            falling = false;
        }
        //else if (Input.GetKeyUp("x"))
        //{
        //    speed = 0;
        // }
    }

    
}
