using UnityEngine;
using UnityEngine.UI;

public class UITransition : MonoBehaviour
{
    public GameObject titlePage;
    public GameObject settingsPage;

    public Slider volumeSlider;
    public Toggle toggleSetting;

    void Start()
    {
        // Hide settings page initially
        settingsPage.SetActive(false);
    }

    public void TransitionToSettingsPage()
    {
        // Hide title page
        titlePage.SetActive(false);

        // Show settings page
        settingsPage.SetActive(true);
    }

    public void ApplySettingsAndReturnHome()
    {
        // Implement logic to apply settings based on UI elements
        float volume = volumeSlider.value;
        bool enableFeature = toggleSetting.isOn;

        // Example: Log the settings (replace with your logic)
        Debug.Log($"Volume: {volume}, Enable Feature: {enableFeature}");

        // Add your logic to apply the settings to your game/system

        // After applying settings, transition back to the home (title) page
        settingsPage.SetActive(false);
        titlePage.SetActive(true);
    }
}
