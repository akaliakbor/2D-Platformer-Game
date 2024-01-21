using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletprefab;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot(){
        Instantiate(bulletprefab,firePoint.position,firePoint.rotation);
    }
}
