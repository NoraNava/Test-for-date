using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (fileName = "New Item", menuName = "Inventory/Item")]
public class item : ScriptableObject
{
    new public string name = "New Item";
    public int ID;
    public Image image;
}