using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;
    public static UIManager Instance => instance;

    [SerializeField]
    TMP_Text _scoreText;

    int _score;

    [SerializeField]
    GameObject _endScreen;

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
}