using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Vector2 gravity;
    [SerializeField] Vector3 movementForce;
    public bool jumping = false;
    public bool falling = false;
    public bool left = false;
    public bool right = false;
    public bool npcZone = false;
    public bool canMove = true;
    public bool talking = false;
    public GameObject nPC;
    public float timePressed = 0;
    [SerializeField] float nextTime =1f;
    [SerializeField] CameraFollow cam;
    /*public float speed = 0f;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float acceleration = 10;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        
        if (Input.GetKey("z"))
        {
            if (npcZone == true && nPC.GetComponent<NPCManager>().optLock == false ) //NPC INTERACTION
            {
                if (talking == false && timePressed == 0) //INITIAL TRIGGER
                {
                    talking = true;
                    //nPC.GetComponent<DialgoueTrigger>().TriggerDialogue();
                    nPC.GetComponent<NPCManager>().Talk();
                    timePressed = Time.time;
                }
                else if (talking == true && Time.time > timePressed + nextTime)
                {
                    timePressed = Time.time;
                    FindObjectOfType<DialogueManager>().DisplayNextSentence();
                }
            }
            
            Debug.Log(timePressed);

        }
    }

    void FixedUpdate()
    {

        if (Input.GetKey("escape"))
        {
            Debug.Log("quit");
            Application.Quit();
        }
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("SampleScene");
        }


        if (talking == false)
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
                right = true;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                if (right == true)
                {
                    right = false;
                    cam.frameboi = 0;
                }
                
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.GetComponent<Rigidbody>().AddForce(-movementForce.x * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                left = true;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                if (left == true)
                {
                    left = false;
                    cam.frameboi = 0;
                }

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

    
}
