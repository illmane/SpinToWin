using System.Collections;
using UnityEngine;

public class InvinsibilityManager : MonoBehaviour
{
    private BoxCollider2D[] bcs;
    private bool IsInvincible = false;
    private SpriteRenderer[] Sps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcs = gameObject.GetComponents<BoxCollider2D>();
        Sps = gameObject.GetComponentsInChildren<SpriteRenderer>();
    }

    public void MakeInvinsible()
    {
        if (IsInvincible == false)
        {
            StartCoroutine(ShowInvincibility());
            IsInvincible = true;

            foreach (BoxCollider2D bc in bcs)
            {
                bc.enabled = false;
            }
        }
    }

    private IEnumerator ShowInvincibility(){
        Sps[0].color = new Color(1f, 1f, 1f, 0.5f);
        Sps[1].color = new Color(1f, 1f, 1f, 0.5f);

        yield return new WaitForSeconds(2f);
        Sps[0].color = new Color(1f, 1f, 1f, 1f);
        Sps[1].color = new Color(1f, 1f, 1f, 1f);

    }
}
