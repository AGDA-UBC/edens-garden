using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingScript : MonoBehaviour {

    Vector3 playerPosition;       // Keeps track of where Player will be teleported.
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
        playerPosition = destTransform.position;

        testSound1.PlaySoundAt(playerPosition);
    }
}

