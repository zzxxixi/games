using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip magicMissileLaunchClip;
    [SerializeField] private AudioClip takeDamageClip;

    public void PlayGameOver()
    {
        audiosource.PlayOneShot(gameOverClip);
    }

    public void PlayMagicMissileLaunch()
    {
        audiosource.PlayOneShot(magicMissileLaunchClip);
    }

    public void PlayTakeDamage()
    {
        audiosource.PlayOneShot(takeDamageClip);
    }
}
