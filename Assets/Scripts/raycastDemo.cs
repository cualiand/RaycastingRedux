using UnityEngine;
using System.Collections;

public class raycastDemo : MonoBehaviour {


    public Transform sphere;

	// Update is called once per frame
	void Update () {
        //construct your ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //takes a pixel coord on screen, and generates a ray on it

        //initialize your raycast hit variable, tells you what you hit, where, etc
        RaycastHit rayHitInfo = new RaycastHit();

        //draw / visualize the raycast
        Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.yellow);

        //fire the raycast
        if (Physics.Raycast(ray, out rayHitInfo, 1000f)) { //ray, raycastinfo, and max distance. only runs if raycast hits something
            Debug.DrawRay(ray.origin, ray.direction * rayHitInfo.distance, Color.red);
            //sphere.position = rayHitInfo.point;
            if (Input.GetMouseButton(0)) {
                Transform newSphere = (Transform)Instantiate(sphere, rayHitInfo.point, Quaternion.identity);
                newSphere.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); // randomcolor
            }
           
        } 
        
	}
}
