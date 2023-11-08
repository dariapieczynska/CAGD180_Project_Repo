using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Parent, Ciela
// 11/13/23
// Handles UI for the lives diplayed on the screen.
//updated lives depending if any are lost or gained.

public class UIManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + playerHealth.lives;
    }
}
