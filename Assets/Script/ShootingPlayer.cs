// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ShootingPlayer : MonoBehaviour
// {
//     public GameObject bullet;

//     //bullet force
//     public float shootForce,
//         upwardForce;

//     //Gun stats
//     public float timeBetweenShooting,
//         spread,
//         reloadTime,
//         timeBetweenShots;
//     public int magazineSize,
//         bulletsPerTap;
//     public bool allowButtonHold;

//     int bulletsLeft,
//         bulletsShot;

//     //Recoil
//     public Rigidbody PlayerBody;
//     public float recoilForce;

//     //bools
//     bool shooting,
//         readyToShoot,
//         reloading;

//     //Reference
//     public Camera fpsCam;
//     public Transform attackPoint;

//     //Graphics
//     public GameObject muzzleFlash;

//     // public TextMeshProUGUI ammunitionDisplay;

//     //bug fixing :D
//     public bool allowInvoke = true;

//     private void Awake()
//     {
//         //make sure magazine is full
//         bulletsLeft = magazineSize;
//         readyToShoot = true;
//     }

//     private void Update()
//     {
//         MyInput();

//         //Set ammo display, if it exists :D
//         if (ammunitionDisplay != null)
//             ammunitionDisplay.SetText(
//                 bulletsLeft / bulletsPerTap + " / " + magazineSize / bulletsPerTap
//             );
//     }

//     private void MyInput()
//     {
//         //Check if allowed to hold down button and take corresponding input
//         if (allowButtonHold)
//         {
//             shooting = Input.GetKey(KeyCode.Mouse0);
//         }
//         else
//         {
//             shooting = Input.GetKeyDown(KeyCode.Mouse0);
//         }

//         //Shooting
//         if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
//         {
//             //Set bullets shot to 0
//             bulletsShot = 0;

//             Shoot();
//         }
//     }

//     private void Shoot()
//     {
//         readyToShoot = false;

//         bulletsLeft--;
//         bulletsShot++;
//     }
// }
