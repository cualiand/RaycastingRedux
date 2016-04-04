using UnityEngine;
using System.Collections;

public class catMouseManager : MonoBehaviour {

    public Transform mouse;
    public Transform cat;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Ray animalRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHitInfo = new RaycastHit();

        if (Physics.Raycast(animalRay, out rayHitInfo, 1000f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Transform newMouse = (Transform)Instantiate(mouse, rayHitInfo.point, Quaternion.identity);
                listOfAnimals.listOfMice.Add(newMouse);
                Debug.Log("mouse added");
            }
            if (Input.GetMouseButtonDown(1))
            {
                Transform newCat = (Transform)Instantiate(cat, rayHitInfo.point, Quaternion.identity);
                listOfAnimals.listOfCats.Add(newCat);
                Debug.Log("cat added");
            }
        }
	}
}
