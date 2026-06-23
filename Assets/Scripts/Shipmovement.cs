using UnityEngine;

public class Shipmovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedMultiplier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetWheelSpeed();
    }

    private void GetWheelSpeed()
    {
        rb.linearVelocity = new Vector2(-WheelGameManager.Instance.angularVelocity * (1/speedMultiplier), rb.linearVelocityY);
    }
}
