using UnityEngine;
using System.Collections;

public class mouseFishFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit RayHitInfo = new RaycastHit();

        if (Physics.Raycast(ray, out RayHitInfo, 1000f))
        {
            if (Input.GetMouseButton(0))
            {
                
            }
        }
	}
}
