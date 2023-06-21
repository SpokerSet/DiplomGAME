using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public GameObject skillsPanel;
    public Image skillsDisplay;
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int RequiredLevel { get; private set; }

    public Skill(string name, string description, int requiredLevel)
    {
        Name = name;
        Description = description;
        RequiredLevel = requiredLevel;
    }

    public void OpenPanel()
    {
        skillsPanel.SetActive(true);
    }
    public void ClosePanel()
    {
        skillsPanel.SetActive(false);
    }

    public void Activate()
    {
        // Implement the logic for the skill's activation here
        Debug.Log("Skill activated: " + Name);
    }
}
