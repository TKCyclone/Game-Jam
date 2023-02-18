using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager BuildManager;

    void Start ()
    {
        BuildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        Debug.Log("Standard Tower Purchased");
        BuildManager.SetTurretToBuild(BuildManager.towerPrefab);
    }

    public void PurchaseAnotherTurret ()
    {
        Debug.Log("Magic Tower Selected");
        BuildManager.SetTurretToBuild(BuildManager.magicTowerPrefab);
    }
}
