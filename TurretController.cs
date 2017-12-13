using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TurretController : MonoBehaviour {

    public GameObject bullet;

    public Vector3 mouse_pos;
    public Vector3 object_pos;
    public Vector3 new_pos;
    public float angle;
    public Transform target;
	public Texture2D Cursor;

    // Use this for initialization


	// Update is called once per frame
	void FixedUpdate () {

        mouse_pos = Input.mousePosition;
        mouse_pos.z = -15f;
        object_pos = Camera.main.WorldToScreenPoint(transform.position);

        new_pos.x = mouse_pos.x - object_pos.x;
        new_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(new_pos.y, new_pos.x) * Mathf.Rad2Deg;
        print(angle);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle -90f)));

		if (Input.GetMouseButton(0) || Input.GetKey("space"))
        {
			// ShootBullet();
            GameObject obj = (GameObject)Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            obj.transform.Rotate(0, 0, Random.Range(-5, 5));

        }
		}

		void OnGUI() {
		GUI.DrawTexture(new Rect(Input.mousePosition.x, -(Input.mousePosition.y)+350, Cursor.width, Cursor.height), Cursor);
		}
    }


