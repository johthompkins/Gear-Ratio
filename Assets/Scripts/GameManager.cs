using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Gear
{

    private List<Gear> gearList = new List<Gear>(); // list of gears in scene
    public bool CanZoom = false;

    //stop rotating gears based on position of chain
    public void StopRotatingGear()
    {
        foreach (Gear gear in gearList)
        {
            gear.isRotating = false;
        }
    }
    //Create list of gears and set them to rotate on call
    public void RotatingGear()
    {

        GenerateGearList();
        int gearNumber = 0; ;
        foreach (Gear gear in gearList)
        {
            if (gearNumber % 2 == 0)
            {
                gear.ratio = gear.ratio * -1;
            }
            gear.isRotating = true;
            gearNumber++;
        }
    }

    //Create a list of all gears in the scene
    public void GenerateGearList()
    {
        gearList = new List<Gear>();
        foreach (Transform child in gameObject.transform.Find("/Canvas/Gears"))
        {
            gearList.Add(child.gameObject.GetComponent<Gear>());
        }
    }

    //Reverse the rotation direction
    public void ReverseRotation()
    {
        foreach (Gear gear in gearList)
        {
            gear.ratio = gear.ratio * -1;
        }
    }
    
    //Zoom on object
    public void ZoomFunctionality()
    {
       if(CanZoom == false)
        {
            CanZoom = true;
        }
       
    }

}