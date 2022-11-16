using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Globalization;
public class clock : MonoBehaviour {
  private Text textClock;
  public Button alarm;


void Awake (){
    textClock = GetComponent<Text>();
    alarm = GetComponent<Button>();
  }
void Update (){
  DateTime time = DateTime.Now;
  string hour = LeadingZero( time.Hour );
  string minute = LeadingZero( time.Minute );
  string second = LeadingZero( time.Second );
  textClock.text = hour + ":" + minute + ":" + second;
  var dateNow = System.DateTime.Now;



  var dateVar = DateTime.Parse("2021/05/30 12:30");

    if (dateVar < dateNow)
    {
       PrintDate();
    }
  }
  void PrintDate()
 {
      Debug.Log("Date : " + System.DateTime.Now.ToString());
      alarm.SetActive(true);
 }
  string LeadingZero (int n){
     return n.ToString().PadLeft(2, '0');
  }
}
