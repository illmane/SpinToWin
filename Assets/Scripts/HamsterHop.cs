using UnityEngine;

public class HamsterHop : MonoBehaviour
{
    private Animator anim;
    private bool FinishedAnimation = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ManageRunAnimations();
        print(FinishedAnimation);
    }

    private void ManageRunAnimations()
    {
        if (WheelGameManager.Instance.angularVelocity > 10 && FinishedAnimation == true || WheelGameManager.Instance.angularVelocity < -10 && FinishedAnimation == true)
        {
            anim.SetTrigger("Slow_Run");
            FinishedAnimation = false;
        }
        else if (WheelGameManager.Instance.angularVelocity < 10 && WheelGameManager.Instance.angularVelocity > 0.1 || WheelGameManager.Instance.angularVelocity > -10 && WheelGameManager.Instance.angularVelocity < 0.1)
        {
            anim.SetBool("IsStill", true);
            FinishedAnimation = true;

        }
    }

    public void finishAnimation()
    {
        FinishedAnimation = true;
    }
}
