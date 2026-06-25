using System.Collections;
using UnityEngine;

public class AnchorBehaviour : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DestroyAnhor());
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            collision.GetComponent<InvinsibilityManager>().MakeInvinsible();
            collision.GetComponent<HealthSystem>().DamageShip(1);
        }
    }


    private IEnumerator DestroyAnhor()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
