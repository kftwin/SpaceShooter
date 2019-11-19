using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    #region Fields
    public Texture backgroundTexture;
    private string instructionText = "Instructions:\nPress left and right arrows to move\nPress spacebar to fire.";

    #endregion

    #region Properties
    #endregion

    #region Functions

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
        if (Input.anyKeyDown)
        {
            Player.Score = 0;
            Player.Lives = 3;
            Player.Missed = 0;
            Application.LoadLevel(1);
            Debug.Log("hello world.");
        }

        //GUI.Label(new Rect(10, 10, 250, 200), instructionText);
        //if(GUI.Button(new Rect((Screen.width/2) - (buttonWidth / 2), Screen.height/2 - buttonHeight/2, buttonWidth, buttonHeight), "Start Game"))
        //{
        //    Application.LoadLevel(1);
        //    Debug.Log("hello world.");
        //}

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    #endregion

}

