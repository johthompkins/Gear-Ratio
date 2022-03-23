using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public int Teeth { get; set; } //number of teeth on a gear
    public float ratio = 3; //ratio of two gears
    

    public bool isRotating = false; //bool to know if gear is rotating
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        //set number of gear teeth based on size
        switch (gameObject.tag)
        {
            case "small":
                Teeth = 5;
                ratio = 1.6f;
                break;

            case "medium":
                Teeth = 8 ;
                ratio = 1;
                break;

            case "large":
                Teeth = 8;
                ratio = 1;
                break;
        }   
    }

    void Update()
    {
        if (isRotating)
        {
            RotateGear();
        }
    }

    //Rotate gears based on position of chain
    public void RotateGear()
    {

        //rotate gear based of ratio
        gameObject.transform.Rotate(0, 0, speed * ratio * Time.deltaTime);

    }
}
