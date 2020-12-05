using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncounterManager : MonoBehaviour
{
    public AudioSource mainTheme;
    public AudioSource battleTheme;
    public void EnterEncounter()
    {
        SceneManager.LoadScene("BattleScene");
        StartCoroutine(AudioFadeScript.FadeOut(mainTheme, 0.5f));
        StartCoroutine(AudioFadeScript.FadeIn(battleTheme, 5f));
    }

    public void ExitEncounter()
    {
        // In a full game, your code should remember the player's last area and return there
        SceneManager.LoadScene("Overworld");
        StartCoroutine(AudioFadeScript.FadeOut(battleTheme, 0.5f));
        StartCoroutine(AudioFadeScript.FadeIn(mainTheme, 5f));

    }
}
