using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehavior : MonoBehaviour
{
	private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }
	// Update is called once per frame
    void Update()
    {
       Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    	
       Vector2 direction = new Vector2(
       		mouseWorldPos.x - transform.position.x,
       		mouseWorldPos.y - transform.position.y
       );
       
       float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       
       transform.rotation = Quaternion.Euler(0, 0, targetAngle);
       		
        
    }
}
