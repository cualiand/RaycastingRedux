using UnityEngine;
using System.Collections;


public class catAI : MonoBehaviour {

    //public Transform mouse;
    public float chaseSpeed = 1000f;
    //public AudioSource eatSound;

	
	
	// Update is called once per frame
	void FixedUpdate () { 
        
 
        foreach (Transform mice in listOfAnimals.listOfMice)
        {
            Vector3 directionToMouse = (mice.position - transform.position);
            float angle = Vector3.Angle(directionToMouse, transform.position);
            if (angle < 170f)
            {
                Debug.Log("mouse seen");
                Ray catRay = new Ray(transform.position, directionToMouse);
                RaycastHit catRayHitInfo = new RaycastHit();

                if (Physics.Raycast(catRay, out catRayHitInfo, 1000f))
                {
                    if (catRayHitInfo.collider.tag == "Mouse")
                    {
                        if (catRayHitInfo.distance <= 500f) //when cat sees mouse
                        {
                            Debug.Log("mouse chased");
                            GetComponent<Rigidbody>().AddForce(directionToMouse.normalized * chaseSpeed);
                        }
                        if (catRayHitInfo.distance <= 2f) //when cat touches mouse
                        {
                            Debug.Log("mouse caught!");
                            // eatSound.PlayOneShot(eatSound.clip, 1f);
                            Destroy(mice.gameObject);
                        }
                    }
                }
            }
        }
	}
}
