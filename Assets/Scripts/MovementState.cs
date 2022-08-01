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
    private int IndexActual;
    private List<int> posiciones;



    // Start is called before the first frame update
    void Start()
    {
        currentTile = 0;
        PlayerCurrentPosition(currentTile);
        TileBehivior(currentTile);
    }

    // Update is called once per frame
    void Update()
    {



    }




    public void playerMovement(int dieResult)
    {
        int thisTurnMovement = dieResult;
        Movement = thisTurnMovement;
        waitPlayer = true;
        StartCoroutine("loopForThePlayer", thisTurnMovement);
    }


    private void TileBehivior(int IndexTile)
    {
        Debug.Log("Estas en la casilla con el index" + IndexTile);
        tilePos = tiles[IndexTile].transform.position;
        IndexActual = IndexTile;

    }

    private void PlayerCurrentPosition(int currentPos)
    {
        int nigga;
        position = player.transform.position;
        nigga = currentPos;
    }


    private void PlayerNextPos()
    {
        player.transform.position = tilePos;

    }

    private IEnumerator loopForThePlayer(int thisTurnMovement)
    {
        int moveToTile;
        while (waitPlayer)
        {
            yield return null;
            if (thisTurnMovement > 0)
            {
                Debug.Log("Estas en la casilla: " + currentTile);
                switch (currentTile)
                {
                    default:
                        moveToTile = currentTile + 1;
                        Debug.Log("Te vas a mover a la casilla:  " + moveToTile);
                        TileBehivior(moveToTile);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        //if (currentTile != 3 || currentTile != 7 || currentTile != 10 || currentTile != 14 || currentTile != 11 || currentTile != 12 || currentTile != 13)
                        //{
                            thisTurnMovement--;
                        //}

                        currentTile = moveToTile;
                        Debug.Log("La siguiente casilla es:  " + currentTile);
                        
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }

                        break;

                    case 3:
                        if (waitPlayer)
                        {
                            Debug.Log("Waiting for player");
                            if (Input.GetKey(KeyCode.LeftArrow))
                            {
                                TileBehivior(6);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 6;
                                thisTurnMovement--;
                                waitPlayer = false;
                            }
                            if (Input.GetKey(KeyCode.RightArrow))
                            {
                                TileBehivior(4);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 4;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            Debug.Log("Te quedas en la casilla 3");
                            waitPlayer = false;
                        }
                        break;
                    case 5:
                        TileBehivior(8);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 8;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 7:
                        if (thisTurnMovement > 0)
                        {
                            Debug.Log("Waiting for player");
                            if (Input.GetKey(KeyCode.LeftArrow))
                            {
                                TileBehivior(5);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 5;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }
                            if (Input.GetKey(KeyCode.RightArrow))
                            {
                                TileBehivior(9);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 9;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }

                        }
                        else if (thisTurnMovement == 0 && !waitPlayer)
                        {
                            PlayerCurrentPosition(currentTile);
                            Debug.Log("Te quedas en la casilla 3");
                            waitPlayer = false;
                        }
                        break;
                    case 10:
                        if (thisTurnMovement > 0)
                        {
                            Debug.Log("Waiting for player");
                            if (Input.GetKey(KeyCode.LeftArrow))
                            {
                                TileBehivior(11);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 11;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }
                            if (Input.GetKey(KeyCode.RightArrow))
                            {
                                TileBehivior(14);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 14;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            Debug.Log("Te quedas en la casilla 3");
                            waitPlayer = false;
                        }
                        break;
                    case 11:
                        if (thisTurnMovement > 0)
                        {
                            Debug.Log("Waiting for player");
                            if (Input.GetKey(KeyCode.LeftArrow))
                            {
                                TileBehivior(13);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 13;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }
                            if (Input.GetKey(KeyCode.RightArrow))
                            {
                                TileBehivior(12);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                moveToTile = 12;
                                thisTurnMovement--;
                                waitPlayer = false;

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            Debug.Log("Te quedas en la casilla 3");
                            waitPlayer = false;
                        }
                        break;
                    case 12:

                        TileBehivior(15);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 15;
                        thisTurnMovement--;
                        Movement = 0;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }

                        break;
                    case 13:
                        TileBehivior(7);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        thisTurnMovement--;
                        currentTile = 7;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;

                    case 14:

                        TileBehivior(8);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 8;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;


                }
                Debug.Log("Te queda este movimiento: " + thisTurnMovement);

            }

            

        }


    }

}
