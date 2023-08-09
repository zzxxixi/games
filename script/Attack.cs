using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;

using UnityEngine.Events;
public class Attack : MonoBehaviour
{

    [SerializeField] private string tag;
    [SerializeField] private UnityEvent attack;
    private bool _canAttack=true;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!_canAttack) return;
        if (col.CompareTag(tag))
        {
            var damageable = col.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            TimersManager.SetTimer(this,1,CanAttack);
            _canAttack = false;
            attack.Invoke();
        }
    }

    private void CanAttack()
    {
        _canAttack = true;    
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!_canAttack) return;
        if (other.CompareTag(tag))
        {
            
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            attack.Invoke();
        }
    }
}
