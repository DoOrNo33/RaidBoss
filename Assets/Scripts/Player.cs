using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 WASD로 플레이어 위치값 수정
        if (Input.GetKey(KeyCode.W)) 
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, 0); 
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, 0);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        }

    }
}
