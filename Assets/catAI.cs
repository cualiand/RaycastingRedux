using UnityEngine;
using System.Collections;

public class catAI : MonoBehaviour {

    public Transform mouse;
    public float chaseSpeed = 1000f;

	
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (mouse == null)
        {
            return;
        }
        Vector3 directionToMouse = (mouse.position - transform.position);
        float angle = Vector3.Angle(directionToMouse, transform.position);
        
        if (angle < 120f)
        {
            Debug.Log("mouse seen");
            Ray catRay = new Ray(transform.position, directionToMouse);
            RaycastHit catRayHitInfo = new RaycastHit();

            if (Physics.Raycast(catRay, out catRayHitInfo, 1000f))
            {
                if (catRayHitInfo.collider.tag == "Mouse")
                {
                    if (catRayHitInfo.distance <= 500f)
                    {
                        Debug.Log("mouse chased");
                        GetComponent<Rigidbody>().AddForce(directionToMouse.normalized * chaseSpeed);
                    }
                    if (catRayHitInfo.distance <= 2f)
                    {
                        Debug.Log("mouse caught!");
                        Destroy(mouse.gameObject);
                    }
                }
            }
        }
	}
}
