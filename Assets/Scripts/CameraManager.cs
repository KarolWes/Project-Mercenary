using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject _player;

    public TileManager _map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        var camPos = Camera.main.transform.position;
        if (Vector2.Distance((Vector2)_player.transform.position, (Vector2)camPos) >=3)
        {
            var dir = new Vector2 ();
            var playerPos = _player.transform.position;
            dir = (Vector2)(camPos - playerPos);
            camPos = new Vector3 (camPos.x - dir.x, camPos.y - dir.y, camPos.z);
            Camera.main.transform.position = camPos;
        }
    }
}
