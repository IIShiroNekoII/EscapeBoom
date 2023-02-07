using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private float _speed;


    // True : Direction open
    // False : Direction close
    [SerializeField]
    bool _doorStatus;

    [SerializeField]
    bool _canMove;

    [SerializeField]
    bool _canDisappear;

    float _timeCount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "key1")
        {

        }
    }


    // Update is called once per frame
    void Update()
    {




























        _timeCount -= Time.deltaTime;

        if (_timeCount < 0)
        {
            if (_direction)
            {
                _direction = false;
                _timeCount = _maxTimeCount;
                transform.parent.Rotate(0, this.transform.rotation.y + 90, 0);
            }
            else
            {
                transform.parent.Rotate(0, this.transform.rotation.y - 90, 0);
                _direction = true;
                _timeCount = _maxTimeCount;
                
            }
        }

        if (_canMove)
        {
    
               



             

        }
    }
}
