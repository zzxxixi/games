using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;
    private void Awake()
    {
        healthBar.maxValue = health.Value;
        healthBar.value = health.Value;
    }
    public void UpdateUI()
    {
        healthBar.value = health.Value;
    }
    
}
