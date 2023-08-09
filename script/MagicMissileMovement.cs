using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MagicMissileMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 _direction;
    // Start is called before the first frame update
    private GameObject LocateEnemy()
    {
        var results = new Collider2D[5];
        Physics2D.OverlapCircleNonAlloc(transform.position, 10, results);
        foreach(var result in results)
        {
            if (result!=null&&result.CompareTag("Enemy"))
            {
                return result.gameObject;
            }
            
        }
        return null;

    }

    private Vector2 MoveDirection(Transform target)
    {
        var direction = new Vector2(1, 0);

        if(target!= null)
        {
            direction = target.position - transform.position;
            direction.Normalize();

        }

        return direction;
    }

    private void Awake()
    {
        var enemy = LocateEnemy();
        if (enemy == null) _direction = MoveDirection(null);
        else
        {
            _direction = MoveDirection(enemy.transform);

        }
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _direction);

    }
    private void FixedUpdate()
    {
        var targetPosition= (Vector2)transform.position +_direction;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
