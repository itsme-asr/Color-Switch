using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 7f;
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer spr;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorViolet;

    private void Start()
    {
        setRandomColor();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "colorChange")
        {
            setRandomColor();
            Destroy(col.gameObject);
            return;
        }
        if (col.tag != currentColor)
        {
            // pass or destory
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    void setRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                spr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                spr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                spr.color = colorPink;
                break;
            case 3:
                currentColor = "Violet";
                spr.color = colorViolet;
                break;
        }
    }
}
