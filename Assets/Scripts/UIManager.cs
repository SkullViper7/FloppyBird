using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;
    public static UIManager Instance => instance;

    [SerializeField]
    TMP_Text _scoreText;

    int _score;

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

    public void AddScore()
    {
        _score += 1;
        _scoreText.text = _score.ToString();
    }

    public void ShowScore()
    {
        _gameScore.SetActive(false);
        _endScreen.SetActive(true);

        _endScoreText.text = _score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
}