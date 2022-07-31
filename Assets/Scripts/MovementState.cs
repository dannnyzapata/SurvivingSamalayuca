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
    public GameObject d4;
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
        int thisTurnMovement = dieResult;
        Movement = thisTurnMovement;
        do
        {
            Debug.Log("Te queda este movimient: " + thisTurnMovement);

            if (thisTurnMovement > 0)
            {
                switch (currentTile)
                {
                    default:
                        currentTile++;
                        TileBehivior(currentTile);
                        PlayerCurrentPosition();
                        PlayerNextPos();
                        thisTurnMovement--;
                        break;
                    case 3:
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            currentTile = 6;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;

                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            currentTile = 4;
                            TileBehivior(currentTile);
                            PlayerCurrentPosition();
                            PlayerNextPos();
                            thisTurnMovement--;
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
                Debug.Log("Estas en la casilla: " + currentTile);
            }

        }
        while (thisTurnMovement > 0);
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
}
