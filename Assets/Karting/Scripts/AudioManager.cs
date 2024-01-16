using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
//cambio rama 2
public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void EnsureSFXDestruction(AudioSource source)
    {
        StartCoroutine("DelayedSFXDestruction", source);
    }

    private IEnumerator DelayedSFXDestruction(AudioSource source)
    {
        while (source.isPlaying)
        {
            yield return null;
        }

        GameObject.Destroy(source.gameObject);
    }
}
