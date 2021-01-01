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
    public Tile highlight;
    public Tile placeholder = null;
    public Tilemap controls;
    public Tile wheat;
    public Tile farm;
    public Tile fuckButtons;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightup.ClearAllTiles();
        controls.ClearAllTiles();
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
                if (placeholder==wheat){
                    Vector3Int saveSpot = coordinate;
                    saveSpot.y = saveSpot.y + 1;
                    Vector3Int LeftTop = saveSpot;
                    saveSpot.y = saveSpot.y - 2;
                    Vector3Int RightBottom = saveSpot;
                    saveSpot.y = saveSpot.y + 1;
                    saveSpot.x = saveSpot.x + 1;
                    Vector3Int RightTop = saveSpot;
                    saveSpot.x = saveSpot.x - 2;
                    Vector3Int LeftBottom = saveSpot;
                    if (buildings.GetTile(LeftBottom) == wheat || buildings.GetTile(LeftTop) == wheat || buildings.GetTile(RightBottom) == wheat || buildings.GetTile(RightTop) == wheat || buildings.GetTile(LeftBottom) == farm || buildings.GetTile(LeftTop) == farm || buildings.GetTile(RightBottom) == farm || buildings.GetTile(RightTop) == farm){
                        fuckButtons = null;
                        buildings.SetTile(coordinate,placeholder);
                        placeholder = null;
                    }
                } else {
                fuckButtons = null;
                buildings.SetTile(coordinate,placeholder);
                placeholder = null;
                }
            }
            // if (fuckButtons == null){
            //     buildings.SetTile(coordinate, null);
            //     fuckButtons = farm;
            // }
        } else {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.x = mouseWorldPos.x - 0.5f;
            mouseWorldPos.y = mouseWorldPos.y - 0.5f;
            Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
            coordinate.z = 0;
            coordinate.x = coordinate.x - 1;
            coordinate.y = coordinate.y - 2;
            lightup.SetTile(coordinate, highlight);
            if (placeholder != null){
                controls.ClearAllTiles();
                controls.SetTile(coordinate,placeholder);
            }
        }
    }
    public void setTile(Tile tile){
        placeholder = tile;
    }

    public void placeNoTile(){
        placeholder = null;
    }
}
