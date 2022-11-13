using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GunMechanics : MonoBehaviour
{
    // Start is called before the first frame update
   // public PhotonView pv;
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

        
        if (SimpleInput.GetAxis("Vertical") > 0)
        {
            this.GetComponent<Animator>().SetBool("walk", true);
        }
        if (SimpleInput.GetAxis("Vertical") < 0)
        {
            this.GetComponent<Animator>().SetBool("walk", true);
        }
        if (SimpleInput.GetAxis("Vertical") == 0)
        {
            this.GetComponent<Animator>().SetBool("walk", false);
        }
        if (SimpleInput.GetAxis("Horizontal") > 0)
        {
            this.GetComponent<Animator>().SetBool("walk", true);
        }
        if (SimpleInput.GetAxis("Horizontal") < 0)
        {
            this.GetComponent<Animator>().SetBool("walk", true);
        }
    


            // disable for android


    
            if (Input.GetButton("Aim"))
            {
               // this.GetComponent<Animator>().SetBool("Aim", true);
                if (Input.GetButton("Fire1"))
                {
                    this.GetComponent<Animator>().SetBool("AimShot", true);

                }
                if (Input.GetButtonUp("Fire1"))
                {
                    this.GetComponent<Animator>().SetBool("AimShot", false);
                }

            }
            if (Input.GetButtonUp("Aim"))
            {
                this.GetComponent<Animator>().SetBool("Aim", false);
            }
            if (Input.GetButton("Fire1"))
            {
               // this.GetComponent<Animator>().SetBool("Shot", true);

            }
            if (Input.GetButtonUp("Fire1"))
            {
               // this.GetComponent<Animator>().SetBool("Shot", false);
            }
          
      


           
        
    }
   
   

}
