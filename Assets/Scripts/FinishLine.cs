using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player"){
            Debug.Log("You Finished!");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
