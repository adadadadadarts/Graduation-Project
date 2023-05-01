using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    [SerializeField]private float health;
    [SerializeField]private float stamina;
    [SerializeField]private float thirst;
    [SerializeField]private float hunger;

    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    public float Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public float Thirst
    {
        get { return thirst; }
        set { thirst = value; }
    }

    public float Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }
    
    public void IncreaseHealth(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void IncreaseStamina(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void IncreaseThirst(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void IncreaseHunger(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void DecreaseHealth(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void DecreaseStamina(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void DecreaseThirst(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void DecreaseHunger(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void RefreshHealth()
    {
        throw new System.NotImplementedException();
    }

    public void RefreshStamina()
    {
        throw new System.NotImplementedException();
    }

    public void RefreshThirst()
    {
        throw new System.NotImplementedException();
    }

    public void RefreshHunger()
    {
        throw new System.NotImplementedException();
    }
}
