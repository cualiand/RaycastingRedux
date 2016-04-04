using UnityEngine;
using System.Collections;

public class wallMaker : MonoBehaviour {

    public Transform wallPiece;
    private int counter = 0;
    public int counterNumber = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (counter < counterNumber)
        {
            float randNum = Random.Range(0f, 1f);
            if (randNum < .25f)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            else if (randNum > .25f && randNum < .5f)
            {
                transform.Rotate(0f, -90f, 0f);
            }
            Instantiate(wallPiece, transform.position, Quaternion.identity);
            transform.Translate(5f, 0f, 0f);
            counter++;

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
