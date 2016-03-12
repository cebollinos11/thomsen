using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

    private ShipScript SS; //ship Script

    public float sandwichTime;

    public GameObject GliderGO;
    public GameObject SandwichGO;

	// Use this for initialization
	void Start () {

        SS = GetComponent<ShipScript>();

        SandwichGO.SetActive(false);

       
        
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

        if (Input.GetKeyDown(KeyCode.O)) {
            TurnIntoSandwich();
        }

	
	}

    void TurnIntoSandwich() {

        StartCoroutine(Convert());
    
    }

    IEnumerator Convert() {
        SandwichGO.SetActive(true);
        GliderGO.SetActive(false);
        yield return new WaitForSeconds(sandwichTime);
        GliderGO.SetActive(true);
        SandwichGO.SetActive(false);
    
    }
  
}
