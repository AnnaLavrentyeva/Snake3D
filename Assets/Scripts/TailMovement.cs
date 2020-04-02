using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float speed;

    public Vector3 tailTarget;

    public GameObject tailTargetObj;

    public int index;

    public SnakeMovement mainSnake;
    void Start()
    {
        
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed = mainSnake.speed + 1.5f;

        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
   
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain")) {
            if (index > 2) {
                Application.LoadLevel(Application.loadedLevel); // Hit tail
            }
        }
    }

}
