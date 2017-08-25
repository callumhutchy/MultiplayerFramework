using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using System.Data;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MenuManagement : MonoBehaviour {

	public NetworkManager netMan;

	public InputField registerEmail;
	public InputField registerUsername;
	public InputField registerPassword;

	public InputField loginUsername;
	public InputField loginPassword;

	public InputField createCharacterName;

	public List<Character> characters;

	public string UserID = "";

	public GameObject buttonPrefab;
	public VerticalLayoutGroup vlg;
	
	
	// Use this for initialization
	void Start () {
		characters = new List<Character>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnterWorld(){

		

		//netMan.ConnectToServer(character);
	}

	public void Login(){
		StartCoroutine (UserLogin ());
	}

	public void Register(){

		StartCoroutine (RegisterUser ());

	}

	public void CreateChar(){
		if (UserID != "") {
			StartCoroutine (CreateCharacter ());
		} else {
			Debug.Log ("Login first");
		}



	}

	void RetrieveCharacters(){
		characters = new List<Character>();
		StartCoroutine (RetrieveChars ());

	}


	IEnumerator RetrieveChars(){
		string url = "hutchy-tinkerboard.ddns.net/server/RetrieveCharacters.php?AccountID=" + UserID.ToString ();
		WWW www = new WWW (url);
		yield return www;

		if (www.error == null) {
			Debug.Log ("Characters retrieved! " + www.text);

			string[] temp = www.text.Split('£');
			foreach(string str in temp){
				string[] temp2 = str.Split('/');
				characters.Add(new Character(temp2[0], temp2[1], UserID));
			}

			foreach(Character c in characters){
				GameObject go = Instantiate(buttonPrefab) as GameObject;
				//CharacterSelectButton csb = go.GetComponent<Character
				go.SetActive(true);
				go.transform.SetParent(vlg.gameObject.transform);
			}


		} else {
			Debug.LogError (www.error);
		}

	}

	IEnumerator CreateCharacter(){
		string url = "hutchy-tinkerboard.ddns.net/server/CreateCharacter.php?Name=" + createCharacterName.text + "&AccountID=" + UserID.ToString();
		WWW www = new WWW (url);
		yield return www;

		if (www.error == null) {
			Debug.Log ("Create character successful! " + www.text);
			createCharacterName.text = "";
		} else {
			Debug.LogError (www.error);
		}
		RetrieveCharacters ();
	}

	

	IEnumerator UserLogin(){
		string url = "hutchy-tinkerboard.ddns.net/server/UserLogin.php?Username=" + loginUsername.text + "&Password=" + loginPassword.text;
		WWW www = new WWW (url);
		yield return www;

		if (www.error == null) {
			if (www.text == "") {
				Debug.Log ("Login not successful, check details again");

			} else {
				Debug.Log ("Login successful! " + www.text);
				UserID = www.text;
				Debug.Log ("User ID set to: " + UserID);
				loginUsername.text = "";
				loginPassword.text = "";
			}

		} else {
			Debug.LogError (www.error);
		}

		RetrieveCharacters ();
	}

	IEnumerator RegisterUser(){
		string url = "hutchy-tinkerboard.ddns.net/server/RegisterUser.php?Email=" + registerEmail.text + "&Username=" + registerUsername.text + "&Password=" + registerPassword.text;
		WWW www = new WWW (url);
		yield return www;

		if (www.error == null) {
			Debug.Log ("Register successful!");
			registerEmail.text = "";
			registerUsername.text = "";
			registerPassword.text = "";
		} else {
			Debug.LogError (www.error);
		}

	}


	public void SelectCharacter(){

		Character c;

		foreach(Character ch in characters){
			if(ch.GetName().Equals(this.name)){
				c = ch;
			}
		}

		//netMan.currentCharacter = c;

	}


}

