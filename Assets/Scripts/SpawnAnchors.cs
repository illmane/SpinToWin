using System.Collections;
using UnityEngine;

public class SpawnAnchors : MonoBehaviour
{
    public float SpawnRate;
    public GameObject AnchorPrefab;

    private float SpawnTimer;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (SpawnTimer <= 0f)
        {
            SpawnAnchor();
        }
        else if (SpawnTimer > 0f)
        {
            SpawnTimer -= Time.deltaTime;
        }
    }

    private void SpawnAnchor()
    {
        Instantiate(AnchorPrefab, transform.position, transform.rotation);
        SpawnTimer = SpawnRate;
    }
}
