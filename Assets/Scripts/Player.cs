using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private WeaponBase myWeapon;
    private bool weaponshootToggle;


    private void Start()
    {
        InputManager.Init(this);
        InputManager.EnableInGame();
    }

    public void Shoot()
    {
        print("I shot: " + InputManager.GetCameraRay());
        weaponshootToggle = !weaponshootToggle;
        if(weaponshootToggle) myWeapon.StartShooting();
        else myWeapon.StopShooting();
    }
}
