using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private TileManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        manager = FindObjectOfType<TileManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = transform.position + new Vector3(-0.73f, 0.8659766f/2);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0f, 0.8659766f);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            transform.position = transform.position + new Vector3(0.73f, 0.8659766f/2);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.73f, -0.8659766f/2);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0f, -0.8659766f);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.73f, -0.8659766f/2);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3Int gridPos = manager.map.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (manager.isWalkable(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {
                transform.position = manager.getPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                Debug.Log(transform.position);
            }
        }
    }
}
