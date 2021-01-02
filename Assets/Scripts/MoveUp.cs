using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{
    private int currentLevel = 0;
    public MoveDown down;
    [SerializeField] GameObject farm;
    [SerializeField] GameObject wheat;
    [SerializeField] GameObject placeholder;
    [SerializeField] GameObject baracks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void changeLevelUp(){
        if (currentLevel == 1){
            down.changeInt();
            farm.SetActive(true);
            wheat.SetActive(true);
            placeholder.SetActive(true);
            baracks.SetActive(false);
            currentLevel = currentLevel - 1;
        }
    }

    public void changeInt(){
        currentLevel = currentLevel + 1;
    }
}
