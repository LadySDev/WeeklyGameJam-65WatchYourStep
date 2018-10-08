using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGameManager : MonoBehaviour {

    //  LANGUAGE

    private List<string> languages = new List<string>(){ "English", "French"};
    public List<string> GetLanguages() { return languages; }

    private string currentLanguage;
    public void SetCurrentLanguage(string language) { currentLanguage = language; }
    public string GetCurrentLanguage() { return currentLanguage; }

    private ScrLanguage currentScrLanguage;
    public ScrLanguage GetCurrentScrLanguage() { return currentScrLanguage; }

    //  RESOLUTION

    private static List<Resolution> resolutions;
    public List<Resolution> GetResolutions() { return resolutions; }

    private Resolution currentResolution;
    public void SetCurrentResolution(Resolution res) { currentResolution = res; }
    public Resolution GetCurrentResolution() { return currentResolution; }

    //  FULLSCREEN

    private bool fullscreen;
    public void SetFullScreen(bool full) { fullscreen = full; }
    public bool GetFullScreen() { return fullscreen; }

    private GameObject canva;

    [SerializeField]
    private GameObject panelTitle;
    private GameObject instanceTitle;

    [SerializeField]
    private GameObject panelOptions;
    private GameObject instanceOptions;

    private void Awake()
    {
        //Set English Language
        currentLanguage = languages[0];

        SetCurrentScrLanguage();

        resolutions = new List<Resolution>();

        foreach (Resolution res in Screen.resolutions)
        {
            resolutions.Add(res);

            if (res.width == 720 && res.height == 480)
            {
                currentResolution = res;
            }
        }

        fullscreen = false;

        SetResolution(currentResolution.width, currentResolution.height, fullscreen);

    }

    // Use this for initialization
    void Start () {

        canva = GameObject.Find("Canvas");

        ShowTitle();

    }
	
	// Update is called once per frame
	void Update () {

        SetResolution(currentResolution.width, currentResolution.height, fullscreen);
        SetCurrentScrLanguage();

    }

    private void SetCurrentScrLanguage()
    {
        if (currentLanguage == languages[0])
        {
            currentScrLanguage = new ScrEnglish();
        }
        else if (currentLanguage == languages[1])
        {
            currentScrLanguage = new ScrFrench();
        }
    }

    private void SetResolution(int width, int height, bool fullscreen)
    {
        Screen.SetResolution(width, height, fullscreen);
    }

    public void ShowTitle()
    {
        instanceTitle = Instantiate(panelTitle, canva.transform);
    }

    public void HideTitle()
    {
        Destroy(instanceTitle);
    }

    public void ShowOptions()
    {
        instanceOptions = Instantiate(panelOptions, canva.transform);
    }

    public void HideOptions()
    {
        Destroy(instanceOptions);
    }

}
