using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public  void Stop()
    {
        Time.timeScale = 0;
    }
    public void resum()
    {
        Time.timeScale = 1;
    }
}
