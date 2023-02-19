using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour{

    public Color hoverColor;

    public Color notEnoughMoneyColor;

    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color[] startColors;

    BuildManager buildManager;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColors = new Color[rend.materials.Length];
        for (int i = 0; i < startColors.Length; i++)
        {
            startColors[i] = rend.materials[i].color;
        }

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown ()
    {
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        buildManager.BuildTurretOn(this);
    }

void OnMouseEnter()
{
    if (!buildManager.CanBuild)
    {
        return;
    }

    for (int i = 0; i < rend.materials.Length; i++)
    {
        if (buildManager.HasMoney)
        {
            rend.materials[i].color = hoverColor;
        }
        else
        {
            rend.materials[i].color = notEnoughMoneyColor;
        }
    }
}


    void OnMouseExit ()
    {
        for (int i = 0; i < startColors.Length; i++)
        {
            rend.materials[i].color = startColors[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

