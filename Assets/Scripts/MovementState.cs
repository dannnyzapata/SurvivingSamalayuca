using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementState : MonoBehaviour
{
    public TextMeshProUGUI numeroDeMovimientoRestante;
    private int currentTile;
    [SerializeField]
    public List<GameObject> tiles;
    public GameObject player;    
    [HideInInspector]
    private Vector2 position;
    private Vector2 tilePos;
    private bool waitPlayer;
    private int IndexActual;
    



    // Start is called before the first frame update
    void Start()
    {
        currentTile = 0;
        PlayerCurrentPosition(currentTile);
        TileBehivior(currentTile);
        waitPlayer = true;
    }


    public void playerMovement(int dieResult)
    {      
        int thisTurnMovement = dieResult;
        waitPlayer = true;
        StartCoroutine("loopForThePlayer", thisTurnMovement);
        
    }


    private void TileBehivior(int IndexTile)
    {
        
        tilePos = tiles[IndexTile].transform.position;
        IndexActual = IndexTile;

    }

    private void PlayerCurrentPosition(int currentPos)
    {
        int posactual;
        position = player.transform.position;
        posactual = currentPos;
    }


    private void PlayerNextPos()
    {
        player.transform.position = tilePos;

    }

    private IEnumerator loopForThePlayer(int thisTurnMovement)
    {
        
        while (waitPlayer)
        {
            numeroDeMovimientoRestante.SetText((thisTurnMovement).ToString());
            yield return null;
            if (thisTurnMovement > 0)
            {               
                switch (IndexActual)
                {
                    case 0:
                        StartCoroutine("Esperador");
                        TileBehivior(1);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 1;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 1:
                        StartCoroutine("Esperador");
                        TileBehivior(2);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 2;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 2:
                        StartCoroutine("Esperador");
                        TileBehivior(3);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 3;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 4:
                        StartCoroutine("Esperador");
                        TileBehivior(5);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 5;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 6:
                        StartCoroutine("Esperador");
                        TileBehivior(7);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 7;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 8:
                        StartCoroutine("Esperador");
                        TileBehivior(9);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 9;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;
                    case 9:
                        StartCoroutine("Esperador");
                        TileBehivior(10);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 10;
                        thisTurnMovement--;
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }
                        break;                        
                    case 3:
                        if (waitPlayer)
                        {
                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(6);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                thisTurnMovement--;
                                
                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(4);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                thisTurnMovement--;
                                

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            waitPlayer = false;
                        }
                        break;
                    case 5:
                        StartCoroutine("Esperador");
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
                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            {
                                TileBehivior(5);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                StartCoroutine("Esperador");
                                thisTurnMovement--;

                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                TileBehivior(9);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                StartCoroutine("Esperador");
                                thisTurnMovement--;

                            }

                        }
                        else if (thisTurnMovement == 0 && !waitPlayer)
                        {
                            PlayerCurrentPosition(currentTile);
                            waitPlayer = false;
                        }
                        break;
                    case 10:
                        if (thisTurnMovement > 0)
                        {
                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(11);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                thisTurnMovement--;

                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(14);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                thisTurnMovement--;
                                

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            waitPlayer = false;
                        }
                        break;
                    case 11:
                        if (thisTurnMovement > 0)
                        {
                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(13);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                thisTurnMovement--;
                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                StartCoroutine("Esperador");
                                TileBehivior(12);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();                                
                                thisTurnMovement--;                              

                            }

                        }
                        else if (thisTurnMovement == 0)
                        {
                            PlayerCurrentPosition(currentTile);
                            waitPlayer = false;
                        }
                        break;
                    case 12:
                        StartCoroutine("Esperador");
                        TileBehivior(15);
                        PlayerCurrentPosition(currentTile);
                        PlayerNextPos();
                        currentTile = 15;
                        thisTurnMovement--;                       
                        if (thisTurnMovement == 0)
                        {
                            waitPlayer = false;
                        }

                        break;
                    case 13:
                        StartCoroutine("Esperador");
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
                        StartCoroutine("Esperador");
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

                    case 15:
                        waitPlayer = false;
                        break;


                }

            }

            

        }


    }

    private IEnumerator Esperador()
    {
        yield return new WaitForSecondsRealtime(5);
    }

}
