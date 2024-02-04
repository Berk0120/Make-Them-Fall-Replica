using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int _score = 0;

    [SerializeField] private TMP_Text _scoreText;
    void Start()
    {
        
    }

  
    void Update()
    {
        _scoreText.text = _score.ToString();
    }
    public void GameOverScene()
    {
        SceneManager.LoadScene(0);
    }
}
