using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject DeathObject;
    public GameObject myscoreTextObject;
    public Text Highscore;
    public Text myscoreText;
    public Text DeathScore;
    public int ScoreNumber;
    public int highscore = 0;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        ScoreNumber = 0;
        myscoreText.text = "Score : " + ScoreNumber;
        DeathScore.text = "Score : " + ScoreNumber;
        Highscore.text = "HIGHSCORE : " + highscore;
        DeathObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D Star)
    {
        if(Star.tag == "Star")
        {
            ScoreNumber += 1;
            Destroy(Star.gameObject);
            myscoreText.text = "Score : " + ScoreNumber;
            DeathScore.text = "Score is " + ScoreNumber;
            Highscore.text = "HIGHSCORE : " + highscore;
            if (highscore < ScoreNumber)
            {
                PlayerPrefs.SetInt("highscore", ScoreNumber);
            }
        }

        if(player.IsDead)
        {
            myscoreTextObject.SetActive(false);
            DeathObject.SetActive(true);
        }
    }
}
