using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class EndScreen : MonoBehaviour {
  [SerializeField]
  private InputField nameInputField = null;
  // Assign in editor
  public Text state, time, nickname;
  public string script;
  public int id;
  public RaceStats stats;
  private LeaderboardEntry[] topten;
  public Text[] toptennames;
  public Text[] toptenids;
  public Text[] toptentimes;

  void Start() {

    script = MainMenu.script;

    stats = RaceEnvironment.stats;
    time.text = stats.time.ToString ();
    id = RaceEnvironment.parentScriptID;
    Leaderboard l = new Leaderboard ();
    // Add listener to catch the submit
    nameInputField.onEndEdit.AddListener ((value) => l.storeEntry (script, id, value, stats));
    // Add validation
    nameInputField.characterValidation = InputField.CharacterValidation.Alphanumeric;
    topten = l.getTopTen ();
    for (int i = 0; i <= 9; i++) {
      toptennames [i].text = topten [i].name;
      toptenids [i].text = topten [i].ID.ToString ();
      toptentimes [i].text = topten [i].stats.time.ToString ();
    }
  }

  //
  //  private void State(GameState current) {
  //    if(current.deadCar) {
  //      state.text = "Car is dead!";
  //    }
  //    if(current.finishedCar) {
  //      state.text = " Car completed the track safely!";
  //    }
  //  }
  //
  
}