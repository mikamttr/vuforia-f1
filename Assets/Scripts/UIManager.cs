using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject scanPrompt;
    public GameObject infoButton;
    public GameObject joystick;
    public AudioSource infoAudio;

    private GameObject currentModel;
    private GameObject currentInfoPanel;

    void Start()
    {
        // Default state when scene starts
        SetUIState(false);
        currentModel = null;
        currentInfoPanel = null;
    }

    void Update()
    {
        GameObject activeModel = ActiveModelTracker.GetActiveModel();

        if (activeModel != currentModel)
        {
            currentModel = activeModel;

            if (currentModel != null)
            {
                SetUIState(true);

                Transform info = currentModel.transform.parent.Find("infoPanel");
                currentInfoPanel = info ? info.gameObject : null;

                if (currentInfoPanel != null) currentInfoPanel.SetActive(false); // in case it was previously open
            }
            else
            {
                SetUIState(false);

                if (currentInfoPanel != null)
                    currentInfoPanel.SetActive(false);

                currentInfoPanel = null;
            }
        }
    }

    public void ToggleInfoPanel()
    {
        if (currentInfoPanel != null)
        {
            bool isActive = !currentInfoPanel.activeSelf;
            currentInfoPanel.SetActive(isActive);

            if (isActive && infoAudio != null)
                infoAudio.Play();
        }
    }

    private void SetUIState(bool isVisible)
    {
        scanPrompt.SetActive(!isVisible);
        infoButton.SetActive(isVisible);
        joystick.SetActive(isVisible);
    }
}