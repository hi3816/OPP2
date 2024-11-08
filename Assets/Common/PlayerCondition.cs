using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float stamina;
    [SerializeField] private float dash;

    public void AddEffect(ItemObj data)
    {
        switch (data.cType)
        {
            case ConsumableType.Health:
                AddHealth(data.value);
                break;
            case ConsumableType.Speed:
                AddSpeed(data.value);
                break;
            case ConsumableType.Stamina:
                AddStamina(data.value);
                break;
            case ConsumableType.Dash:
                AddDash(data.value);
                break;
        }
    }

    public void AddHealth(float amount)
    {
        health += amount;
    }

    public void AddSpeed(float amount)
    {
        speed += amount;
    }

    public void AddStamina(float amount)
    {
        stamina += amount;
    }

    public void AddDash(float amount)
    {
        dash += amount;
    }

    public void Die()
    {
        Debug.Log("플레이어가 죽었다.");
    }

    public void TakePhysicalDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}