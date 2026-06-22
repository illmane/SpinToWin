using UnityEngine;

public class WheelGameManager : MonoBehaviour
{
    public static WheelGameManager Instance;
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
        angularVelocity = Mathf.Abs(wheelVelocity);
            
    }
}
