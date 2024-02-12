using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ItemDiamondSword : InventoryItem
{   
    void Start()
    {
        //Seteo de variables de clase derivada
        itemName = "Enchanted Diamond Sword";
        itemSprite = Resources.Load<Sprite>("DiamondSword");
        tipo = Tipo.WEAPON;
        rareza = Rareza.DIAMOND;
        habilidad = Habilidad.SHARPNESS;
    }
}
