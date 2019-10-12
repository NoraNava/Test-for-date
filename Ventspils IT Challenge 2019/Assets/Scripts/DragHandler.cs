using UnityEngine.EventSystems;
using UnityEngine;
    
    public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public Transform originalParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        originalParent = this.transform.parent;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
