using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftItems : MonoBehaviour
{
    public List<Image> lefies = new List<Image>();

    private string name1, name2;

    void Start()
    {
        Instantiate(lefies[0], GameObject.Find("Left").transform);
        Instantiate(lefies[1], GameObject.Find("Left").transform);
    }

    void Update()
    {
        name1 = AScript.AItemName;
        name2 = BScript.BItemName;

        if ((name1 == "Black(Clone)" && name2 == "Dark Blue(Clone)") || (name1 == "Dark Blue(Clone)" && name2 == "Black(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lefies[2], GameObject.Find("Left").transform);
                Instantiate(lefies[3], GameObject.Find("Left").transform);
                Instantiate(lefies[4], GameObject.Find("Left").transform);
            }
        }

        if ((name1 == "Dark Green(Clone)" && name2 == "Gray(Clone)") || (name1 == "Gray(Clone)" && name2 == "Dark Green(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lefies[5], GameObject.Find("Left").transform);
                Instantiate(lefies[6], GameObject.Find("Left").transform);
                Instantiate(lefies[7], GameObject.Find("Left").transform);
            }
        }

        if ((name1 == "Light Blue(Clone)" && name2 == "Light Green(Clone)") || (name1 == "Light Green(Clone)" && name2 == "Light Blue(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lefies[8], GameObject.Find("Left").transform);
                Instantiate(lefies[9], GameObject.Find("Left").transform);
                Instantiate(lefies[10], GameObject.Find("Left").transform);
            }
        }

        if ((name1 == "Orange(Clone)" && name2 == "Purple(Clone)") || (name1 == "Purple(Clone)" && name2 == "Orange(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lefies[11], GameObject.Find("Left").transform);
                Instantiate(lefies[12], GameObject.Find("Left").transform);
                Instantiate(lefies[13], GameObject.Find("Left").transform);
            }
        }

        if ((name1 == "Red(Clone)" && name2 == "Yellow(Clone)") || (name1 == "Yellow(Clone)" && name2 == "Red(Clone)"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lefies[14], GameObject.Find("TopE6").transform);
            }
        }
    }
}
