using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;

    void Start ()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

 

    void EndGame ()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }
    }
}
