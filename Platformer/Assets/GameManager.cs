using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // make singleton
    public static GameManager Instance;
    public int Score = 0;
    public int HighScore = 0;
    public int Lives = 3;
    public bool IsGameOver = false;
    public bool IsGamePaused = false;
    public bool IsGameStarted = false;
    
    
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
