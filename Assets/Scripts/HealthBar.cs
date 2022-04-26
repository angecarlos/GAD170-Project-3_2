using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _HealthBarSprite;

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        _HealthBarSprite.fillAmount = currentHealth / maxHealth;
    }

}

//Healthbar for HP
//Player and for monster