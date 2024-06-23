using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Crashed : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float delay = 0;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashAudio;
    bool crashed;
    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Ground" && !crashed){
            Debug.Log("You crashed!");
            crashed = true;
            FindObjectOfType<PlayerController>().DisableControl();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashAudio);
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
