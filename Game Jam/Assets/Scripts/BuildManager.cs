using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private TurrentBlueprint turretToBuild;

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
    public GameObject buildEffect;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money to buy");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        Vector3 buildPos = node.GetBuildPosition() + turretToBuild.offset;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, buildPos, Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, buildPos, Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log ("Turret build! Money left: " + PlayerStats.Money);
    }

    public void SelectTurretToBuild (TurrentBlueprint turret)
    {
        turretToBuild = turret;
    }

}
