using System.Collections;
using System.Threading;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static PointsManager Instance;
    public static float TotalPoints;
    public float AnchorPoints;
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

        TeleporterScript.OnTeleport += CalcualtePoints;
    }

    void Start()
    {
        TotalPoints = 0;
    }

    void FixedUpdate()
    {
        CountSeconds();
    }

    public void AddPoint(float amount)
    {
        AnchorPoints += amount;
    }

    private void CountSeconds()
    {
        if (Timer <= 0f)
        {
            secondsCounter += 1;

            Timer = TimerAmount;
        }
        else if (Timer > 0f)
        {
            Timer -= Time.deltaTime;
        }
    }

    private void CalcualtePoints()
    {
        TotalPoints = (1f/secondsCounter)*100 + AnchorPoints;
    }
}
