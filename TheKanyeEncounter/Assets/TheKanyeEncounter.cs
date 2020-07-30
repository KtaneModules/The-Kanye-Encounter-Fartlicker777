using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class TheKanyeEncounter : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMSelectable[] Kanyes;
    public TextMesh[] Foods;
    public Material[] Ambiance;
    public GameObject TheBackStreetBoys;
    public KMSelectable sdijdnijknjdsanjkfdaknjfd;
    public GameObject[] Thingsandstuff;

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;
    bool Ass = false;
    string[] FoodsButCodeText = {"Onion", "Corn [inedible]", "big MIOLK", "Yam", "Corn Cube", "Egg", "Eggchips", "hamger", "Tyler the Creator", "Onionade", "Soup", "jeb"};
    int[] FooderPickerNumberSelector = {0,0,0};
    string Feeling = "";
    bool[] Valid = {false, false, false, false, false, false, false, false, false, false, false, false};
    bool[] ButtonOrder = {false, false, false};
    float Merica = 0;
    bool INeedAbool = false;
    string PissedOff = "i understand,\nhowever i am still\ndisappointed";
    string PleasedOff = "Thank you for the\noffering";
    int Jon = -1000000;
    bool PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = false;
    int Zaboomafoo = 0;

    void Awake () {
        moduleId = moduleIdCounter++;
        sdijdnijknjdsanjkfdaknjfd.OnHighlight += delegate () { MakeTheThingsNotThings();};
        foreach (KMSelectable Kanye in Kanyes) {
            Kanye.OnInteract += delegate () { KanyePress(Kanye); return false; };
        }
    }

    void Start () {

      Merica = Bomb.GetTime();
      StartCoroutine(Weed());
      switch (Bomb.GetSerialNumber()[5].ToString()) {
        case "0": case "6": Feeling = "Happy"; break;
        case "3": case "7": Feeling = "Angery"; break;
        case "2": case "8": Feeling = "Confused"; break;
        case "1": case "4": Feeling = "Presidential"; break;
        case "5": case "9": default: break;
      }
      FoodPicker();
    }

    void MakeTheThingsNotThings() {
      if (Ass || moduleSolved || PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj) {
        return;
      }
      Audio.PlaySoundAtTransform("what", transform);
      Ass = true;
    }

    void FoodPicker() {
      while (FooderPickerNumberSelector[0] == FooderPickerNumberSelector[1] || FooderPickerNumberSelector[0] == FooderPickerNumberSelector[2] || FooderPickerNumberSelector[1] == FooderPickerNumberSelector[2]) {
        for (int i = 0; i < 3; i++) {
          FooderPickerNumberSelector[i] = UnityEngine.Random.Range(0, FoodsButCodeText.Count());
        }
      }
      for (int i = 0; i < 3; i++) {
        Debug.LogFormat("[The Kanye Encounter #{0}] Option {1} is {2}.", moduleId, i + 1, FoodsButCodeText[FooderPickerNumberSelector[i]]);
      }
    }

    IEnumerator Weed() {
      while (true) {
        for (int i = 0; i < Ambiance.Count(); i++) {
          TheBackStreetBoys.GetComponent<MeshRenderer>().material = Ambiance[i];
          yield return new WaitForSecondsRealtime(.1f);
        }
        for (int i = 1; i < Ambiance.Count(); i++) {
          TheBackStreetBoys.GetComponent<MeshRenderer>().material = Ambiance[Ambiance.Count() - i];
          yield return new WaitForSecondsRealtime(.1f);
        }
      }
    }

    void KanyePress(KMSelectable Kanye) {
      if (!PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj) {
        for (int i = 0; i < 3; i++) {
          switch (FoodsButCodeText[FooderPickerNumberSelector[i]]) {
            case "Onion":
            if (Feeling == "Presidential" || Feeling == "Confused") {
              Valid[0] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Onion is currently valid.", moduleId);
            }
            break;
            case "Corn [inedible]": Debug.LogFormat("[The Kanye Encounter #{0}] Corn is inedible.", moduleId); break;
            case "big MIOLK":
            for (int j = 0; j < 6; j++) {
              if (Bomb.GetSerialNumber()[j].ToString() == "B" || Bomb.GetSerialNumber()[j].ToString() == "1" || Bomb.GetSerialNumber()[j].ToString() == "G" || Bomb.GetSolvableModuleNames().Contains("Painting")) {
                Valid[2] = true;
              }
            }
            if (Valid[2]) {
              Debug.LogFormat("[The Kanye Encounter #{0}] big MIOLK is currently valid.", moduleId);
            }
            break;
            case "Yam":
            if (Bomb.GetSolvedModuleNames().Count == 0) {
              Valid[3] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Yam is currently valid.", moduleId);
            }
            break;
            case "Corn Cube":
            if (Feeling == "") {
              Valid[4] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Corn Cube is currently valid.", moduleId);
            }
            break;
            case "Egg":
            if (DateTime.Now.DayOfWeek.ToString() == "Monday" || DateTime.Now.DayOfWeek.ToString() == "Wednesday" || DateTime.Now.DayOfWeek.ToString() == "Friday") {
              Valid[5] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Egg is currently valid.", moduleId);
            }
            break;
            case "Eggchips":
            if (Bomb.GetPortCount() == 0) {
              Valid[6] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Eggchips is currently valid.", moduleId);
            }
            break;
            case "hamger":
            if (!(Bomb.GetPorts().Distinct().Count() == Bomb.GetPorts().Count())) {
              Valid[7] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] hamger is currently valid.", moduleId);
            }
            break;
            case "Tyler the Creator":
            if (Feeling == "Angery" || Feeling == "Confused") {
              Valid[8] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Tyler the Creator is currently valid.", moduleId);
            }
            break;
            case "Onionade":
            if (!(Feeling == "Happy" || Feeling == "")) {
              Valid[9] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Onionade is currently valid.", moduleId);
            }
            break;
            case "Soup":
            if (INeedAbool) {
              Valid[10] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] Soup is currently valid.", moduleId);
            }
            break;
            case "jeb":
            Zaboomafoo = 0;
            for (int j = 0; j < 6; j++) {
              if (!(Bomb.GetSerialNumber()[j].ToString() == "J" || Bomb.GetSerialNumber()[j].ToString() == "E" || Bomb.GetSerialNumber()[j].ToString() == "B")) {
                Zaboomafoo += 1;
              }
            }
            if (Zaboomafoo == 6) {
              Valid[11] = true;
              Debug.LogFormat("[The Kanye Encounter #{0}] jeb is currently valid.", moduleId);
            }
            break;
          }
        }
        for (int i = 0; i < 3; i++) {
          for (int j = 0; j < FoodsButCodeText.Length; j++) {
            if (Foods[i].text == FoodsButCodeText[j]) {
              if (Valid[j]) {
                ButtonOrder[i] = true;
              }
            }
          }
        }
        for (int i = 0; i < Valid.Length; i++) {
          if (Valid[i]) {
            Debug.LogFormat("[The Kanye Encounter #{0}] {1} is the farthest one up on the table, so therefore Kanye will be most pleased with that.", moduleId, FoodsButCodeText[i]);
            for (int j = i + 1; j < Valid.Length; j++) {
              Valid[j] = false;
            }
          }
        }
        for (int i = 0; i < 4; i++) {
          if (Kanye == Kanyes[i]) {
            if (i != 3 && ButtonOrder[i]) {
              StartCoroutine(KanyeIsPleased());
              Debug.LogFormat("[The Kanye Encounter #{0}] You selected the best option. Kanye is pleased.", moduleId);
            }
            else if (i == 3 && !ButtonOrder[0] && !ButtonOrder[1] && !ButtonOrder[2]) {
              StartCoroutine(KanyeIsPleased());
              Debug.LogFormat("[The Kanye Encounter #{0}] No other option was valid, so you chose Garlic Bread. Kanye is pleased.", moduleId);
            }
            else {
              for (int j = 0; j < FoodsButCodeText.Length; j++) {
                if (i == 3) {
                  Debug.LogFormat("[The Kanye Encounter #{0}] You selected Garlic Bread, but that was the least desirable option. Kanye is disappointed...", moduleId);
                  break;
                }
                if (Foods[i].text == FoodsButCodeText[j] && i != 3) {
                  Debug.LogFormat("[The Kanye Encounter #{0}] You selected {1} which is incorrect. Kanye is disappointed...", moduleId, FoodsButCodeText[j]);
                  break;
                }
              }
              StartCoroutine(KanyeIsPissed());
            }
          }
        }
      }
    }

    IEnumerator KanyeIsPleased() {
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = true;
      Ass = false;
      moduleSolved = true;
      for (int i = 0; i < 4; i++) {
        Foods[i].text = "";
      }
      for (int i = 0; i < PleasedOff.Length; i++) {
        Foods[0].text += PleasedOff[i];
        if (Foods[0].text[i] != ' ') {
          yield return new WaitForSeconds(.1f);
        }
      }
      yield return new WaitForSeconds(3f);
      GetComponent<KMBombModule>().HandlePass();
      for (int p = 0; p < Thingsandstuff.Count(); p++) {
        Thingsandstuff[p].gameObject.SetActive(false);
        yield return new WaitForSeconds(.1f);
      }
      StopAllCoroutines();
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = false;
    }

    IEnumerator KanyeIsPissed() {
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = true;
      Ass = false;
      for (int i = 0; i < 4; i++) {
        Foods[i].text = "";
      }
      for (int i = 0; i < PissedOff.Length; i++) {
        Foods[0].text += PissedOff[i];
        if (Foods[0].text[i] != ' ') {
          yield return new WaitForSeconds(.1f);
        }
      }
      yield return new WaitForSeconds(3f);
      for (int q = 0; q < 3; q++) {
        FooderPickerNumberSelector[q] = 0;
        ButtonOrder[q] = false;
      }
      INeedAbool = false;
      for (int f = 0; f < Valid.Length; f++) {
        Valid[f] = false;
      }
      GetComponent<KMBombModule>().HandleStrike();
      FoodPicker();
      Ass = true;
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = false;
    }

    void Update () {
      if (Bomb.GetTime() * 2 <= Merica) {
        INeedAbool = true;
      }
      if (Ass == true) {
        for (int i = 0; i < 3; i++) {
          Foods[i].text = FoodsButCodeText[FooderPickerNumberSelector[i]];
        }
        Foods[3].text = "Garlic Bread";
      }
    }

    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use !{0} 1/2/3/4 to select the corresponding option from top to bottom. Use !{0} highlight to highlight the module (the module will need to be highlighted in order to see the options).";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand(string Command) {
      Command = Command.Trim();
      if (Command.ToLower() == "highlight") {
        yield return null;
        sdijdnijknjdsanjkfdaknjfd.OnHighlight();
        yield break;
      }
      int Whateverthefuckyouwanttocallit = 0;
      if (int.TryParse(Command, out Whateverthefuckyouwanttocallit)) {
        if (Whateverthefuckyouwanttocallit != 1 && Whateverthefuckyouwanttocallit != 2 && Whateverthefuckyouwanttocallit != 3 && Whateverthefuckyouwanttocallit != 4) {
          yield return "sendtochaterror Invalid command!";
          yield break;
        }
        else {
          Kanyes[int.Parse(Command) - 1].OnInteract();
        }
      }
    }
}
