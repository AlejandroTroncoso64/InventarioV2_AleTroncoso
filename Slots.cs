using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    //Variables de sprites de slot
    public Image image;
    private Sprite defaultSprite;
    //verificador si el inventario está lleno
    public bool isFull = false;

    void Start()
    {
        //Obtener sprite del slot, dejarlos vacíos al iniciar
        defaultSprite = Resources.GetBuiltinResource<Sprite>("square");
        ClearSlot();
    }


    //Poner item en un slot, o denegarlo en caso de estar lleno
    public void SetItem(InventoryItem item)
    {
        if (item != null)
        {
            image.sprite = item.itemSprite;
            isFull = true;
        }
        else
        {
            ClearSlot();
        }
    }


    //Denegar un item en un slot
    public void ClearSlot()
    {
        image.sprite = defaultSprite;
        isFull = false;
    }

}
