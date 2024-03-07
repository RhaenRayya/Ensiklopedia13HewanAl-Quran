using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSfx : MonoBehaviour
{

    public AudioSource audioSourceSfx;

    public AudioClip audioClipBenar;
    public AudioClip audioClipSalah;
    public AudioClip audioClipButton;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SoundSfxBenar()
    {
        audioSourceSfx.PlayOneShot(audioClipBenar);
    }

    public void SoundSfxSalah()
    {
        audioSourceSfx.PlayOneShot(audioClipSalah);
    }

    public void SoundSfxButton()
    {
        audioSourceSfx.PlayOneShot(audioClipButton);
    }
}
