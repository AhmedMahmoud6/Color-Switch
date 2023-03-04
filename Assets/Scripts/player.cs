using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public float jumpForce = 10f;
    public string currentColor;
    public float currentPos;
    
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;
    
    string x;

    public static bool IsDead = false;
    public GameObject DeathMenuUI;
    public GameObject WinMenuUI;

    private void Start()
    {
        rb.gravityScale = 0f;
        SetRandomColor();
        x = currentColor;
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
            rb.gravityScale = 3f;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            
            while(x == currentColor)
            {
                SetRandomColor();
            }
            x = currentColor;
            
            Destroy(collision.gameObject);
            return;
        }

        if(collision.tag != currentColor && collision.tag != "Win")
        {
            Died();
        }
        if (collision.tag == "Win")
        {
            WinMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);


        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }
    }


    void Died()
    {
        DeathMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }
}
