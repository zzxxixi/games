using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;
    [SerializeField] private string attackState;

    public void Move(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction == Vector2.zero)
        {
            animator.Play(idleState);
        }
        else
        {
            animator.Play(walkState);
        }
        if (direction.x > 0)
        {
            renderer.flipX = false;
        }
        else if(direction.x < 0)
        {
            renderer.flipX = true;

        }
    }

    public void Attcak()
    {
        animator.Play(attackState);
    }
}
