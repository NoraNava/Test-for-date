using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTop : MonoBehaviour
{
    public List<Image> enemyicons = new List<Image>();

    private string name1, name2;

    public void Start()
    {
        Instantiate(enemyicons[0], GameObject.Find("TopE1").transform);
    }

    void Update()
    {
        name1 = AScript.AItemName;
        name2 = BScript.BItemName;

        if ((name1 == "Black(Clone)" && name2 == "Dark Blue(Clone)") || (name1 == "Dark Blue(Clone)" && name2 == "Black(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyicons[1], GameObject.Find("TopE2").transform);
            }
        }

        if ((name1 == "Dark Green(Clone)" && name2 == "Gray(Clone)") || (name1 == "Gray(Clone)" && name2 == "Dark Green(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyicons[2], GameObject.Find("TopE3").transform);
            }
        }

        if ((name1 == "Light Blue(Clone)" && name2 == "Light Green(Clone)") || (name1 == "Light Green(Clone)" && name2 == "Light Blue(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyicons[3], GameObject.Find("TopE4").transform);
            }
        }

        if ((name1 == "Orange(Clone)" && name2 == "Purple(Clone)") || (name1 == "Purple(Clone)" && name2 == "Orange(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyicons[4], GameObject.Find("TopE5").transform);
            }
        }

        if ((name1 == "Red(Clone)" && name2 == "Yellow(Clone)") || (name1 == "Yellow(Clone)" && name2 == "Red(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyicons[5], GameObject.Find("TopE6").transform);
            }
        }
    }
}
