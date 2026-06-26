using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreboardScript : MonoBehaviour
{
    public UnityEngine.UI.Image Medal_Image;
    public Sprite[] all_medals;
    public Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateScoreboard();

    }

    private void CalculateScoreboard()
    {
        if (PointsManager.TotalPoints <= 3)
        {
            ScoreText.text = "Your less than mid. But try again..";
            Medal_Image.sprite = all_medals[0];
            
        }
        else if (PointsManager.TotalPoints > 3 && PointsManager.TotalPoints <= 8)
        {
            ScoreText.text = "Top 50% mindset.";
            Medal_Image.sprite = all_medals[1];

            
        }
        else if (PointsManager.TotalPoints > 8)
        {
            ScoreText.text = "You are number one, gang.";
            Medal_Image.sprite = all_medals[2];
        }
    }
    

    public void OnRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
