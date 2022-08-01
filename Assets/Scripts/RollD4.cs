using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RollD4 : MonoBehaviour
{
    // Array of dice sides sprites to load from Resources folder
    private Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;
    public bool eventIsDone = false;
    public GameObject Controller;
    [HideInInspector]
    public int finalSide = 0;


    // Start is called before the first frame update
    void Start()
    {
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("PNGs/dice/d4");

    }

    // If you left click over the dice then RollTheDice coroutine is started
    
    
    public void RollDice()
    {
        eventIsDone = false;

        if (!eventIsDone)
        {
            StartCoroutine("RollTheDice");
            eventIsDone = true;
            
        }      

    }
   
    


    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        MovementState Controlador = Controller.GetComponent<MovementState>();

        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 4);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
       
        finalSide = randomDiceSide + 1;
        Controlador.playerMovement(4);

    }

}
