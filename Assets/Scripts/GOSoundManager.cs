using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOSoundManager : MonoBehaviour {

    public static GOSoundManager Instance = null;
    private AudioSource soundEffectAudio;

    // Use this for initialization
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        AudioSource theSource = GetComponent<AudioSource>();
        soundEffectAudio = theSource;
    }
}
