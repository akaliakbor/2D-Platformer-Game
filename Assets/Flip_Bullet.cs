using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip_Bullet : MonoBehaviour
{
        private bool facing_right=true;

    private float dx = 0f;
    void Update(){
            dx= Input.GetAxisRaw("Horizontal");

              if(dx > 0f && !facing_right){
        
             //sp.flipX=false;
            flip();
        }
        else if(dx < 0f && facing_right){
           
            //sp.flipX=true;
           flip();
        }
        /*else{
            transform.Rotate(0f,180f,0f);
        }*/
        
    }

    void flip(){
        facing_right=!facing_right;
        transform.Rotate(0f,180f,0f);
    }
    

    




}
