using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _HealthBarSprite;

    public void UpdateHealthBar(float maxPlayerHealth, float currentPlayerHealth)
    {
        _HealthBarSprite.fillAmount = currentPlayerHealth / maxPlayerHealth;
    }



}

//Healthbar for HP
//Player and for monster