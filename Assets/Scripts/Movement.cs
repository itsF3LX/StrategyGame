using UnityEngine;
 
 public class Movement : MonoBehaviour
 {
     public int Speed = 1;
     public float zoomSpeed = 1;
     public float targetOrtho;
     public float smoothSpeed = 2.0f;
     public float minOrtho = 1.0f;
     public float maxOrtho = 20.0f;

     void Start() {
         targetOrtho = Camera.main.orthographicSize;
     }
     void Update()
     {
         float xAxisValue = Input.GetAxis("Horizontal") * Speed;
         float zAxisValue = Input.GetAxis("Vertical") * Speed;
         xAxisValue = xAxisValue / 100;
         zAxisValue = zAxisValue / 100;
         transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + zAxisValue, transform.position.z);
         float scroll = Input.GetAxis ("Mouse ScrollWheel");
         if (scroll != 0.0f) {
             targetOrtho -= scroll * zoomSpeed;
             targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
         }

         Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
         

     }

     
 }