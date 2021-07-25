using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag != "Bomb") return;
        IncreaseScore();
        target.gameObject.SetActive(false);
    }
}