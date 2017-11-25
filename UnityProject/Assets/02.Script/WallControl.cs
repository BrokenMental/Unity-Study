﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour {
    //충돌이 시작할 때 발생하는 이벤트
    void OncollisionEnter(Collision coll)
    {
        //충돌이 발생할 오브젝트의 태그값 비교 
        if (coll.collider.tag == "BULLET")
        {
            //충돌한 오브젝트 삭제
            Destroy(coll.gameObject);
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
