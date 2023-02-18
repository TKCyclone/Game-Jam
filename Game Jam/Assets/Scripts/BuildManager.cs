using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turretToBuild;

    public static BuildManager instance;
        


    void Awake ()
    {

        if (instance != null){
            Debug.LogError("More than one build manager");
            return;
        }
        instance = this;

    }

    public GameObject towerPrefab;
    public GameObject magicTowerPrefab;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
