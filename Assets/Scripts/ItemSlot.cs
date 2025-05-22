using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//�������� ���Կ� �ݿ����ش� 
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


    //������ �������ΰ�� 
    public void AddCount(int amount)
    {
        itemCount += amount;
        UpdateUI();
    }


    //������ ���������� �ƴ��� 
    public bool HasItem(ItemData checkItem)
    {
        return itemData == checkItem;
    }

    //������ ��� 
    public void OnclickItem()
    {
        if (itemData == null || itemCount <= 0)
            return;


        //������ ��� ����

        itemCount--;
        UpdateUI();

        if (itemCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }





}
