using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerScript : MonoBehaviour
{
    // Sets up the targets and damage dealt.
    public int damage;
    public string targetTag = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == targetTag)
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
