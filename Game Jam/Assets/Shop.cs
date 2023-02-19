using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurrentBlueprint tower;
    public TurrentBlueprint magicTower;
    
    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTower ()
    {
        Debug.Log("Standard Tower Selected");
        buildManager.SelectTurretToBuild(tower);
    }

    public void SelectMagicTower ()
    {
        Debug.Log("Magic Tower Selected");
        buildManager.SelectTurretToBuild(magicTower);
    }
}
