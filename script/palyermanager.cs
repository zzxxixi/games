using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class palyermanager : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] private  Transform playerTrasnform;
    private static palyermanager _instance;
    public static Vector2 Position
    {
        get { return _instance.playerTrasnform.position; }
    }
     

    // Update is called once per frame
    private void Awake()
    {
        _instance = this;
    }
}
