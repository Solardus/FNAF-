using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightandAnamatronic : MonoBehaviour
{
    public bool foxyOn = false;
    public bool chicaOn = false;
    public bool freddyOn = false;
    public bool bonnieOn = false;
    public GameObject foxy;
    public GameObject chica ;
    public GameObject freddy ;
    public GameObject bonnie;
    public bool abletoturnonandoff = false;
    public int night = 1;
    // Start is called before the first frame update
    void Start()
    {   
        while(true)
        {
            
            if (night==1)
            {
                bonnieOn = true;
            }
            bonnieOn = false;
            foxyOn = false;
            chicaOn = false;
            freddyOn = false;
            abletoturnonandoff = false;
            if (night == 2)
            {
                bonnieOn = true;
                foxyOn = true;
            }
            bonnieOn = false;
            foxyOn = false;
            chicaOn = false;
            freddyOn = false;
            abletoturnonandoff = false;
            if (night == 3)
            {
                bonnieOn = true;
                foxyOn = true;
                chicaOn = true;
            }
            bonnieOn = false;
            foxyOn = false;
            chicaOn = false;
            freddyOn = false;
            abletoturnonandoff = false;
            if (night == 4)
            {
                bonnieOn = true;
                foxyOn = true;
                chicaOn = true;
                freddyOn = true;
            }
            bonnieOn = false;
            foxyOn = false;
            chicaOn = false;
            freddyOn = false;
            abletoturnonandoff = false;
            if (night == 5)
            {
                bonnieOn = true;
                foxyOn = true;
                chicaOn = true;
                freddyOn = true;
            }
            bonnieOn = false;
            foxyOn = false;
            chicaOn = false;
            freddyOn = false;
            abletoturnonandoff = false;
            if (night == 6)
            {
                bonnieOn = true;
                foxyOn = true;
                chicaOn = true;
                freddyOn = true;
                abletoturnonandoff = true;
            }
            break;
            
        }
        while (true)
        {

        }
  
    }

    
}
