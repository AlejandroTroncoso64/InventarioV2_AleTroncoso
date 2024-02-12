using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStoneBlock : InventoryItem
{
    void Start()
    {
        //Seteo de variables de clase derivada
        itemName = "Stone block";
        itemSprite = Resources.Load<Sprite>("Stone1");
        tipo = Tipo.BLOCK;
        rareza = Rareza.NONE;
        habilidad = Habilidad.NONE;
    }
}
