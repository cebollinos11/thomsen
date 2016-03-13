using UnityEngine;
using System.Collections;

public class presentationscript : MonoBehaviour {

    public GameObject name;
    public GameObject thomsen;
    int status;

	// Use this for initialization
	void Start () {

        name.SetActive(false);
        thomsen.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.anyKeyDown)
        {
            if (status == 2)
            {
                Application.LoadLevel(1);
            }

            if (status == 1)
            {
                status = 2;
                name.SetActive(true);
                thomsen.SetActive(true);
            }

            if (status == 0)
            {
                status = 1;
                name.SetActive(true);
            }


        }
	
	}
}
