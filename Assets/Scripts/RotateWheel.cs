using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class RotateWheel : MonoBehaviour
{
    public float angularChangeInDegrees;
    public float maxAngularVelocity;
    private Rigidbody2D rb;

    private float InitialLocalPosition;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        InitialLocalPosition = transform.localPosition.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        InputPlayerRotation();
        gameObject.transform.localPosition = new Vector2(InitialLocalPosition, transform.localPosition.y);
    }

    private void InputPlayerRotation()
    {
        var impulse = (Input.GetAxis("Horizontal") * Mathf.Deg2Rad) * rb.inertia;

        if (Input.GetAxis("Horizontal") > 0)
        {
            if(rb.angularVelocity < -maxAngularVelocity) {
            rb.angularVelocity = -maxAngularVelocity;
        }
            WheelGameManager.Instance.getAngularVelocity(rb.angularVelocity);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            if(rb.angularVelocity > maxAngularVelocity) {
                rb.angularVelocity = maxAngularVelocity;
            } 
            WheelGameManager.Instance.getAngularVelocity(rb.angularVelocity);
        }
        rb.AddTorque(-impulse*angularChangeInDegrees, ForceMode2D.Impulse);
    }
}
