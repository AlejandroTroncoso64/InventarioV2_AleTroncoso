using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItem : MonoBehaviour
{
    //Variables de objeto base

    protected string itemName;
    private string description;
    public Sprite itemSprite;

    private int health;

    public Tipo tipo;
    public Rareza rareza;
    public Habilidad habilidad;
}



public enum Tipo
{
    //IDs de que tipo de item es, arma, bloque, comida, etc.
    NONE,
    WEAPON,
    BLOCK,
}

public enum Rareza
{
    //IDs de material del arma o herramienta
    NONE,
    WOOD,
    STONE,
    IRON,
    GOLD,
    DIAMOND,
    NETHERITE,
}

public enum Habilidad
{
    //IDs de encantamientos
    NONE,
    UNBREAKING,
    SHARPNESS,
    LOOTING,
}