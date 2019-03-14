using UnityEngine;
using System.Collections;

public class PlayAudioManager : MonoBehaviour {

	public SoundFXRef       testSound1;
	public SoundFXRef       testSound2;

	void Start () {

        testSound1.PlaySoundAt(transform.position);

    }
	
	}

