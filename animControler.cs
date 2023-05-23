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
            
          anim.SetBool("isCasting",true);
           anim.SetBool("isCastingLeaf",true);
          // Debug.Log("Test d");
           //anim.Play("LeafAttack", 0, 0.0f);
            
            }

      else if (Input.GetKeyDown("s")){
            
           
           anim.SetBool("isCasting",true);
           anim.SetBool("isCastingWater",true);
       //    Debug.Log(isCastingWater);
        //   anim.Play("WaterBallAttack", 0, 0.0f);
            
            }

       else if (Input.GetKeyDown("a")){
            
         
           anim.SetBool("isCasting",true);
           anim.SetBool("isCastingFire",true);
          // anim.Play("FireAttack", 0, 0.0f);
            
            }
            else{
                anim.SetBool("isCasting",false);
                anim.SetBool("isCastingFire",false);
                anim.SetBool("isCastingWater",false);
                anim.SetBool("isCastingLeaf",false);}
        
    }
}
