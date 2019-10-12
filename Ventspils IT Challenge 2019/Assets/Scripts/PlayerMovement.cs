using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float h;
    float v;

    public Animator anim;

    public int level = 0;

    private string name1, name2;

    private void Start()
    {
        this.transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        var pos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        pos.x = Mathf.Clamp(pos.x + h * speed, -2171 + 900, 2171 - 900);
        pos.y = Mathf.Clamp(pos.y + v * speed, -1090 + 450, 1090 - 450);
        gameObject.transform.position = new Vector3(pos.x, pos.y, 0);

        name1 = AScript.AItemName;
        name2 = BScript.BItemName;

        if ((name1 == "Black(Clone)" && name2 == "Dark Blue(Clone)") || (name1 == "Dark Blue(Clone)" && name2 == "Black(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                level = 1;
            }
        }

        if ((name1 == "Dark Green(Clone)" && name2 == "Gray(Clone)") || (name1 == "Gray(Clone)" && name2 == "Dark Green(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                level = 2;
            }
        }

        if ((name1 == "Light Blue(Clone)" && name2 == "Light Green(Clone)") || (name1 == "Light Green(Clone)" && name2 == "Light Blue(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                level = 3;
            }
        }

        if ((name1 == "Orange(Clone)" && name2 == "Purple(Clone)") || (name1 == "Purple(Clone)" && name2 == "Orange(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                level = 4;
            }
        }

        if ((name1 == "Red(Clone)" && name2 == "Yellow(Clone)") || (name1 == "Yellow(Clone)" && name2 == "Red(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                level = 5;
            }
        }

        anim.SetInteger("Level", level);
    }

    /*public void OnTriggerEnter(Collider2D collision)
    {
        switch (level)
        {
            case 0:
                if (collision.gameObject.tag == "Enemy2")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy3")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy4")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy5")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 1:
                if (collision.gameObject.tag == "Enemy3")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy4")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy5")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 2:
                if (collision.gameObject.tag == "Enemy4")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy5")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 3:
                if (collision.gameObject.tag == "Enemy5")
                {
                    SceneManager.LoadScene("Lose");
                }
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 4:
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 5:
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Lose");
                }
                break;

            case 6:
                if (collision.gameObject.tag == "Enemy6")
                {
                    SceneManager.LoadScene("Win");
                }
                break;
        }
    }*/

}
