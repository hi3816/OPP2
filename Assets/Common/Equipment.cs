using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Equipment : MonoBehaviour
{
    public GameObject curEquip;
    public Transform equipParent;

    private PlayerController controller;
    private PlayerCondition condition;

    void Start()
    {
        controller = CharacterManager.Instance.Player.controller;
        condition = CharacterManager.Instance.Player.condition;
    }

    public void TryEquip(ItemObj data)
    {
        UnEquip();
        curEquip = data.gameObject;
        data.transform.position = equipParent.position;
        data.transform.parent = equipParent;

        switch (data.cType)
        {
            case ConsumableType.Health:
                break;
            case ConsumableType.Speed:
                break;
            case ConsumableType.Stamina:
                break;
            case ConsumableType.Dash:
                break;
            }
    }

    public void UnEquip()
    {
        if (curEquip != null)
        {
            Destroy(curEquip.gameObject);
            curEquip = null;
        }
    }
}
