using UnityEngine;
using System.Collections;
//when sphere is able to see cylinder, sphere should grow with anger
public class hideAndSeek : MonoBehaviour {

    public Transform cylinder;
    
	
	// Update is called once per frame
	void Update () {
        Ray losRay = new Ray(transform.position, (cylinder.position - transform.position));

        RaycastHit rayHitInfo = new RaycastHit();

        //calculate distance 
        float distance = (cylinder.position - transform.position).magnitude;

        if (Physics.Raycast(losRay, out rayHitInfo, distance)) {
            if (rayHitInfo.collider.tag == "Cylinder") //time for anger
            {
                transform.localScale *= 1.01f;
            }
          
        }
	}
}
