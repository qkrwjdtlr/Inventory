using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//아이템 데이터
[CreateAssetMenu(fileName ="Item",menuName ="Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite Icon;
}
