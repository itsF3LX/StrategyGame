using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public Grid grid;
    public Tilemap floor;
    public Tilemap buildings;
    public Tilemap lightup;
    public Tile gras;
    public Tile light;
    public Tile placeholder = null;
    public Tilemap controls;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightup.ClearAllTiles();
        if (Input.GetMouseButtonDown(0) && placeholder != null){
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.x = mouseWorldPos.x - 0.5f;
            mouseWorldPos.y = mouseWorldPos.y - 0.5f;
            Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
            coordinate.z = 0;
            coordinate.x = coordinate.x - 1;
            coordinate.y = coordinate.y - 2;
            Debug.Log(coordinate);
            Debug.Log(floor.GetSprite(coordinate));
            if (buildings.GetTile(coordinate) == null && floor.GetTile(coordinate) == gras){
                buildings.SetTile(coordinate,placeholder);
                placeholder = null;
            }
        } else {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.x = mouseWorldPos.x - 0.5f;
            mouseWorldPos.y = mouseWorldPos.y - 0.5f;
            Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
            coordinate.z = 0;
            coordinate.x = coordinate.x - 1;
            coordinate.y = coordinate.y - 2;
            lightup.SetTile(coordinate, light);
            if (placeholder != null){
                controls.ClearAllTiles();
                controls.SetTile(coordinate,placeholder);
            }
        }
    }
    public void setTile(Tile tile){
        placeholder = tile;
    }

}
