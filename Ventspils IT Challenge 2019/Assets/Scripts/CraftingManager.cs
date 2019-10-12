using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{
    public string name1;
    public string name2;

    public List<bool> achieved = new List<bool>();
    public List<Image> craftables = new List<Image>();

    public string DestroyA;
    public string DestroyB;
    public string DestroyC;

    public static int level;
    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            achieved[i] = false;
        }

        level = 0;
    }

    public void Update()
    {
        name1 = AScript.AItemName;
        name2 = BScript.BItemName;

        if ((name1 == "Black(Clone)" && name2 == "Dark Blue(Clone)") || (name1 == "Dark Blue(Clone)" && name2 == "Black(Clone)"))
        {
            if (achieved[0] == false)
            {
                Instantiate(craftables[0], GameObject.FindGameObjectWithTag("C").transform);
                DestroyA = name1;
                DestroyB = name2;
                DestroyC = "Result1(Clone)";
                achieved[0] = true;
                level = 1;
            }
        }

        if ((name1 == "Dark Green(Clone)" && name2 == "Gray(Clone)") || (name1 == "Gray(Clone)" && name2 == "Dark Green(Clone)"))
        {
            if (achieved[1] == false)
            {
                Instantiate(craftables[1], GameObject.FindGameObjectWithTag("C").transform);
                DestroyA = name1;
                DestroyB = name2;
                DestroyC = "Result2(Clone)";
                achieved[1] = true;
                level = 2;
            }
        }

        if ((name1 == "Light Blue(Clone)" && name2 == "Light Green(Clone)") || (name1 == "Light Green(Clone)" && name2 == "Light Blue(Clone)"))
        {
            if (achieved[2] == false)
            {
                Instantiate(craftables[2], GameObject.FindGameObjectWithTag("C").transform);
                DestroyA = name1;
                DestroyB = name2;
                DestroyC = "Result3(Clone)";
                achieved[2] = true;
                level = 3;
            }
        }

        if ((name1 == "Orange(Clone)" && name2 == "Purple(Clone)") || (name1 == "Purple(Clone)" && name2 == "Orange(Clone)"))
        {
            if (achieved[3] == false)
            {
                Instantiate(craftables[3], GameObject.FindGameObjectWithTag("C").transform);
                DestroyA = name1;
                DestroyB = name2;
                DestroyC = "Result4(Clone)";
                achieved[3] = true;
                level = 4;
            }
        }

        if ((name1 == "Red(Clone)" && name2 == "Yellow(Clone)") || (name1 == "Yellow(Clone)" && name2 == "Red(Clone)"))
        {
            if (achieved[4] == false)
            {
                Instantiate(craftables[4], GameObject.FindGameObjectWithTag("C").transform);
                DestroyA = name1;
                DestroyB = name2;
                DestroyC = "Result5(Clone)";
                achieved[4] = true;
                level = 5;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyABC(DestroyA, DestroyB, DestroyC);
        }

    }

    public void DestroyABC(string A, string B, string C)
    {
        Destroy(GameObject.Find(A));
        Destroy(GameObject.Find(B));
        Destroy(GameObject.Find(C));
        print("Evolved");
    }
}
