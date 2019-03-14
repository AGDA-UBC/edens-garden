using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TalkingScript : MonoBehaviour {

    Vector3 AudioLocation;       // Keeps track of where Player will be teleported.
    public SoundFXRef testSound1;

    void OnEnable()
    {
        PlayAudioManagerObject.DoAudio += ListenTo;
    }

    void OnDisable()
    {
        PlayAudioManagerObject.DoAudio -= ListenTo;
    }

    void ListenTo(Transform destTransform)
    {
        // Set the new position.
        AudioLocation = destTransform.position;
        testSound1.PlaySoundAt(AudioLocation);
    }
}

