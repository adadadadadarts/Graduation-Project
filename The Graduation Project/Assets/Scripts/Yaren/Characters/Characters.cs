using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour
{
    public float health;
    public float stamina;
    public float thirst;
    public float hunger;

    public Characters(float health, float stamina, float thirst, float hunger)
    {
        this.health = health;
        this.stamina = stamina;
        this.thirst = thirst;
        this.hunger = hunger;
    }
    
    public void IncreaseHealth(float amount)
    {
        
    }

    public void IncreaseStamina(float amount)
    {
        
    }

    public void IncreaseThirst(float amount)
    {
        
    }

    public void IncreaseHunger(float amount)
    {
        
    }

    public void DecreaseHealth(float amount)
    {
        
    }

    public void DecreaseStamina(float amount)
    {
        
    }

    public void DecreaseThirst(float amount)
    {
        
    }

    public void DecreaseHunger(float amount)
    {
        
    }

    public void RefreshHealth()
    {
        
    }

    public void RefreshStamina()
    {
        
    }

    public void RefreshThirst()
    {
        
    }

    public void RefreshHunger()
    {
        
    }
    
}
