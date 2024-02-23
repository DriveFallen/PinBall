using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text gameScoreTXT;
    [SerializeField] private Text ballCounteTXT;
    [SerializeField] private GameObject gameOverFrame;
    [SerializeField] private GameObject PauseFrame;
    [SerializeField] private Text resultTXT;

    private bool isPaused;

    public static int Score;
    public static int BallCount;

    private void Start()
    {
        isPaused = false;
        Score = 0;
        BallCount = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Pause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseFrame.SetActive(true);
        }
        else
        {
            PauseFrame.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        gameScoreTXT.text = $"Score: {Score}";
        ballCounteTXT.text = $"Balls: {BallCount}";
    }

    public void GameOver()
    {
        gameOverFrame.SetActive(true);
        resultTXT.text = $"Result: {Score}";
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
