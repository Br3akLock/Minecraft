using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModoDeJogo : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText;
    private string[] buttonTexts = { "Sobrevivencia", "Criativo", "Hardcore" };
    private int currentIndex = 0;

    private void Start()
    {
        button = GetComponent<Button>();
        buttonText = button.GetComponentInChildren<TMP_Text>();
        button.onClick.AddListener(ChangeText);

        UpdateButtonText();
    }

    private void ChangeText()
    {
        currentIndex++;

        if (currentIndex >= buttonTexts.Length)
        {
            currentIndex = 0;
        }

        UpdateButtonText();
    }

    private void UpdateButtonText()
    {
        buttonText.text = "Dificuldade: " + buttonTexts[currentIndex];
    }
}
