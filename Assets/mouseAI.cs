using UnityEngine;
using System.Collections;

public class mouseAI : MonoBehaviour {

    public Transform cat;
    public float escapeSpeed = 1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 directionToCat = (cat.position - transform.position);
        float angle = Vector3.Angle(directionToCat, transform.position);

        if (angle < 180f)
        {
            Ray mouseRay = new Ray(transform.position, directionToCat);
            RaycastHit mouseRayHitInfo = new RaycastHit();

            if (Physics.Raycast(mouseRay, out mouseRayHitInfo, 10f))
            {
                if (mouseRayHitInfo.collider.tag == "Cat")
                {
                    GetComponent<Rigidbody>().AddForce(-directionToCat.normalized * escapeSpeed);
                }
            }
        }
	}

}
