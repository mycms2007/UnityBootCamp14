
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SimpleClickGame : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;
    public Text resultText;
    public Text highScoreText;
    public GameObject resultPanel;
    public float gameDuration = 60f;

    private int score = 0;
    private int highScore = 0;
    private float timeRemaining;
    private bool isGameOver = false;

    void Start()
    {
        timeRemaining = gameDuration;
        score = 0;
        resultPanel.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) return;

        // �ð� ����
        timeRemaining -= Time.deltaTime;

        // �ð� UI ���� (�ø� ó��)
        int timeToDisplay = Mathf.CeilToInt(timeRemaining);
        timerText.text = "Time: " + timeToDisplay.ToString();

        // �ð� ���� �� ���� ���� ó��
        if (timeRemaining <= 0f)
        {
            EndGame();
        }
    }
    void OnMouseDown()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
    // Ŭ�� �� ȣ��� �Լ�
    public void AddScore()
    {
        if (isGameOver) return;

        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    void EndGame()
    {
        isGameOver = true;
        resultPanel.SetActive(true);
        resultText.text = "Your Score: " + score;

        // �ְ� ���� ����
        if (score > highScore)
        {
            highScore = score;
        }

        highScoreText.text = "High Score: " + highScore;
    }

    // �ٽ��ϱ� ��ư ���� �Լ�
    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // �����ϱ� ��ư ���� �Լ�
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}