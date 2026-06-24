using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;
    public Image[] allHearts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        displayHearts();
    }

    private void displayHearts()
    {
        for (int i = 0; i < allHearts.Length; i++)
        {
            if (i < CurrentHealth)
            {
                allHearts[i].enabled = true;
            }
            else
            {
                allHearts[i].enabled = false;
                
            }
        }
    }
}
