using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour{

    public Color hoverColor;

    public Vector3 positionOffset;

    private GameObject turret;

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

    void OnMouseDown ()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;

        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
       turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter ()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;

        for (int i = 0; i < rend.materials.Length; i++)
        {
            rend.materials[i].color = hoverColor;
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

