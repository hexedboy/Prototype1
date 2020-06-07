using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public Transform Player;
    public Camera Cam;

    private float distance;
    //private float posZ;
    [SerializeField] float maxDist;
    [SerializeField] float smoothingZ;
    [SerializeField] float zOffset;
    public Vector2
        Margin,
        Smoothing;

    public BoxCollider Bounds;

    private Vector3
        _min,
        _max;

    public bool IsFollowing { get; set; }


    public void Start()
    {
        Cam = GetComponent<Camera>();
        _min = Bounds.bounds.min;
        _max = Bounds.bounds.max;
        IsFollowing = true;
    }

    public void FixedUpdate()
    {
       

        var x = transform.position.x;
        var y = transform.position.y;
        var posZ = transform.position.z;

        /*if (IsFollowing)
        {*/
        //distance = Player.transform.position.z - Cam.transform.position.z;
        //if (distance > maxDist)
        //{
            posZ = Mathf.Lerp(posZ, Player.position.z+zOffset, smoothingZ);
        //}

        if (Mathf.Abs(x - Player.position.x) > Margin.x)
            x = Mathf.Lerp(x, Player.position.x, Smoothing.x * Time.deltaTime);

        if (Mathf.Abs(y - Player.position.y) > Margin.y)
            y = Mathf.Lerp(y, Player.position.y, Smoothing.y * Time.deltaTime);
        //}

        var cameraHalfWidth = Cam.orthographicSize * ((float)Screen.width / Screen.height);

        x = Mathf.Clamp(x, _min.x + cameraHalfWidth, _max.x - cameraHalfWidth);
        y = Mathf.Clamp(y, _min.y + Cam.orthographicSize, _max.y - Cam.orthographicSize);
        //posZ = Mathf.Clamp(posZ, _min.y + Cam.orthographicSize, _max.y - Cam.orthographicSize);

        transform.position = new Vector3(x, y, posZ);
    }
}
