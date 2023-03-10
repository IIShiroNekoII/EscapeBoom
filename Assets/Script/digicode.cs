using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digicode : MonoBehaviour
{
    // Start is called before the first frame update
    public string mdp;
    public string input;
    private float nmb_input;//nmb d'input n?cessaire pour le mdp
    private float nmb_btn_click;//nmb d'input ? la suite
    public AudioClip openDoor;
    public AudioClip digicode_correct;
    public AudioClip beep_wrong;
    public AudioSource digicode_source;
    public AudioSource door_source;
    public AudioSource Wdigicode_source;
    private bool doorStatus;
    private bool digicodeStatus;

    [SerializeField]
    private Transform _pivot;
    void Start()
    {
        nmb_btn_click = 0;
        nmb_input = mdp.Length;
        doorStatus = false;
        digicodeStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nmb_btn_click == nmb_input)
        {
            if (input == mdp)
            {
                input = "";
                nmb_btn_click = 0;
                if (digicodeStatus == false)
                {
                    digicodeStatus = true;
                    //son bon code
                    digicode_source.clip = digicode_correct;
                    digicode_source.Play();
                }

                //Debug.Log("c'est bon");
                //lancement anim porte
                if (doorStatus == false)
                {
                    doorStatus = true;
                    _pivot.Rotate(0, _pivot.rotation.y - 90, 0);
                    door_source.clip = openDoor;
                    door_source.Play();
                }
            }

            else
            {
                //Debug.Log(input);
                //Debug.Log(mdp);
                input = "";
                nmb_btn_click = 0;
                //son mauvais code
                if (digicodeStatus == false)
                {
                    Wdigicode_source.clip = beep_wrong;
                    Wdigicode_source.Play();
                    Debug.Log("c'est pas bon");
                }
                
                
            }
        }
        
    }

    public void Input(string valueEntered)
    {
        nmb_btn_click++; // Add a guess
        input += valueEntered;
        
    }
}
