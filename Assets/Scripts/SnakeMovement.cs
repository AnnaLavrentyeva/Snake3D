using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;

    public float Zoffset = -0.5f;

    public GameObject TailPrefab;
    public Text scotreText;
    public int score = 0;
    public List<GameObject> tailObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        tailObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.up * -1 * rotationSpeed * Time.deltaTime);
        }
        scotreText.text = score.ToString();
      
    }

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= Zoffset;

        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);

    }
}
