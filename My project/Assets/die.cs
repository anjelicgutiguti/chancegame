using UnityEngine;

public class die : MonoBehaviour

{
    Rigidbody body;

    private float maxRandomForce;

    private float forcex , forcey , forcez;

    public int diceFace;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        maxRandomForce = 10f; // Set the maximum random force to be applied to the die
        forcex = Random.Range(-maxRandomForce, maxRandomForce); // Generate a random force in the x direction
        forcey = Random.Range(-maxRandomForce, maxRandomForce); 
        forcez = Random.Range(-maxRandomForce, maxRandomForce); 
        body.AddForce(new Vector3(forcex, forcey, forcez), ForceMode.Impulse); // Apply a random force to the die in a random direction
    } 

    private void Update ()
    {
        if (body != null)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                RollDice();
            }
        }
            
    }

    private void RollDice()
    {
        // Reset the die's position and rotation
        transform.position = new Vector3(0f, 1f, 0f);
        transform.rotation = Quaternion.identity;

        // Reset the die's velocity and angular velocity
        forcex = Random.Range(-maxRandomForce, maxRandomForce);
        forcey = Random.Range(-maxRandomForce, maxRandomForce);
        forcez = Random.Range(-maxRandomForce, maxRandomForce);

        // Apply the random force to the die
        body.AddForce(new Vector3(forcex, forcey, forcez), ForceMode.Impulse);
    }


    
}
