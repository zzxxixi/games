using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent die;
    public void CheckDeath(int health)
    {
        if (health <= 0)
        {
            Die();
        }
    }
        public void Die()
    {
        gameObject.SetActive(false);
        die.Invoke();
    }

}
