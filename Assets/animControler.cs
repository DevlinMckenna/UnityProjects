using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControler : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d")){
            
          

           anim.Play("LeafAttack", 0, 0.0f);
            
            }

        if (Input.GetKeyDown("s")){
            
           

           anim.Play("WaterBallAttack", 0, 0.0f);
            
            }

        if (Input.GetKeyDown("a")){
            
         

           anim.Play("FireAttack", 0, 0.0f);
            
            }
        
    }
}
