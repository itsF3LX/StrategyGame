using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDown : MonoBehaviour
{
    private int currentLevel = 0;
    public MoveUp up;
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
    
    public void changeLevelDown(){
        if (currentLevel == 0){
            up.changeInt();
            farm.SetActive(false);
            wheat.SetActive(false);
            placeholder.SetActive(false);
            baracks.SetActive(true);
            currentLevel = currentLevel + 1;
        }
    }

    public void changeInt(){
        currentLevel = currentLevel - 1;
    }
}