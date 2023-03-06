using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject DeathObject;
    public GameObject myscoreTextObject;
    public Text myscoreText;
    public Text DeathScore;
    public int ScoreNumber;



    void Start()
    {
        ScoreNumber = 0;
        myscoreText.text = "Score : " + ScoreNumber;
        DeathScore.text = "Score : " + ScoreNumber;
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
        }

        if(player.IsDead)
        {
            myscoreTextObject.SetActive(false);
            DeathObject.SetActive(true);
        }
    }
}
