using System;
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
        
        Movement = dieResult;
        int[] values = new int[2];


        switch (currentTile)
        {
            default:
                currentTile++;       
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();                        
                break;
        case 3:
        values[0] = 6;
        values[1] = 4;
        WaitForInput(values);
        if (currentTile == 6)
            {
                        
            TileBehivior(currentTile);
            PlayerCurrentPosition();
            PlayerNextPos();  

            }
            if (currentTile == 4)
            {
                        
            TileBehivior(currentTile);
            PlayerCurrentPosition();
            PlayerNextPos();
        
            }
            break;
        case 5:
            currentTile = 8;
            TileBehivior(currentTile);
            PlayerCurrentPosition();
            PlayerNextPos();
                       
            break;
        case 7:
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                currentTile = 5;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                            

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                currentTile = 9;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                            
            }
            break;
        case 10:
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                currentTile = 11;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                            

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                currentTile = 14;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                            
            }
            break;
        case 11:
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                currentTile = 13;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                           

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                currentTile = 12;
                TileBehivior(currentTile);
                PlayerCurrentPosition();
                PlayerNextPos();
                            
            }
            break;
        case 12:
            currentTile = 15;
            TileBehivior(currentTile);
            PlayerCurrentPosition();
            PlayerNextPos();
                        
            Movement = 0;

            break;
        case 14:
            currentTile = 8;
            TileBehivior(currentTile);
            PlayerCurrentPosition();
            PlayerNextPos();
                     
            break;
                    
        }      
            

        Debug.Log("Estas en la casilla: " + currentTile);
        Debug.Log("Estas en el movimiento: " + dieResult);

    }


    private void TileBehivior(int IndexTile)
    {
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

    void WaitForInput(int[] values)
    {
        int left = values[0];
        int right = values[1];
        new WaitUntil(() => Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow));
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentTile = left;
           
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentTile = right;        
        }

    }

}