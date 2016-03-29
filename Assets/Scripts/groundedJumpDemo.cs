using UnityEngine;
using System.Collections;

public class groundedJumpDemo : MonoBehaviour {

    public float jumpStrength = 10f;
    bool grounded = false; //check for grounded


    void Update()
    {
        Ray groundedRay = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(groundedRay, 1.25f)) {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    // Update is called once per frame

    void FixedUpdate () { //for physic stuffs
	    if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
               GetComponent<Rigidbody>().velocity += Vector3.up * jumpStrength;
        }
	}
    
}
