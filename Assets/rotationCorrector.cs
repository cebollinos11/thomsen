using UnityEngine;
using System.Collections;

public class rotationCorrector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.localEulerAngles = new Vector3(0f,0f,transform.localEulerAngles.z); 
	
	}
}
