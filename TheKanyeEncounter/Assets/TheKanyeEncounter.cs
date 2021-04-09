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

   int[] FooderPickerNumberSelector = { 0, 0, 0 };
   int Jon = -1000000;
   int Zaboomafoo;

   string[] FoodsButCodeText = { "Onion", "Corn [inedible]", "big MIOLK", "Yam", "Corn Cube", "Egg", "Eggchips", "hamger", "Tyler the Creator", "Onionade", "Soup", "jeb" };
   string Day = String.Empty;
   string Feeling = String.Empty;
   string PissedOff = "i understand,\nhowever i am still\ndisappointed";
   string PleasedOff = "Thank you for the\noffering";

   bool[] ButtonOrder = new bool[3];
   bool[] Valid = new bool[12];
   bool Ass;
   bool Activated;
   bool PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj;

   float Merica = 0;

   static int moduleIdCounter = 1;
   int moduleId;
   private bool moduleSolved;

   void Awake () {
      moduleId = moduleIdCounter++;
      sdijdnijknjdsanjkfdaknjfd.OnHighlight += delegate () { MakeTheThingsNotThings(); };
      foreach (KMSelectable Kanye in Kanyes) {
         Kanye.OnInteract += delegate () { KanyePress(Kanye); return false; };
      }
      GetComponent<KMBombModule>().OnActivate += Activate;
   }

   void Activate () {
      Day = DateTime.Now.DayOfWeek.ToString();
      Merica = Bomb.GetTime();
   }

   void Start () {
      Activated = true;
      StartCoroutine(Weed());
      switch (Bomb.GetSerialNumber()[5].ToString()) {
         case "0": case "6": Feeling = "Happy"; break;
         case "3": case "7": Feeling = "Angery"; break;
         case "2": case "8": Feeling = "Confused"; break;
         case "1": case "4": Feeling = "Presidential"; break;
      }
      FoodPicker();
   }

   void MakeTheThingsNotThings () {
      if (Ass || moduleSolved || PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj || !Activated) {
         return;
      }
      Audio.PlaySoundAtTransform("what", transform);
      Ass = true;
      FoodShower();
   }

   void FoodPicker () {
      while (FooderPickerNumberSelector[0] == FooderPickerNumberSelector[1] || FooderPickerNumberSelector[0] == FooderPickerNumberSelector[2] || FooderPickerNumberSelector[1] == FooderPickerNumberSelector[2]) {
         for (int i = 0; i < 3; i++) {
            FooderPickerNumberSelector[i] = UnityEngine.Random.Range(0, FoodsButCodeText.Count());
         }
      }
      for (int i = 0; i < 3; i++) {
         Debug.LogFormat("[The Kanye Encounter #{0}] Option {1} is {2}.", moduleId, i + 1, FoodsButCodeText[FooderPickerNumberSelector[i]]);
      }
      Calculate(true);
   }

   IEnumerator Weed () {
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

   void KanyePress (KMSelectable Kanye) {
      if (!PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj) {
         Calculate(false);
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

   void Calculate (bool Log) {
      for (int i = 0; i < 3; i++) {
         switch (FoodsButCodeText[FooderPickerNumberSelector[i]]) {
            case "Onion":
               if (Feeling == "Presidential" || Feeling == "Confused") {
                  Valid[0] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Onion is currently valid.", moduleId);
                  }
               }
               break;
            case "Corn [inedible]": if (Log) { Debug.LogFormat("[The Kanye Encounter #{0}] Corn is inedible.", moduleId); } break;
            case "big MIOLK":
               if (Bomb.GetSerialNumber().Any(x => "B1G".Contains(x)) || Bomb.GetSolvableModuleNames().Contains("Splitting the Loot")) {
                  Valid[2] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] big MIOLK is currently valid.", moduleId);
                  }
               }
               break;
            case "Yam":
               if (Bomb.GetSolvableModuleNames().Count - 1 == Bomb.GetSolvedModuleNames().Count) {
                  Valid[3] = true;
                  Debug.LogFormat("[The Kanye Encounter #{0}] Yam is currently valid.", moduleId);
               }
               break;
            case "Corn Cube":
               if (Feeling == String.Empty) {
                  Valid[4] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Corn Cube is currently valid.", moduleId);
                  }
               }
               break;
            case "Egg":
               if ("MondayWednesdayFriday".Contains(Day)) {
                  Valid[5] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Egg is currently valid.", moduleId);
                  }
               }
               break;
            case "Eggchips":
               if (Bomb.GetPortCount() == 0) {
                  Valid[6] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Eggchips is currently valid.", moduleId);
                  }
               }
               break;
            case "hamger":
               if (!(Bomb.GetPorts().Distinct().Count() == Bomb.GetPorts().Count())) {
                  Valid[7] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] hamger is currently valid.", moduleId);
                  }
               }
               break;
            case "Tyler the Creator":
               if (Feeling == "Angery" || Feeling == "Confused") {
                  Valid[8] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Tyler the Creator is currently valid.", moduleId);
                  }
               }
               break;
            case "Onionade":
               if (!(Feeling == "Happy" || Feeling == "")) {
                  Valid[9] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Onionade is currently valid.", moduleId);
                  }
               }
               break;
            case "Soup":
               if (Bomb.GetTime() * 2 <= Merica) {
                  Valid[10] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] Soup is currently valid. Note that this can change depending on when you press it.", moduleId);
                  }
               }
               break;
            case "jeb":
               if (!Bomb.GetSerialNumber().Any(x => "JEB".Contains(x))) {
                  Valid[11] = true;
                  if (Log) {
                     Debug.LogFormat("[The Kanye Encounter #{0}] jeb is currently valid.", moduleId);
                  }
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
      if (Log) {
         for (int i = 0; i < Valid.Length; i++) {
            if (Valid[i]) {
               Debug.LogFormat("[The Kanye Encounter #{0}] {1} is the furthest one up on the table, therefore Kanye will be most pleased with that.", moduleId, FoodsButCodeText[i]);
               for (int j = i + 1; j < Valid.Length; j++) {
                  Valid[j] = false;
               }
            }
         }
      }
   }

   IEnumerator KanyeIsPleased () {
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
      Ass = true;
      StopAllCoroutines();
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = false;
   }

   IEnumerator KanyeIsPissed () {
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
      for (int f = 0; f < Valid.Length; f++) {
         Valid[f] = false;
      }
      GetComponent<KMBombModule>().HandleStrike();
      FoodPicker();
      FoodShower();
      Ass = true;
      PrEsXvRzZpGkvfdnsijnjfdiijfaijbfahbjlfdabjhlfdhlbjfdshlkijfnblkifbhkalebfhkjlhbjhksbhkgjbhgjkfsjhbhfdsafkjsnkfankjfarbekfbjhkdfbakjhfbdkjfbhkdsajbfahkj = false;
   }

   void FoodShower () {
      for (int i = 0; i < 3; i++) {
         Foods[i].text = FoodsButCodeText[FooderPickerNumberSelector[i]];
      }
      Foods[3].text = "Garlic Bread";
   }

#pragma warning disable 414
   private readonly string TwitchHelpMessage = @"Use !{0} <Item> to use that item. Use !{0} <any command> to highlight the module (the module will need to be highlighted in order to see the options).";
#pragma warning restore 414

   IEnumerator ProcessTwitchCommand (string Command) {
      Command = Command.Trim().ToUpper();
      yield return null;
      if (Command.ToLower() == "highlight") {
         sdijdnijknjdsanjkfdaknjfd.OnHighlight();
         yield break;
      }
      for (int i = 0; i < 4; i++) {
         if (Command == Foods[i].text) {
            Kanyes[i].OnInteract();
         }
      }
   }

   IEnumerator TwitchHandleForcedSolve () {
      yield return ProcessTwitchCommand("highlight");
      yield return new WaitForSecondsRealtime(.1f);
      Calculate(false);
      bool Chose = false;
      for (int i = 0; i < 3; i++) {
         if (ButtonOrder[i]) {
            Kanyes[i].OnInteract();
            Chose = true;
         }
      }
      if (!Chose) {
         Kanyes[3].OnInteract();
      }
      yield return true;
   }
}
