using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public GameObject gameOverCanvas;

    public void GameOver(){
        gameOverCanvas.SetActive(true);
    }

    public void Reset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
