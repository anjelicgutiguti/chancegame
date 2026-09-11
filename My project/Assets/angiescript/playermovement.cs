using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 100f;

    Rigidbody myRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRB = GetComponent<Rigidbody>();


    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        myRB.AddForce(movement * speed * Time.deltaTime);

        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        float h = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A)) { h = 1; }

        if (Input.GetKey(KeyCode.D)) { h = -1; }

        float v = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W)) { v = -1; }

        if (Input.GetKey(KeyCode.S)) { v = 1; }
    }
}
