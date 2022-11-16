using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class ClockScript : MonoBehaviour 
{
  private Text textClock;
  
  public Button alarmButton;
  public Text alarmText;
  bool alarmBool = true;
  public AudioSource alarmSound;

  public Button alarm6Button;
  public Text alarm6Text;
  bool alarm6Bool = true;

  public Button alarm9Button;
  public Text alarm9Text;
  bool alarm9Bool = true;

  public Button alarm15Button;
  public Text alarm15Text;
  bool alarm15Bool = true;

  public Button alarm18Button;
  public Text alarm18Text;
  bool alarm18Bool = true;

  void Awake()
  {
    textClock = GetComponent<Text>();
    alarmSound = GetComponent<AudioSource>();
    alarmButton.onClick.AddListener(TaskOnClick);
  }
  
  void Update ()
  {
    DateTime time = DateTime.Now;
    string hour = LeadingZero( time.Hour );
    string minute = LeadingZero( time.Minute );
    string second = LeadingZero( time.Second );

    if(hour == "13")
    {
      hour = "1";
    }
    else if(hour == "14")
    {
      hour = "2";
    }
    else if(hour == "15")
    {
      hour = "3";
    }
    else if(hour == "16")
    {
      hour = "4";
    }
    else if(hour == "17")
    {
      hour = "5";
    }
    else if(hour == "18")
    {
      hour = "6";
    }
    else if(hour == "19")
    {
      hour = "7";
    }
    else if(hour == "20")
    {
      hour = "8";
    }
    else if(hour == "21")
    {
      hour = "9";
    }
    else if(hour == "22")
    {
      hour = "10";
    }
    else if(hour == "23")
    {
      hour = "11";
    }

    textClock.text = hour + ":" + minute + ":" + second;

    var dateNow = System.DateTime.Now;
    var dateVar12 = DateTime.Parse("12:00");
    var dateVar6 = DateTime.Parse("6:00");
    var dateVar9 = DateTime.Parse("9:00");
    var dateVar15 = DateTime.Parse("15:00");
    var dateVar18 = DateTime.Parse("18:00");

    if (dateVar12 < dateNow)
    {
      while(alarmBool)
      {
        alarmButton.gameObject.SetActive(true);
        alarmText.gameObject.SetActive(true);
        alarmBool = false;
        alarmSound.Play();
      } 
    }
    if (dateVar6 < dateNow)
    {
      while(alarm6Bool)
      {
        alarm6Button.gameObject.SetActive(true);
        alarm6Text.gameObject.SetActive(true);
        alarm6Bool = false;
      }
    }
    if (dateVar9 < dateNow)
    {
      while(alarm9Bool)
      {
        alarm9Button.gameObject.SetActive(true);
        alarm9Text.gameObject.SetActive(true);
        alarm9Bool = false;
      }
    }
    if (dateVar15 < dateNow)
    {
      while(alarm15Bool)
      {
        alarm15Button.gameObject.SetActive(true);
        alarm15Text.gameObject.SetActive(true);
        alarm15Bool = false;
      }
    }
    if (dateVar18 < dateNow)
    {
      while(alarm18Bool)
      {
        alarm18Button.gameObject.SetActive(true);
        alarm18Text.gameObject.SetActive(true);
        alarm18Bool = false;
      }
    }
  }

  string LeadingZero (int n)
  {
    return n.ToString().PadLeft(2, '0');
  }

  void TaskOnClick()
    {
      alarmSound.Stop();
    }
}
