using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KillCounter : MonoBehaviour
{
    public Text counterText;
    int kills;
    void Update()
    {
        this.showKills();
    }

    public void addKill()
    {
        kills++;
    }

    private void showKills()
    {
        counterText.text = kills.ToString();

    }
}
