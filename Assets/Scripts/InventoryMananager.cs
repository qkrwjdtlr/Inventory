using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryMananager : MonoBehaviour
{
    public static InventoryMananager Instance;

    public Transform ItemSlotParent;
    public GameObject ItemSlotPrefab;
    public GameObject InventoryPannel;

    private bool inventoryOpen = false;
    private List<ItemSlot> slots = new List<ItemSlot>();




    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryOpen = !inventoryOpen;
            InventoryPannel.SetActive(inventoryOpen);
        }
    }


    //�������� �߰��ϴ� �Լ�
    public void AddItem(ItemData newItem)
    {
        //������ �������� �ִ��� ������ Ȯ��
        ItemSlot exitsSlot = null;

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i]!=null && slots[i].HasItem(newItem)==true)
            {
                //������ ������ 
                exitsSlot = slots[i];
                break;
            }
        }

        if (exitsSlot != null)

        {
            exitsSlot.AddCount(1);
        }
        else
        {
            //Instantiate(������ ������Ʈ.��������ġ)
            GameObject newSlot = Instantiate(ItemSlotPrefab, ItemSlotParent);
            ItemSlot itemslot = newSlot.GetComponent<ItemSlot>();
            itemslot.SetUp(newItem);
            slots.Add(itemslot);
        }
    }
}
