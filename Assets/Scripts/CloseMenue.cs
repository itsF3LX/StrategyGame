using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseMenue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject menu;
    [SerializeField] GameObject button;
    public void setEvents(GameObject menue, GameObject buton){
        menu = menue;
        button = buton;
        RectTransform rt = button.GetComponent (typeof (RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2 (30, 30);
        rt.localScale = new Vector2 (1, 1);
        rt.transform.localPosition = new Vector3 (235, 175, 0);
        Debug.Log(rt.transform.position);
        Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        btn.onClick.AddListener(TaskOnClick2);
    }
    public void TaskOnClick(){
        menu.SetActive(false);
    }

    public void TaskOnClick2(){
        button.SetActive(false);
    }
}
