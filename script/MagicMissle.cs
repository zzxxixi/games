using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;
using UnityEngine.Events;
public class MagicMissle : MonoBehaviour
{
    [SerializeField] private UnityEvent missilelaunch;
    [SerializeField] private MissileCreator creator;
    private void LaunchMissle()
    {
        creator.CreateMissile();
        missilelaunch.Invoke();
    }

    private void Awake(){
        TimersManager.SetLoopableTimer(this, 1, LaunchMissle);

    }
}
