using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBattleAreaManager : MonoBehaviour
{
    [SerializeField] private GameObject panelBattleArea;
    [SerializeField] private GameObject panelTeamPlanner;

    private void Start()
    {
        panelBattleArea.SetActive(true);
        panelTeamPlanner.SetActive(false);
    }

    public void ButtonBattleAreaChoosen()
    {
        panelTeamPlanner.SetActive(true);
        panelBattleArea.SetActive(false);
    }

    public void ButtonBackToBattleArea()
    {
        panelBattleArea.SetActive(true);
        panelTeamPlanner.SetActive(false);
    }
}
