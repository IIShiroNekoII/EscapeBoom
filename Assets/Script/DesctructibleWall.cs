using System.Collections;
using System.Collections.Generic;
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


    // Start is called before the first frame update
    void Start()
    { 
    }

    public void OnSocketSelect(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.name == "TopBomb" && args.interactableObject.transform.tag == "TopBomb")
        {
            Debug.Log(_topBomb.transform.name + " and " + args.interactableObject.transform.tag);
            Debug.Log("good job");
            t_completeBomb[0] = 1;
            return;
        }
        

        if (args.interactorObject.transform.name == "MidBomb" && args.interactableObject.transform.tag == "MidBomb")
        {
            Debug.Log(_midBomb.transform.name + " and " + args.interactableObject.transform.tag);
            Debug.Log("good job");
            t_completeBomb[1] = 1;
            return;
        }
        

        if (args.interactorObject.transform.name == "BotBomb" && args.interactableObject.transform.tag == "BotBomb")
        {
            Debug.Log(_botBomb.transform.name + " and " + args.interactableObject.transform.tag);
            Debug.Log("good job");
            t_completeBomb[2] = 1;
            return;
        }
       

        Debug.Log(args.interactorObject.transform.name + " and " + args.interactableObject.transform.tag);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
