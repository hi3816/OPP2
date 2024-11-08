using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Equip
}

public enum ConsumableType
{
    Health,
    Stamina,
    Speed,
    Dash
}

public class ItemObj : MonoBehaviour, IInteractable
{
    public string name;
    public float value;

    public ItemType iType;
    public ConsumableType cType;

    public string GetInteractPrompt()
    {
        return $"이름 : {name}\n속성 : [{iType}]{cType}";
    }

    public virtual void OnInteract()
    {
        if (iType == ItemType.Consumable)
        {
            CharacterManager.Instance.Player.condition.AddEffect(this);
            Destroy(gameObject);
        }
        else if (iType == ItemType.Equip)
        {
            CharacterManager.Instance.Player.equip.TryEquip(this);
        }
    }
}
