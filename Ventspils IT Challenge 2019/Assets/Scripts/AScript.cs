using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AScript : MonoBehaviour, IDropHandler
{
    public static string AItemName;

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
            AItemName = gameObject.transform.GetChild(0).name;
        }

        if (!item)
        {
            AItemName = null;
        }
    }
}
