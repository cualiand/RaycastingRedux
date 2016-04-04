using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class forestManager : MonoBehaviour {

    public Transform tree1;
    public Transform tree2;
    List<Transform> listOfTrees = new List<Transform>(); //you need to say new list after you create the list

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Ray treeRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHitInfo = new RaycastHit();

        if (Physics.Raycast(treeRay, out rayHitInfo, 1000f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Transform newTree1 = (Transform)Instantiate(tree1, rayHitInfo.point, Quaternion.identity);
                listOfTrees.Add(newTree1);
            }
            
            if (Input.GetMouseButtonDown(1))
            {
                Transform newTree2 = (Transform)Instantiate(tree2, rayHitInfo.point, Quaternion.identity);
                listOfTrees.Add(newTree2);
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            foreach (Transform tree in listOfTrees)
            {
                tree.transform.localScale += new Vector3(.1f, .1f, .1f);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            foreach (Transform tree in listOfTrees)
            {
                tree.transform.localScale += new Vector3(-.1f, -.1f, -.1f);
            }
        }
        
        

	}
}
