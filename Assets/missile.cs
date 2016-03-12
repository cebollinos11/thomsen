using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour {

    public float speed;
    Rigidbody rb;

    public float lifeTime;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
	}

    void Explode() {

        Debug.Log("EXPLO");

        Destroy(gameObject);
    
    }

    void FixedUpdate()
    {
        

        

        lifeTime -= Time.deltaTime;
        if (lifeTime < 0)
        {
            Explode();
        }

    } 
}
