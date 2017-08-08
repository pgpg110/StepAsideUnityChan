using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDestroy : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//UnityちゃんとitemDestroyの距離
	private float difference;

	void Start () {

		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
		//UnityちゃんとitemDestroyの位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;

	}

	void Update () {
		
		//Unityちゃんの位置に合わせてitemDestroyの位置を移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);

	}

	void OnTriggerEnter(Collider other) {

		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);
		}             
	}
}
