using UnityEngine;
using System.Collections;

public class presentationscript : MonoBehaviour {

    public GameObject name;
    public GameObject thomsen;
    public GameObject attention;
    int status;

	// Use this for initialization
	void Start () {

        name.SetActive(false);
        thomsen.SetActive(false);
        attention.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.anyKeyDown)
        {
            if (status == 3)
            {
                Application.LoadLevel(1);
            }

            if (status == 2)
            {
                status = 3;
                thomsen.SetActive(false);
                attention.SetActive(true);
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
