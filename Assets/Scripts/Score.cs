using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text myScore;
    public int scoreNum;

    // Update is called once per frame
    void Update()
    {
        scoreNum = 0;
        myScore.text = "Score : " + scoreNum;
    }
}
