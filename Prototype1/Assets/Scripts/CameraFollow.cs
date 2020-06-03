using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothSpeed = 0.125f;
    [SerializeField] Vector3 followOffset;
    [SerializeField] Vector2 cameraTilt;
    [SerializeField] Vector3 hangBackJump;
    [SerializeField] Vector3 hangBackFall;
    [SerializeField] Vector3 leftOffset;
    [SerializeField] Vector3 rightOffset;
    public float frameboi = 0;
    [SerializeField] float framerateboi = 0.2f;

    private void Update()
    {
        
       
    }

    private void FixedUpdate()
    {
      
        if (target.GetComponent<CharacterController>().jumping == false && target.GetComponent<CharacterController>().falling == false)
        {
            Vector3 desiredPos = target.position + followOffset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;
        }
        else if (target.GetComponent<CharacterController>().jumping == true)
        {
            Vector3 desiredPos = target.position + followOffset + hangBackJump;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;

        }
        else if (target.GetComponent<CharacterController>().falling == true)
        {
            Vector3 desiredPos = target.position + followOffset + hangBackFall;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;
           
        }
        if (target.GetComponent<CharacterController>().right == true)
        {
            //frameboi = 0;
            frameboi += Time.deltaTime * framerateboi;
           // rightOffset.x = Mathf.Clamp( followOffset.x - frameboi, -10 , 0);
           // rightOffset.z = Mathf.Clamp(frameboi, -5, 5);
            Vector3 desiredPos = target.position + followOffset + rightOffset;
            //desiredPos.x = Mathf.Clamp(desiredPos.x - frameboi, -1, 0);
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;
        }
        if (target.GetComponent<CharacterController>().left == true)
        {
            //frameboi = 0;
            //frameboi += Time.deltaTime * framerateboi;
            //rightOffset.x = Mathf.Clamp(followOffset.x + frameboi, 0, 10);
           // rightOffset.z = Mathf.Clamp(frameboi, -5, 5);
            Vector3 desiredPos = target.position + followOffset + leftOffset;
            //desiredPos.x = Mathf.Clamp(desiredPos.x - frameboi, -1, 0);
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;
        }



        transform.LookAt(target);
    }
}
