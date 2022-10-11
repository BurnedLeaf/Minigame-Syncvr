using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreText;

    public void Update()
    {
        if (score >= 50)
        {
            SceneManager.LoadScene("End Scene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
    public void AddScore()
    {
        score++;

            scoreText.text = score.ToString();
    }
}

