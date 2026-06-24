using UnityEngine;

public class InvinsibilityManager : MonoBehaviour
{
    private BoxCollider2D[] bcs;
    private bool IsInvincible = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcs = gameObject.GetComponents<BoxCollider2D>();
    }

    public void MakeInvinsible()
    {
        if (IsInvincible == false)
        {
            IsInvincible = true;

            foreach (BoxCollider2D bc in bcs)
            {
                bc.enabled = false;
            }
        }
    }
}
