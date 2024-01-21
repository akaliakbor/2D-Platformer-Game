using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Hit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        //if(collision.gameObject.CompareTag("Bullet")){
                Destroy(gameObject);

      //  }

    // Update is called once per frame
   
}
}
