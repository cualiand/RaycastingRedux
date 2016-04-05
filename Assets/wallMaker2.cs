using UnityEngine;
using System.Collections;

public class wallMaker2 : MonoBehaviour {


    public Transform wallPiece;
  //  private int counter = 0;
    //public int counterNumber = 25;
    //public Transform pathmakerPrefab;
    //public Transform centerPiece;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 10; i++)
        {
            float randNum = Random.Range(0f, 1f);
            if (randNum < .5f)
            {
                Instantiate(wallPiece, transform.position, Quaternion.identity);
            }
            transform.Translate(0f, 0f, 3.22f);
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
