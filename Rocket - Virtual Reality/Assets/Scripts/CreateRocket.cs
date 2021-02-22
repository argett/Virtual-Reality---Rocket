﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRocket : MonoBehaviour
{
    public GameObject rocket;
    public GameObject[] coiffe;
    public GameObject[] carburant;
    public GameObject[] moteur;

    private bool stage_completed;
    private GameObject rocketPart_recentlyCreated;

    // Start is called before the first frame update
    void Start()
    {
        stage_completed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeObject(GameObject part)
    {
        float rocketPad_heigth = 3;
        float objSize;

        /* get the size of the object to pushup the entire rocket of the same value to place the new part under it */
        if (part.name == "Engine_1(Clone)" || part.name == "Engine_2(Clone)" || part.name == "Engine_3(Clone)")
            objSize = part.GetComponent<MeshRenderer>().bounds.size.x;
        else
            objSize = part.GetComponent<MeshRenderer>().bounds.size.y; // we take its eight

        rocket.transform.position += new Vector3(0, objSize, 0);
        /* ------------------------- */

        Transform parent = rocket.transform.parent;

        switch (part.name)
        {
            case "Coiffe_1(Clone)":
                rocketPart_recentlyCreated = Instantiate(coiffe[0], new Vector3(parent.position.x, objSize + rocketPad_heigth, parent.position.z), Quaternion.Euler(0, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                break;
            case "Coiffe_2(Clone)":
                rocketPart_recentlyCreated = Instantiate(coiffe[1], new Vector3(parent.position.x, objSize + rocketPad_heigth, parent.position.z), Quaternion.Euler(0, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                break;
            case "Coiffe_3(Clone)":
                rocketPart_recentlyCreated = Instantiate(coiffe[2], new Vector3(parent.position.x, objSize + rocketPad_heigth, parent.position.z), Quaternion.Euler(0, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                break;
            case "Tank_1(Clone)":
                rocketPart_recentlyCreated = Instantiate(carburant[0], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = false;
                break;
            case "Tank_2(Clone)":
                rocketPart_recentlyCreated = Instantiate(carburant[1], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = false;
                break;
            case "Tank_3(Clone)":
                rocketPart_recentlyCreated = Instantiate(carburant[2], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 0f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = false;
                break;
            case "Engine_1(Clone)":
                rocketPart_recentlyCreated = Instantiate(moteur[0], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 90f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = true ;
                break;
            case "Engine_2(Clone)":
                rocketPart_recentlyCreated = Instantiate(moteur[1], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 90f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = true;
                break;
            case "Engine_3(Clone)":
                rocketPart_recentlyCreated = Instantiate(moteur[2], new Vector3(parent.position.x, objSize/2 + rocketPad_heigth, parent.position.z), Quaternion.Euler(0f, 0f, 90f), rocket.transform);
                rocketPart_recentlyCreated.layer = 8;
                stage_completed = true;
                break;
            default:
                Debug.Log("Problem selecting a rocket part in script CreateRocke");
                break;
        }        
    }

    public bool isStageCompleted()
    {
        return stage_completed;
    }

    public void stageCreation()
    {
        stage_completed = false;
    }
}