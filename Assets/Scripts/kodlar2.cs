using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class kodlar2 : MonoBehaviour
{
    public Text masquradeText;

    void Start()
    {
        string invitationText = PlayerPrefs.GetString("invitationText", "default invitation text");
        masquradeText.text = invitationText;
    }

    public void exit()
    {
        Application.Quit();
    }

}
