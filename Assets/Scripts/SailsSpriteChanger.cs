using UnityEngine;

public class SailsSpriteChanger : MonoBehaviour
{
    public Sprite[] AllSailsSprites;
    private SpriteRenderer sp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSails();
    }

    private void ChangeSails()
    {
        if (WheelGameManager.Instance.angularSpeed >= 200f)
        {
            sp.sprite = AllSailsSprites[1];
        }
        else if (WheelGameManager.Instance.angularSpeed < 200f)
        {
            sp.sprite = AllSailsSprites[0];
            
        }
    }
}
