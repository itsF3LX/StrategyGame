using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    public int width;
    public int height;
    static bool wheretogo = false;
    // Start is called before the first frame update
    // public void Start(){
    //     m_someOtherScriptOnAnotherGameObject.Test();
    // }

    public void Beginn(string level){
        SceneManager.LoadScene(level);
    }

    public void setWidth(int newWidth){
        width = newWidth;
    }

    public void setHeight(int newHeight){
        height = newHeight;
    }

    public void SetRes(){
        Screen.SetResolution(width,height,false);
    }

    public void MainMenue(){
        SceneManager.LoadScene("Main Menue");
    }

    public void GameScene(){
        SceneManager.LoadScene("GameScene");
    }

    public void Settings(){
        SceneManager.LoadScene("Settings");
    }

    public void GameToSettings(){
        wheretogo = true;
        SceneManager.LoadScene("Settings");
    }

    public void Return(){
        if (wheretogo){
            wheretogo = false;
            SceneManager.LoadScene("GameScene");
        } 
        else {
            SceneManager.LoadScene("Main Menue");
        }
    }
}
