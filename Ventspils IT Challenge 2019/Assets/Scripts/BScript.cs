using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BScript : MonoBehaviour, IDropHandler
{
    public static string BItemName;

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandler.itemBeingDragged.transform.SetParent(this.transform);
        }
    }

    public void Update()
    {
        if (item)
        {
            BItemName = gameObject.transform.GetChild(0).name;
        } 

        if (!item)
        {
            BItemName = null;
        }
    }
}
