using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BlockController[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public GameObject ball;
    private bool isGameClear = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isGameClear != true)
        {
            if (isDestroyAllBlocks())
            {
                // Game Clear
                gameClearUI.SetActive(true);
                isGameClear = true;
                Destroy(ball);
            }
        }
    }

    private bool isDestroyAllBlocks()
    {
        foreach(BlockController b in blocks)
        {
            if (b != null)
            {
                return false;
            }

        }
        return true;
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("BreakOut");
    }
}
