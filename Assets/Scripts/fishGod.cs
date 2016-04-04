using UnityEngine;
using System.Collections;
using System.Collections.Generic; // need generic to use lists

public class fishGod : MonoBehaviour {  //creates and commands the fish

    public fish fishPrefab;
    List<fish> listOfFish = new List<fish>();

	// Use this for initialization
	void Start () {
        while (listOfFish.Count <= 25)
        {
            fish newFish = (fish)Instantiate(fishPrefab, Random.insideUnitSphere * 10f, Random.rotation);
            listOfFish.Add(newFish);
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (fish thisFish in listOfFish)
            {
                thisFish.destination = Random.insideUnitSphere * 25f;
            }
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit RayHitInfo = new RaycastHit();

        if (Physics.Raycast(ray, out RayHitInfo, 1000f))
        {
            if (Input.GetMouseButton(1))
            {
                foreach (fish thisFish in listOfFish)
                {
                    thisFish.destination = RayHitInfo.point;
                }
            }
        }


    }
}
