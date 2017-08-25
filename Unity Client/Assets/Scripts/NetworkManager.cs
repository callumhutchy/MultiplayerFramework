using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class NetworkManager : MonoBehaviour {

	public Socket clientSocket;
	public string strName;
	public EndPoint epServer;

	public InputField username;

	public Character currentCharacter = null;

	byte[] byteData = new byte[1024];

	




	public void ConnectToServer(Character character){

		strName = character.GetName();
		MainConnect();
	}

	private void MainConnect(){
		NetworkData msgToSend = new NetworkData();

		try{
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

			IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddress ,1000);

			epServer = (EndPoint) ipEndPoint;

			msgToSend.cmdCommand = Command.Login;
			msgToSend.strMessage = null;
			msgToSend.strName = strName;

			byte[] byteData = msgToSend.ToByte();

			clientSocket.BeginSendTo(byteData, 0 , byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);

			SceneManager.LoadScene("World");


		}
		catch(Exception ex){
			Debug.Log(ex.Message);
		}

		msgToSend.cmdCommand = Command.List;
		msgToSend.strName = strName;
		msgToSend.strMessage = null;

		byteData= msgToSend.ToByte();

		clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);

		byteData = new byte[1024];


	}

	private void OnSend(IAsyncResult ar){
		try{
			clientSocket.EndSend(ar);
		}
		catch(ObjectDisposedException){

		}
		catch(Exception ex){
			Debug.Log(ex.Message);
		}
	}

	private void OnReceive(IAsyncResult ar){
		try{
			clientSocket.EndReceive(ar);
	
			NetworkData msgReceived = new NetworkData(byteData);


			//Do stuff with the data we just got


			byteData = new byte[1024];

			clientSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epServer, new AsyncCallback(OnReceive), null);

		}
		catch(ObjectDisposedException){

		}
		catch(Exception ex){
			Debug.Log(ex.Message);
		}
	}

	private void SendMessage(){
		try{
			NetworkData msgToSend = new NetworkData();

			msgToSend.strName = strName;
			msgToSend.strMessage = "Hello";
			msgToSend.cmdCommand = Command.Message;

			byte[] byteData = msgToSend.ToByte();

			clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(OnSend), null);


		}
		catch(Exception){
			
		}
	}

	void Start(){

		DontDestroyOnLoad(this);

	}
}
