using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public SnakeMovement mainSnake;
    public int curLevel=0;

    void Update()
    {
        if (mainSnake.score == 10) {
            curLevel++;
            Application.LoadLevel(curLevel);
        }
    }
}
