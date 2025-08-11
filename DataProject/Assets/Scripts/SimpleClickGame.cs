
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

        // 시간 감소
        timeRemaining -= Time.deltaTime;

        // 시간 UI 갱신 (올림 처리)
        int timeToDisplay = Mathf.CeilToInt(timeRemaining);
        timerText.text = "Time: " + timeToDisplay.ToString();

        // 시간 종료 시 게임 종료 처리
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
    // 클릭 시 호출될 함수
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

        // 최고 점수 갱신
        if (score > highScore)
        {
            highScore = score;
        }

        highScoreText.text = "High Score: " + highScore;
    }

    // 다시하기 버튼 연결 함수
    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // 종료하기 버튼 연결 함수
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}