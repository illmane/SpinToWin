using System.Collections;
using System.Threading;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static PointsManager Instance;
    public float TotalPoints;
    public float TimerAmount;
    private float Timer;

    private int secondsCounter;

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

    void Start()
    {
        TotalPoints = 0;
    }

    void FixedUpdate()
    {
        CountSeconds();
    }

    public void AddPoint(int amount)
    {
        TotalPoints += amount;
    }

    private void CountSeconds()
    {
        if (Timer <= 0f)
        {
            secondsCounter += 1;
            print(secondsCounter);

            Timer = TimerAmount;
        }
        else if (Timer > 0f)
        {
            Timer -= Time.deltaTime;
        }
    }
}
