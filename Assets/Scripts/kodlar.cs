using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class kodlar : MonoBehaviour
{
    public InputField nicknameval;
    public Dropdown conceptval;
    public Slider numberval;
    public Toggle dayval;
    public Toggle nightval;

    public void inviteMe() {

        string nickname = nicknameval.text;
        string concept = conceptval.options[conceptval.value].text;
        int number = (int)numberval.value;
        string time = nightval.isOn ? "at night" : "in the morning";

        string invitationText = string.Format("Dear {0}; you are invited to The Masquerade that will take place {1}, dressed as a {2}. Remember, the number you chose is {3}!", nickname, time, concept, number);
        PlayerPrefs.SetString("invitationText", invitationText);

        conceptval = GetComponentInChildren<Dropdown>();
        nicknameval = GetComponentInChildren<InputField>();

        SceneManager.LoadScene(1);

    }

}
