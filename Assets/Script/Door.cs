using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Transform _pivot;
    [SerializeField]
    private float _speed;


    // True : Direction open
    // False : Direction close
    [SerializeField]
    bool _doorStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnSocketSelect(SelectEnterEventArgs args)
    {
        if(args.interactableObject.transform.tag == "key1" && _doorStatus == false)
        {
            _pivot.Rotate(0, _pivot.rotation.y - 90, 0);
            Debug.Log("porte open");
        }
        else
        {
            Debug.Log("Rien ne se passe");
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
