using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{

	string Name = "";
	string CharacterID = "";
	string AccountID = "";
	Vector3 position;
	float rotation;

	public Character(string Name, string charID, string AccountID){
		this.Name = Name;
		this.CharacterID = charID;
		this.AccountID = AccountID;
	}

	public string GetName(){
		return this.Name;
	}

	public string GetAccountID(){
		return this.AccountID;
	}

	public Vector3 GetPosition(){
		return this.position;
	}

	public void SetPosition(Vector3 pos){
		this.position = pos;
	}

	public float GetRotation(){
		return this.rotation;
	}

	public void SetRotation(float rot){
		this.rotation = rot;
	}

	public string GetCharacterID(){
		return this.CharacterID;
	}

	public void SetCharacterID(string charID){
		this.CharacterID = charID;
	}

}
