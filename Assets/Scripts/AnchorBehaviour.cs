using UnityEngine;

public class AnchorBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            collision.GetComponent<InvinsibilityManager>().MakeInvinsible();
        }
    }
}
