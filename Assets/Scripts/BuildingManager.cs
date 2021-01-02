using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class BuildingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Grid grid;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject closeMenue;
    public Sprite rahmen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newBarack(Vector3Int place){
        GameObject barack = new GameObject();
        barack.AddComponent<Barack>();
        GameObject ngo = new GameObject("mNew Image");
        ngo.transform.SetParent(canvas.transform);
        ngo.AddComponent<Image>();
        ngo.AddComponent<SpriteRenderer>();
        ngo.GetComponent<SpriteRenderer>().sprite = rahmen;
        ngo.AddComponent<RectTransform>();
        RectTransform rt = ngo.GetComponent (typeof (RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2 (500, 300);
        rt.localScale = new Vector2 (1, 1);
        rt.transform.localPosition = new Vector3 (0, 40, 0);
        ngo.SetActive(false);
        GameObject button = new GameObject("NewButton");
        button.transform.SetParent(canvas.transform);
        button.AddComponent<RectTransform>();
        button.AddComponent<CanvasRenderer>();
        button.AddComponent<Image>();
        button.AddComponent<Button>();
        button.AddComponent<CloseMenue>();
        button.GetComponent<CloseMenue>().setEvents(ngo,button);
        button.SetActive(false);
        barack.GetComponent<Barack>().fixValues(grid, ngo, button, place);
    }

    public void newFarm(Vector3Int place){
        GameObject farm = new GameObject();
        farm.AddComponent<Farm>();
        GameObject ngo = new GameObject("mNew Image");
        ngo.transform.SetParent(canvas.transform);
        ngo.AddComponent<Image>();
        ngo.AddComponent<SpriteRenderer>();
        ngo.GetComponent<SpriteRenderer>().sprite = rahmen;
        ngo.AddComponent<RectTransform>();
        RectTransform rt = ngo.GetComponent (typeof (RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2 (500, 300);
        rt.localScale = new Vector2 (1, 1);
        rt.transform.localPosition = new Vector3 (0, 40, 0);
        ngo.SetActive(false);
        GameObject button = new GameObject("NewButton");
        button.transform.SetParent(canvas.transform);
        button.AddComponent<RectTransform>();
        button.AddComponent<CanvasRenderer>();
        button.AddComponent<Image>();
        button.AddComponent<Button>();
        button.AddComponent<CloseMenue>();
        button.GetComponent<CloseMenue>().setEvents(ngo,button);
        button.SetActive(false);
        farm.GetComponent<Farm>().fixValues(grid, ngo, button, place);
    }
}
