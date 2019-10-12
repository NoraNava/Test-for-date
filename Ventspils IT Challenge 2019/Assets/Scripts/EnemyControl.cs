using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControl : MonoBehaviour
{
    private Inventory inv;
    private int r;

    private int level = 0;

    private string name1, name2;

    private void Awake()
    {
        inv = gameObject.AddComponent<Inventory>();
    }

    private void Start()
    {
    }

    private void Update()
    {
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

        switch (level)
        {
            case 0:
                r = Random.Range(1, 20);
                break;

            case 1:
                r = Random.Range(21, 40);
                break;

            case 2:
                r = Random.Range(41, 60);
                break;

            case 3:
                r = Random.Range(61, 80);
                break;

            case 4:
                r = Random.Range(81, 100);
                break;

            case 5:
                r = 0;
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);

        switch (r)
        {
            case 1:
                inv.Aquire("Black(Clone)");
                break;
            case 6:
                inv.Aquire("Black(Clone)");
                break;
            case 10:
                inv.Aquire("Dark Blue(Clone)");
                break;
            case 15:
                inv.Aquire("Dark Blue(Clone)");
                break;
            case 21:
                inv.Aquire("Dark Green(Clone)");
                break;
            case 26:
                inv.Aquire("Dark Green(Clone)");
                break;
            case 30:
                inv.Aquire("Gray(Clone)");
                break;
            case 35:
                inv.Aquire("Gray(Clone)");
                break;
            case 41:
                inv.Aquire("Light Blue(Clone)");
                break;
            case 46:
                inv.Aquire("Light Blue(Clone)");
                break;
            case 50:
                inv.Aquire("Light Green(Clone)");
                break;
            case 55:
                inv.Aquire("Light Green(Clone)");
                break;
            case 61:
                inv.Aquire("Orange(Clone)");
                break;
            case 66:
                inv.Aquire("Orange(Clone)");
                break;
            case 70:
                inv.Aquire("Purple(Clone)");
                break;
            case 75:
                inv.Aquire("Purple(Clone)");
                break;
            case 81:
                inv.Aquire("Red(Clone)");
                break;
            case 86:
                inv.Aquire("Red(Clone)");
                break;
            case 90:
                inv.Aquire("Yellow(Clone)");
                break;
            case 95:
                inv.Aquire("Yellow(Clone)");
                break;
        }

        if(collider.gameObject.tag == "Player")
        {
            switch (level)
            {
                case 0:
                    if (gameObject.name == "Enemy2(Clone)" || gameObject.name == "Enemy3(Clone)" || gameObject.name == "Enemy4(Clone)" || gameObject.name == "Enemy5(Clone)" || gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Lose");
                    }
                    break;

                case 1:
                    if (gameObject.name == "Enemy3(Clone)" || gameObject.name == "Enemy4(Clone)" || gameObject.name == "Enemy5(Clone)" || gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Lose");
                    }
                    break;

                case 2:
                    if (gameObject.name == "Enemy4(Clone)" || gameObject.name == "Enemy5(Clone)" || gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Lose");
                    }
                    break;

                case 3:
                    if (gameObject.name == "Enemy5(Clone)" || gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Lose");
                    }
                    break;

                case 4:
                    if (gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Lose");
                    }
                    break;

                case 5:
                    if (gameObject.name == "Enemy6(Clone)")
                    {
                        SceneManager.LoadScene("Win");
                    }
                    break;
            }
        }
    }
}
