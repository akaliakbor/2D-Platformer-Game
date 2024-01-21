using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item_collection : MonoBehaviour
{
   
    private int cherries=0;
    [SerializeField] private AudioSource collectsound;
    [SerializeField]  private Text cherriesText;
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Cherry")){
            collectsound.Play();
            Destroy(collision.gameObject); 
            cherries++;
            cherriesText.text="Score: " + cherries;
        }
    }
}
