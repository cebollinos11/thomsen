using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

    private ShipScript SS; //ship Script

    public float sandwichTime;

    public GameObject GliderGO;
    public GameObject SandwichGO;

    public AudioClip TurnIntoSandwichSFX;
    public AudioClip TurnIntoGliderSFX;
    public AudioClip soundFrancesco;

    private GameObject Francesco;
    

	// Use this for initialization
	void Start () {

        SS = GetComponent<ShipScript>();

        SandwichGO.SetActive(false);

        Francesco = GameObject.FindGameObjectWithTag("Francesco");
        Francesco.SetActive(false);

       
        
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

        AudioManager.PlaySpecific(TurnIntoSandwichSFX);
        AudioManager.PlaySpecific(soundFrancesco);

        SandwichGO.SetActive(true);
        GliderGO.SetActive(false);
        Francesco.SetActive(true);
        yield return new WaitForSeconds(sandwichTime);
        AudioManager.PlaySpecific(TurnIntoGliderSFX);
        GliderGO.SetActive(true);
        SandwichGO.SetActive(false);
        Francesco.SetActive(false);
    
    }

    void OnCollisionEnter(Collision other) {

        Debug.Log(other.gameObject.name);

        if (other.gameObject.tag == "Missile")
        {
            TurnIntoSandwich();
        }
    
    }
  
}
