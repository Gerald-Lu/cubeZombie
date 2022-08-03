using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAR : MonoBehaviour {
 
    public Rigidbody projectile;
    public GunSystem gunScript;
    public float speed = 20;
 
    public float TimeLeft = 5;
    private double spawn;
    private float timer;
 
    // Use this for initialization
    void Start () {
        spawn = 0.1;
        timer = 0;
        gunScript = GameObject.FindObjectOfType<GunSystem>();

    }
   
    // Update is called once per frame
    void Update () 
    {
        timer += Time.deltaTime;
        Shoot();
        
    }
    public void Shoot(){
        if (Input.GetButton("Fire1") && timer >= spawn && gunScript.bulletsLeft > 0)
            {
                gunScript.readyToShoot = false;
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
    
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
                Debug.Log("Shot");
                timer = 0;
                gunScript.bulletsLeft--;
                gunScript.bulletsShot--;

            }
    }
}
