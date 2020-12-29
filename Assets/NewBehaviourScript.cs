using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Beginn(string level){
        SceneManager.LoadScene(level);
    }

}
