using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//아이템을 슬롯에 반영해준다 
public class ItemSlot : MonoBehaviour
{
    public Image Icon;
    public Text CountText;
    public Text ItemName;

    private ItemData itemData;
    private int itemCount = 1;


    private void UpdateUI()
    {
        if (itemData != null)
        {
            Icon.sprite = itemData.Icon;
            ItemName.text = itemData.itemName;

            if (itemCount > 1)
            {
                CountText.text = itemCount.ToString();
            }
            else
            {
                CountText.text = "";
            }
        }
        else
        {
            Icon.sprite = null;
            CountText.text = "";
        }
    }

    public void SetUp(ItemData setItemData)
    {
        itemData = setItemData;
        UpdateUI();
    }


    //동일한 아이템인경우 
    public void AddCount(int amount)
    {
        itemCount += amount;
        UpdateUI();
    }


    //동일한 아이템인지 아닌지 
    public bool HasItem(ItemData checkItem)
    {
        return itemData == checkItem;
    }

    //아이템 사용 
    public void OnclickItem()
    {
        if (itemData == null || itemCount <= 0)
            return;


        //아이템 사용 구간

        itemCount--;
        UpdateUI();

        if (itemCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }





}
