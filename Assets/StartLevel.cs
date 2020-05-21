using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectsWithTag("Ball")[0];
    }

    public void startLevel()
    {
        Ball.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
