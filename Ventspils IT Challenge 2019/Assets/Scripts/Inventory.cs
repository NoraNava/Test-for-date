using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{
    public List<item> inventory = new List<item>();

    public void Start()
    {
        for (int i = 0; i < inventory.Capacity; i++)
        {
            Instantiate(inventory[i].image, GameObject.Find("InactiveHolder").transform);
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        DragHandler.itemBeingDragged.transform.SetParent(gameObject.transform);
    }

    public void Aquire(string clone)
    {
            GameObject.Find(clone).transform.SetParent(GameObject.FindGameObjectWithTag("Inventory").transform, false);
    }
}