using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlaneController : MonoBehaviour 
{
    [SerializeField]
    private float power = 0.0f;
    [SerializeField]
    private float maxPower = 1000.0f;

    private Rigidbody rb;

    private Vector3 eulerAngleVelocity;
    

    public void Awake ()
    {
        rb = GetComponent<Rigidbody> ();
    }

    public void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            power += 100;
            if (power > maxPower)
            {
                power = maxPower;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            power -= 100;
            if (power < 0) 
            {
                power = 0;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            eulerAngleVelocity.x -= 100f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            eulerAngleVelocity.x += 100f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            eulerAngleVelocity.z += 100f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            eulerAngleVelocity.z -= 100f;
        }

        eulerAngleVelocity = Vector3.Lerp (eulerAngleVelocity, Vector3.zero, Time.deltaTime);
    }

    public void FixedUpdate ()
    {
        rb.AddRelativeForce (
            new Vector3 (0, power * 0.4f, power));

        rb.AddRelativeTorque(eulerAngleVelocity);
    }

    public void OnGUI ()
    {
        GUI.Label (
            new Rect(10,10,Screen.width, Screen.height),
            string.Format(
                "power: {0} / {1}\nrb.velocity.z: {2}\neulerAngleVelocity: {3}",
                power,
                maxPower,
                rb.velocity.z,
                eulerAngleVelocity
            )
        );
    }
}
