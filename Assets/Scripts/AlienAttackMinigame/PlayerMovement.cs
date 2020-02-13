using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 15.0f;

    [SerializeField] private GameObject laserPrefab;
    public Transform shootingHP; //shootingHP is th hardpoint the laser is shot from on the player prefab
    public float lasersPerSecond;
    public float laserTime;
    private float laserDelay;
   
    void Start()
    {
        laserDelay = 1.0f / lasersPerSecond;
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = Input.GetAxis("Horizontal") * speed;
        controller.SimpleMove(currentSpeed * transform.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Attack();

        }
    }

    private void Attack()
    {
        Instantiate(laserPrefab, shootingHP.transform.position, shootingHP.transform.rotation);

        laserTime += laserDelay;
    }
}
