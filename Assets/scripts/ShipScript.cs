using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

    private Rigidbody R;
    public float ForwardSpeed;
    public float RotSpeed;
    public float VerticalSpeed;
    public int Gears;
    private int CurrentGear;
    public GameObject Model;

    private float CurrentForwardSpeed;
    public GameObject Particles;

    int turbo;

	// Use this for initialization
	void Start () {

        R = GetComponent<Rigidbody>();

        transform.rotation = Quaternion.identity;

        CurrentForwardSpeed = 0f;

        CurrentGear = 2;
        ManageGears();
        turbo = 1;

       
	}
	
	// Update is called once per frame
	void Update () {


        Model.transform.eulerAngles = new Vector3(-R.velocity.y, Model.transform.eulerAngles.y, transform.eulerAngles.z-R.angularVelocity.y*100);

        if (Input.GetKeyDown(KeyCode.Space)) {
            turbo = 10;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            turbo = 1;
        }
        	
	}

    public void GoUpDown(float dir)
    {
        R.AddForce(transform.up * VerticalSpeed * dir * Time.deltaTime * 100f);

        Debug.Log("pushing down");
        
        
    
    }

    public void Accelerate(float dir) {        

        CurrentForwardSpeed = CurrentForwardSpeed + dir*ForwardSpeed*0.1f;
        if (CurrentForwardSpeed > ForwardSpeed) CurrentForwardSpeed = ForwardSpeed;
        if (CurrentForwardSpeed < -ForwardSpeed * 0.1f) CurrentForwardSpeed = -ForwardSpeed * 0.1f;

        Debug.Log(CurrentForwardSpeed);

    }
    public void ManageGears()
    {
        if (CurrentGear > 1)
        {
            CurrentForwardSpeed = ForwardSpeed;
            
        }

        if (CurrentGear == 1)
        {
            CurrentForwardSpeed = ForwardSpeed * 0.5f;
            Particles.SetActive(true);
        }


        if (CurrentGear < 1) {
            CurrentForwardSpeed = 0;
            Particles.SetActive(false);
        }

        
    }
    public void IncreaseSpeed() {

        CurrentGear++;
        if (CurrentGear > Gears) { CurrentGear = Gears; }


        ManageGears();
    
    
    }

    public void DecreaseSpeed() {
        CurrentGear--;
        if (CurrentGear < 0) { CurrentGear = 0; }

        ManageGears();
    }

    public void RotateX(float dir)
    {

        R.AddTorque(transform.up * RotSpeed * dir * Time.deltaTime * 100f);

    }

    public void RotateZ(float dir)
    {

        R.AddTorque(transform.right * RotSpeed * dir * Time.deltaTime * 100f);

    }

    public void RotateY(float dir)
    {

        R.AddTorque(transform.forward * RotSpeed * dir * Time.deltaTime * 100f);

    }

    void FixedUpdate()
    {
        R.AddForce(transform.forward * CurrentForwardSpeed * Time.deltaTime * 100f *  turbo);
        
        
    }
}
