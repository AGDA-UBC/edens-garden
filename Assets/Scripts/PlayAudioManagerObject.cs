using System;
using UnityEngine;
using VRStandardAssets.Utils;

public class PlayAudioManagerObject : MonoBehaviour {

    public static event Action<Transform> DoAudio;
    [SerializeField] VRInteractiveItem[] AudioClips;
    [SerializeField] Transform reticleTransform;

void OnEnable()
    {
        foreach (VRInteractiveItem t in AudioClips)
        {
            t.OnClick += PlayAudio;
        }
    }

    void OnDisable()
    {
        foreach (VRInteractiveItem t in AudioClips)
        {
            t.OnClick -= PlayAudio;
        }
    }

    void PlayAudio()
    {
        if (DoAudio != null)
        {
            DoAudio(reticleTransform);
        }
        else
        {
            Debug.Log("DoAudio event has no subscribers.");
        }
    }
}
