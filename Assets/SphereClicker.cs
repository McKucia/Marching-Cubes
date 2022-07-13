using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereClicker : MonoBehaviour
{ 
    void OnMouseDown(){
        switch(gameObject.name)
        {
            case "0":
                Manager.values[0]++;
                break;
            case "1":
                Manager.values[1]++;
                break;
            case "2":
                Manager.values[2]++;
                break;
            case "3":
                Manager.values[3]++;
                break;
            case "4":
                Manager.values[4]++;
                break;
            case "5":
                Manager.values[5]++;
                break;
            case "6":
                Manager.values[6]++;
                break;
            case "7":
                Manager.values[7]++;
                break;
        }

        GameObject go = GameObject.Find("Cube");
        MarchingCubes other = (MarchingCubes) go.GetComponent(typeof(MarchingCubes));
        other.Polygonise();
    }
}
