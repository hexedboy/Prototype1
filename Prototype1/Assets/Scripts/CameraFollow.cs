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

        transform.LookAt(target);
    }
}
