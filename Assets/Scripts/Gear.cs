using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public int Teeth { get; set; } //number of teeth on a gear
    public float ratio = 3; //ratio of two gears
    

    public bool isRotating = false; //bool to know if gear is rotating
    public float speed = 10;

    bool IsZoomed = false;

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
    private void OnMouseDown()
    {

        if (gameObject.transform.Find("/EventSystem").GetComponent<GameManager>().CanZoom && !IsZoomed)
        {
            Camera.main.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 60);
            IsZoomed = true;
            gameObject.transform.Find("/EventSystem").GetComponent<GameManager>().CanZoom = false;
        }
        else
        {
            Camera.main.transform.position = new Vector3(0, 0, 6.83f);
            IsZoomed = false;
        
        }
            
        
    }
}
