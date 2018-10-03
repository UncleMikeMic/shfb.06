using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LE_LevelEditor.Events;


public class boxSelection : MonoBehaviour {

    public GameObject boxMenu;
    public GameObject boxSpawnPoint;


    [Header("Boxes")]
    public GameObject box0;



    public void ShowBoxMenu()
    {
        boxMenu.SetActive(true);
    }

    public void HideBoxMenu()
    {
        boxMenu.SetActive(false);
    }

    public void SelectBox0()
    {
        //place box at spawn point
        Instantiate(box0, boxSpawnPoint.transform.position, boxSpawnPoint.transform.rotation);

        //hide box menu
        HideBoxMenu();
    }
}
