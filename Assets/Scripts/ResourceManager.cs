using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourceManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject menue;
    [SerializeField] GameObject button;
    [SerializeField] GameObject wood;
    public int woodAmount;
    [SerializeField] GameObject stone;
    public int stoneAmount;
    [SerializeField] GameObject wheat;
    public int wheatAmount;
    [SerializeField] GameObject water;
    public int waterAmount;
    [SerializeField] GameObject cole;
    public int coleAmount;
    [SerializeField] GameObject iron;
    public int ironAmount;
    [SerializeField] GameObject gold;
    public int goldAmount;
    Text counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        basicResources();
    }

    public void displayResources(){
        menue.SetActive(true);
        button.SetActive(true);
    }

    public void basicResources(){
        counter = wood.GetComponent<Text>();
        counter.text= " " + woodAmount + " ";
        counter = stone.GetComponent<Text>(); 
        counter.text= " " + stoneAmount + " ";
        counter = wheat.GetComponent<Text>(); 
        counter.text= " " + wheatAmount + " ";
        counter = water.GetComponent<Text>(); 
        counter.text= " " + waterAmount + " ";
        counter = cole.GetComponent<Text>(); 
        counter.text= " " + coleAmount + " ";
        counter = iron.GetComponent<Text>(); 
        counter.text= " " + ironAmount + " ";
        counter = gold.GetComponent<Text>(); 
        counter.text= " " + goldAmount + " ";
    }
}
//32,5 67,5 120