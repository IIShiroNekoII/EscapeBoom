using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class DesctructibleWall : MonoBehaviour
{
    [SerializeField]
    public GameObject _topBomb;

    [SerializeField]
    public GameObject _midBomb;

    [SerializeField]
    public GameObject _botBomb;

    // t_completeBomb[0] = TopBomb
    // t_completeBomb[1] = MidBomb
    // t_completeBomb[2] = BotBomb
    private int[] t_completeBomb = new int[3] { 0,0,0 };


    float _timeCount = 5;


    // Start is called before the first frame update
    void Start()
    { 
    }

    public void OnSocketSelect(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.name == "TopBomb" && args.interactableObject.transform.tag == "TopBomb")
        {
            //Debug.Log(_topBomb.transform.name + " and " + args.interactableObject.transform.tag);
            //Debug.Log("good job");
            t_completeBomb[0] = 1;
            //Debug.Log("Enter : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
        }
        else if (args.interactorObject.transform.name == "MidBomb" && args.interactableObject.transform.tag == "MidBomb")
        {
            //Debug.Log(_midBomb.transform.name + " and " + args.interactableObject.transform.tag);
            //Debug.Log("good job");
            t_completeBomb[1] = 1;
            //Debug.Log("Enter : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
        }
        else if (args.interactorObject.transform.name == "BotBomb" && args.interactableObject.transform.tag == "BotBomb")
        {
            //Debug.Log(_botBomb.transform.name + " and " + args.interactableObject.transform.tag);
            //Debug.Log("good job");
            t_completeBomb[2] = 1;
            //Debug.Log("Enter : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
        }
        else
        {
            //Debug.Log(args.interactorObject.transform.name + " and " + args.interactableObject.transform.tag);
            //Debug.Log("Enter : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
        }

        if (t_completeBomb[0] == 1 && t_completeBomb[1] == 1 && t_completeBomb[2] == 1)
        {
            
            Destroy(gameObject);
        }
    }

    public void OnSocketExit(SelectExitEventArgs args)
    {
        switch(args.interactorObject.transform.name)
        {
            case "TopBomb":
                //Debug.Log("Top Bomb vide");
                t_completeBomb[0] = 0;
                //Debug.Log("Exit : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
                break;

            case "MidBomb":
                //Debug.Log("Mid Bomb vide");
                t_completeBomb[1] = 0;
                //Debug.Log("Exit : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
                break;

            case "BotBomb":
                //Debug.Log("Bot Bomb vide");
                t_completeBomb[2] = 0;
                //Debug.Log("Exit : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
                break;

            default:
                Debug.Log("Bug, Aucune détection de socket");
                break;
        }

        


        //if(args.interactorObject.transform.name == "TopBomb")
    }

   

    // Update is called once per frame
    void Update()
    {
        _timeCount -= Time.deltaTime;
        if (_timeCount < 0)
        {
            Debug.Log("Valeur dans le tableau : " + t_completeBomb[0] + t_completeBomb[1] + t_completeBomb[2]);
            _timeCount = 2;
        }
    }
}
