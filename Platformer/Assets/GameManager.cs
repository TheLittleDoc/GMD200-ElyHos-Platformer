using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // make singleton
    public static GameManager Instance;
    [FormerlySerializedAs("Score")] public int score = 0;
    public int highScore = 0;
    public int lives = 3;
    public bool isGameOver = false;
    public bool isGamePaused = false;
    public bool isGoalReached = false;
    
    
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
