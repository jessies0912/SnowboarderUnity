using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSnow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dust;
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dust.Play();
        }
    }

    /// Sent when a collider on another object stops touching this
    /// object's collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dust.Stop();
        }
    }
}
