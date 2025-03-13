using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Sound2 : MonoBehaviour
{
  

    public AudioSource firework;
    public AudioSource fireworks;
    public AudioSource fireworkss;
    public AudioSource fireworksss;
    public AudioSource fireworkssss;
    private void Start()
    {
        
        firework = GetComponent<AudioSource>();
        Invoke("playAudio", 3.4f);

        fireworks = GetComponent<AudioSource>();
        Invoke("playAudio", 4.9f);

        fireworkss = GetComponent<AudioSource>();
        Invoke("playAudio", 6.2f);

        fireworksss = GetComponent<AudioSource>();
        Invoke("playAudio", 6.9f);

        fireworkssss = GetComponent<AudioSource>();
        Invoke("playAudio", 7.8f);


    }

    void playAudio()
    {
        firework.Play();
        fireworks.Play();
        fireworkss.Play();
        fireworksss.Play();
        fireworkssss.Play();
    }
   
}
