using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] Vector3 movementForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("z"))
        {
            this.GetComponent<Rigidbody>().AddForce(0, jumpForce, 0, ForceMode.Impulse);
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
    }

    
}
