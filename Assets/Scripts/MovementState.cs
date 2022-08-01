using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementState : MonoBehaviour
{
    private int currentTile;
    private int Movement = 1;
    [SerializeField]
    public List<GameObject> tiles;
    [SerializeField]
    public GameObject player;    
    private Vector2 position;
    private Vector2 tilePos;
    private bool waitPlayer;



    // Start is called before the first frame update
    void Start()
    {
        currentTile = 0;
        PlayerCurrentPosition();
        TileBehivior(currentTile);
    }

    // Update is called once per frame
    void Update()
    {
        
               

    }

    


    public void playerMovement(int dieResult)
    {
        //RollD4 Controlador = d4.GetComponent<RollD4>();
        //int thisTurnMovement;
        //Movement = Controlador.finalSide;
        //thisTurnMovement = Movement;
        int thisTurnMovement = dieResult;
        Movement = thisTurnMovement;
        waitPlayer = true;
        int moveToTile = currentTile;
        
        for(int i = 0; i<Movement; i++) 
        {           
            if (thisTurnMovement > 0)
            {
                
                switch (moveToTile)
                {
                    case 0:
                    case 1:
                    case 2:
                        Debug.Log("Estas en la casilla: " + currentTile);                       
                        moveToTile = currentTile + 1;
                        Debug.Log("Te vas a mover a la casilla:  " + moveToTile);
                        TileBehivior(currentTile);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        currentTile = moveToTile + 1;
                        Debug.Log("La siguiente casilla es:  " + currentTile);
                        thisTurnMovement--;
                        break;
                    case 3:
                        
                        if (thisTurnMovement > 0)                      
                        {                           
                            if (waitPlayer)
                            {
                                Debug.Log("Waiting for player");
                                if (Input.GetKey(KeyCode.UpArrow))
                                {
                                    Debug.Log("Clicked Arrow Up");
                                    thisTurnMovement--;
                                    waitPlayer = false;
                                }
                                /*
                                if (Input.GetKey(KeyCode.LeftArrow))
                                {
                                    TileBehivior(6);
                                    PlayerCurrentPosition();
                                    PlayerNextPos();
                                    moveToTile = 6;
                                    waitPlayer = false;
                                    
                                }
                                if (Input.GetKey(KeyCode.RightArrow))
                                {
                                    TileBehivior(4);
                                    PlayerCurrentPosition();
                                    PlayerNextPos();
                                    moveToTile = 4;
                                    waitPlayer = false;
                                    
                                }
                            */
                            }


                        }
                        else if (thisTurnMovement == 0 && !waitPlayer)
                        {
                            PlayerCurrentPosition();
                            Debug.Log("Te quedas en la casilla 3");
                        }
            
                        break;
                    case 5:
                        currentTile = 8;
                        TileBehivior(currentTile);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        thisTurnMovement--;
                        break;
                    case 7:
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            currentTile = 5;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;

                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            currentTile = 9;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;
                        }
                        break;
                    case 10:
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            currentTile = 11;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;

                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            currentTile = 14;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;
                        }
                        break;
                    case 11:
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            currentTile = 13;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;

                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            currentTile = 12;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;
                        }
                        break;
                    case 12:
                        currentTile = 15;
                        TileBehivior(currentTile);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        thisTurnMovement--;
                        Movement = 0;

                        break;
                    case 13:                        
                        TileBehivior(7);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        thisTurnMovement--;
                        currentTile = 7;
                        break;
                    case 14:
                        currentTile = 8;
                        TileBehivior(currentTile);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        thisTurnMovement--;
                        break;
                    
                }
                if (thisTurnMovement == 0)
                {
                    Movement = 0;
                    Debug.Log("Sin movimiento");
                }
                Debug.Log("Te queda este movimiento: " + thisTurnMovement);
                
            }

        }
        
    }


    private void TileBehivior(int IndexTile)
    {
        Debug.Log("Estas en la casilla con el index" + IndexTile);
        tilePos = tiles[IndexTile].transform.position;
    }

    private void PlayerCurrentPosition()
    {
        position = player.transform.position;
        
    }


    private void PlayerNextPos()
    {
        player.transform.position = tilePos;
        PlayerCurrentPosition();
    }

    IEnumerator waitForInputs()
    {


        yield return null;
    }

 }
