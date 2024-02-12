using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBow : InventoryItem
{
    void Start()
    {
        //Seteo de variables de clase derivada
        itemName = "Enchanted Bow";
        itemSprite = Resources.Load<Sprite>("Bow");
        tipo = Tipo.WEAPON;
        rareza = Rareza.NONE;
        habilidad = Habilidad.UNBREAKING;
    }
}