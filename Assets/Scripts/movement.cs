using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{

    public float detectDistance = 3f;
    public float speed = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = transform.right * speed + Physics.gravity;

        Ray moveRay = new Ray(transform.position, transform.right);
        Debug.DrawRay(transform.position, transform.right * detectDistance, Color.red);

        if (Physics.SphereCast(moveRay, .5f, detectDistance)) {
            Debug.Log("detected");
            float turnRandNum = Random.Range(0f, 1f);
            if (turnRandNum < .5f)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            if (turnRandNum > .5f)
            {
                transform.Rotate(0f, -90f, 0f);
            }
        }

    }

}