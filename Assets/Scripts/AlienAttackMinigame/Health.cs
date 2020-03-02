using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //damageSoundID is the sound made when the player or enemy takes a hit
    //destroyedSoundID is the sound played when the player or enemy is destroyed
    //shipSounder is the name of the object giving out sounds
    public AudioClip damageSoundID;
    public AudioClip destroyedSoundID;
    public AudioSource shipSounder;

    [SerializeField]
    protected int health;

    [SerializeField]
    protected int maximumHealth;

    public void Start()
    {
        shipSounder = GetComponent<AudioSource>();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        health = Mathf.Clamp(health, 0, maximumHealth);
        shipSounder.PlayOneShot(damageSoundID);

        if (health <=0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        shipSounder.PlayOneShot(destroyedSoundID);
        Destroy(gameObject);
    }
 
}
