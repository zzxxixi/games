using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private UnityEvent<Vector2> moveDirection;


    private void FixedUpdate()
    {
        var playerposition = palyermanager.Position;
        var position1 = (Vector2)transform.position;
        var direction = playerposition - position1;
        direction.Normalize();
        var targetPosition = position1 + direction;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
        moveDirection.Invoke(direction);
    }
}