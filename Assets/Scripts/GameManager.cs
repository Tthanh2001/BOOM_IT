using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;
    public GameObject over;

    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
            }
        }

        if (aliveCount <= 1)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        over.SetActive(true);
        Instantiate(over, over.transform);
        Time.timeScale = 0f;
    }
}
