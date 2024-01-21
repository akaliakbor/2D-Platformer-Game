using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Enemy : MonoBehaviour
{
   // public AudioSource Dies;
    private Animator anim;
    private void start(){
        anim=GetComponent<Animator>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Bullet")){
            
             //anim.SetInteger("Die",1);
             //Dies.Play();
            

                Destroy(gameObject);

        }



    // Update is called once per frame
   
}


    
}
