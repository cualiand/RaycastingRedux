using UnityEngine;
using System.Collections;

public class raycastMouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //get mouse input 
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseX = Input.GetAxis("Mouse X");

        //rotate camera based on mouse velocity
        transform.Rotate(-mouseY, mouseX, 0);

        //correct for rolling
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);

        //if click, lock and hide cursor
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //declare ray
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit rayHitInfo = new RaycastHit();
        if (Physics.Raycast(ray, out rayHitInfo, 1000f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                rayHitInfo.transform.localScale *= 0.9f;
            }
        }
        
        
	}
}
