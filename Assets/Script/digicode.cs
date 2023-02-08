using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digicode : MonoBehaviour
{
    // Start is called before the first frame update
    public string mdp;
    public string input;
    private float nmb_input;//nmb d'input nécessaire pour le mdp
    private float nmb_btn_click;//nmb d'input à la suite
    public AudioClip openDoor;
    public AudioClip digicode_correct;
    public AudioClip beep_wrong;
    public AudioSource digicode_source;
    public AudioSource door_source;
    public AudioSource Wdigicode_source;

    [SerializeField]
    private Transform _pivot;
    void Start()
    {
        nmb_btn_click = 0;
        nmb_input = mdp.Length;
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
                //son bon code
                digicode_source.clip = digicode_correct;
                digicode_source.Play();

                //lancement anim porte
                Debug.Log("c'est bon");

                _pivot.Rotate(0, _pivot.rotation.y - 90, 0);
                door_source.clip = openDoor;
                door_source.Play();
            }

            else
            {
                //Debug.Log(input);
                //Debug.Log(mdp);
                input = "";
                nmb_btn_click = 0;
                //son mauvais code
                Wdigicode_source.clip = beep_wrong;
                Wdigicode_source.Play();
                Debug.Log("c'est pas bon");
                
            }
        }
        
    }

    public void Input(string valueEntered)
    {
        nmb_btn_click++; // Add a guess
        input += valueEntered;
        
    }
}
