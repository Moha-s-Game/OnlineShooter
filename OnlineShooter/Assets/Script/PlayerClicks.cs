using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerClicks : MonoBehaviour
{
    Animator animator;
    private bool _takeAim;
    public GameObject crosshair;

    public float TimeBtwShoot;
    public float ShootTime;
    private bool _canShoot;

    private void Start()
    {
        animator = GetComponent<Animator>();
        _takeAim = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //_takeAim = !_takeAim;
            if (_takeAim == true)
            {
                crosshair.SetActive(false);
                animator.SetBool("TakeAim", true);
                _takeAim = false;
            }
            else
            {
                crosshair.SetActive(true);
                animator.SetBool("TakeAim", false);
                _takeAim = true;
            }
        }
    }
    void Shoot()
    {
        animator.SetTrigger("shoot");
    }
}
