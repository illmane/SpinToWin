using UnityEngine;

public class WheelGameManager : MonoBehaviour
{
    public static WheelGameManager Instance;
    public float angularSpeed;
    public float angularVelocity;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void getAngularVelocity(float wheelVelocity)
    {
        angularSpeed = Mathf.Abs(wheelVelocity);
        angularVelocity = wheelVelocity;
    }
}
