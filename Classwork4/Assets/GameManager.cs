using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scoreCount = 0;
    public int increment = 1;
    public Text scoreCountText;
    public Text warningText;
    public Text incrementText;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void IncreaseScore()
    {
        scoreCount += increment;
        scoreCountText.text = scoreCount.ToString();
        warningText.text = "";
    }

    public void Store()
    {
        if (scoreCount > 5)
        {
            increment++;
            scoreCount -= 5;
            scoreCountText.text = scoreCount.ToString();
            incrementText.text = "inc = " + increment.ToString();
        }
        else
        {
            warningText.text = "You don't have enough cookies :(";
        }
    }

    public void Reset()
    {
        scoreCount = 0;
        scoreCountText.text = scoreCount.ToString();
        increment = 1;
        incrementText.text = "inc = " + increment.ToString();
    }
}