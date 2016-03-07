using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

    private ShipScript SS; //ship Script

	// Use this for initialization
	void Start () {

        SS = GetComponent<ShipScript>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Horizontal") != 0) {
            SS.RotateX(Input.GetAxis("Horizontal"));
        
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            SS.GoUpDown(-Input.GetAxis("Vertical"));

        }

	
	}

  
}
