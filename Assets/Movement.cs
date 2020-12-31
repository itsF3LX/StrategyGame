using UnityEngine;
 
 public class Movement : MonoBehaviour
 {
     public int Speed = 1;
 
     void Update()
     {
         float xAxisValue = Input.GetAxis("Horizontal") * Speed;
         float zAxisValue = Input.GetAxis("Vertical") * Speed;
         xAxisValue = xAxisValue / 5000;
         zAxisValue = zAxisValue / 5000;
         transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + zAxisValue, transform.position.z);
     }
 }
