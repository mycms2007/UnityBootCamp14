using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text bestText;
    private int score;
    private int best;

    public static ScoreManager instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;

    }
    public void SetScore(int value)
    {
        score += value; //���� ���� ����ŭ ������ ������Ų��.
        SetScoreText(score);

        if(score>best)
        {
            best = score;
            SetBestText(best);
        }

    }

    private void SetScoreText(int score) => scoreText.text = $"Score:{score}";

    private void SetBestText(int best) => bestText.text = $"Best:{best}";
    public int GetScore() => score;

}
