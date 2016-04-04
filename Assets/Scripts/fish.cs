using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {

   public Vector3 destination;
   [SerializeField] float speed = 10f;
   // bool isMoving = true;
   [SerializeField] float stoppingDistance = .05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine(transform.position, destination, Color.yellow);
        transform.LookAt(destination);

        if ((destination - transform.position).magnitude > stoppingDistance)
        {
            //isMoving = true;
            Debug.Log("moving");
            transform.position += (destination - transform.position).normalized * Time.deltaTime * speed;
        }
        else
        {
            Debug.Log("not moving");
        }
        
	}
}
