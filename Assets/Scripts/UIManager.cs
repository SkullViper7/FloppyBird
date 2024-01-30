using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Singleton
    private static UIManager instance = null;

    public static UIManager Instance => instance;
    //

    [SerializeField]
    TMP_Text _scoreText;

    int _score;
    int _bestScore;

    [SerializeField]
    GameObject _endScreen;
    [SerializeField]
    GameObject _gameScore;

    [SerializeField]
    TMP_Text _endScoreText;
    [SerializeField]
    TMP_Text _bestScoreText;

    private void Awake()
    {
        //Singleton
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        //
    }

    /// <summary>
    /// Adding 1 point to the score and displaying it on the canvas.
    /// </summary>
    public void AddScore()
    {
        _score += 1;
        _scoreText.text = _score.ToString();
    }

    /// <summary>
    /// Shows end screen menu on game over, displaying current score, searching for a saved best score and displaying it. If the current score is greater than the best,
    /// saving the new best score.
    /// </summary>
    public void ShowScore()
    {
        _gameScore.SetActive(false);
        _endScreen.SetActive(true);

        _endScoreText.text = _score.ToString();

        if (PlayerPrefs.HasKey("BestScore"))
        {
            _bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
        }

        if (_score > _bestScore)
        {
            _bestScore = _score;
            PlayerPrefs.SetInt("BestScore", _bestScore);
        }
    }

    /// <summary>
    /// Method to restart the game, assigned to a button.
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f; // Reseting the time.
    }
}