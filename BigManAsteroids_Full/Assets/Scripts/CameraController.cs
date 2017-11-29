using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject ship; //attach ship to follow here 
    public Camera shipcamera; //attach camera to script here
    public float ZoomLevel; //this must be more negative for further away
    public float ZoomMultiplier;
    public float MaxZoom;
    public float MinZoom;

    // Use this for initialization
    void Start()
    {
        shipcamera.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //CAMERA FOLLOWS SHIP:
        //Camera position = GameObject ship's x pos and y pos. (Will follow the ship) -leo
        transform.position = new Vector3(ship.transform.position.x, ship.transform.position.y, -15.0f );

        //CAMERA ZOOMS WITH SCROLLWHEEL:
        //zoomlevel updated every frame depending on whether mouse is scrolling up or down -leo
        ZoomLevel = ZoomLevel + ((Input.GetAxis("Mouse ScrollWheel")) * ZoomMultiplier);

        //SET MAX ZOOMS
        if (ZoomLevel > -MinZoom)
        {
            ZoomLevel = -MinZoom;
        }
        else if (ZoomLevel < -MaxZoom)
        {
            ZoomLevel = -MaxZoom;
        }

        //this changed the zoom of the camera. if zoom level is not negative, it does not work -leo
        shipcamera.orthographicSize = -(ZoomLevel);

    }
}
