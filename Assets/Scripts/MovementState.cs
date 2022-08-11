using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementState : MonoBehaviour
{
    public TextMeshProUGUI numeroDeMovimientoRestante;
    private int currentTile;
    [SerializeField]
    public List<GameObject> tiles;
    public GameObject player;
    private float waitTime = 0.5f;
    public GameObject d4;
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

    private void Update()
    {
       
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
        RollD4 manager = d4.GetComponent<RollD4>();


        while (waitPlayer)
        {
            yield return null;
            if (thisTurnMovement > 0)
            {
                switch (IndexActual)
                {
                    case 0:
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                                TileBehivior(6);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
                                thisTurnMovement--;
                                
                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                TileBehivior(4);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                                yield return new WaitForSecondsRealtime(waitTime);
                                thisTurnMovement--;

                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                TileBehivior(9);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
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
                                TileBehivior(11);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
                                thisTurnMovement--;

                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                TileBehivior(14);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
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
                                TileBehivior(13);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
                                thisTurnMovement--;
                            }
                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            {
                                TileBehivior(12);
                                PlayerCurrentPosition(currentTile);
                                PlayerNextPos();
                                yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                        yield return new WaitForSecondsRealtime(waitTime);
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
                numeroDeMovimientoRestante.SetText((thisTurnMovement).ToString());
                if (thisTurnMovement == 0)
                {
                    manager.canRoll = true;
                }

            }



        }


    }


}
