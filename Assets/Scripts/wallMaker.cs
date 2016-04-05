using UnityEngine;
using System.Collections;

public class wallMaker : MonoBehaviour {

    public Transform wallPiece;
    private int counter = 0;
    public int counterNumber = 25;
    public Transform pathmakerPrefab;
    public Transform centerPiece;
    public Vector3 startingPoint;

	// Use this for initialization
	void Start () {
        startingPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (counter < counterNumber)
        {
            float randNum = Random.Range(0f, 1f);

            if ((transform.position - centerPiece.position).magnitude >= 18f)
            {
                Debug.Log("Flipped");
                float randNum2 = Random.Range(0f, 1f);
                transform.position = startingPoint + new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            }
            if (randNum < .1f)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            else if (randNum > .1f && randNum < .2f)
            {
                transform.Rotate(0f, -90f, 0f);
            }
            if (randNum > 1f)
            {
                Instantiate(pathmakerPrefab, transform.position, Quaternion.identity);
            }
            Instantiate(wallPiece, transform.position, transform.rotation);
            transform.Translate(1.25f, 0f, 0f);
            counter++;

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
