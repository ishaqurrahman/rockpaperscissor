using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
   public AudioClip background;
   public AudioClip click;
   public AudioClip paper;
   public AudioClip scissors;
   
   private void Start() 
   {
        musicSource.clip = background;
        musicSource.Play();
   }

   public void PlaySFX(AudioClip clip)
   {
        SFXSource.PlayOneShot(clip);
     
        SFXSource.Play();
   }

   public void MuteAudio(bool mute)
   {
     if(mute)
     {
          AudioListener.volume = 0;
     }
     else
     {
          AudioListener.volume = 1;
     }
          
   }
     
   


}
