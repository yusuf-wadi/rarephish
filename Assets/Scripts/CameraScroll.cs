using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

    public float speed;
    float inputX;
    float inputZ;
    float original_size;
	// Use this for initialization
	void Start () {
		original_size = Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update () {
            inputX = Input.GetAxis("Horizontal");
            inputZ = Input.GetAxis("Vertical");

            if (inputX != 0)
                moveX();
         if (inputZ != 0)
                moveZ();
        if (Input.GetAxis("Mouse ScrollWheel") > 0 ) // forward
        {
            Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize - 1, 5);
        }
        else if ( Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize + 1, original_size);

        }

    }


        void moveZ()
        {
            transform.position += transform.up * inputZ * speed * Time.deltaTime;
        }


        void moveX()
        {
            transform.position += transform.right * inputX * speed * Time.deltaTime;
        }

}
