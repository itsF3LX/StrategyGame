using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3Int coordinates;
    public Grid grid;
    [SerializeField] GameObject menue;
    [SerializeField] GameObject closeMenue;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.x = mouseWorldPos.x - 0.5f;
            mouseWorldPos.y = mouseWorldPos.y - 0.5f;
            Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
            coordinate.z = 0;
            coordinate.x = coordinate.x - 1;
            coordinate.y = coordinate.y - 2;
            Debug.Log(coordinate);
            Debug.Log(coordinates);
            if(coordinate == coordinates){
                menue.SetActive(true);
                closeMenue.SetActive(true);
            }
        }
    }

    public void fixValues(Grid grit, GameObject menu, GameObject closeMenu, Vector3Int place){
        grid = grit;
        menue = menu;
        closeMenue = closeMenu;
        coordinates = place;
    }
}
