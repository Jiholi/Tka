using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int Hp { get; set; }
    private bool isDefencing = false;
    private bool lastIsDefencingOffed; //isDefencing 비활성화 여부 확인용 변수.
    private float offTime;
    
    void Awake(){
        Hp = 100;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("c")){ isDefencing = true; lastIsDefencingOffed = false; } 
        else { if(isDefencing){lastIsDefencingOffed = true;} isDefencing = false; }
        if (offTime > 0 ) { offTime -= Time.deltaTime; } else if(offTime < 0){ offTime = 0; }
    }

    public void Attacked(int Damage, bool isChanged ) {
        float lastDefencetime = 0f;
        if(isChanged == true){
            if(lastDefencetime <= 1.5f ){

            }
            lastDefencetime = 0f;
        } else if(isDefencing) {
            lastDefencetime += Time.deltaTime;

        }
        else if(offTime <= 0){
            offTime = 2f;
            Hp = Hp - Damage;
            Debug.Log("Attacked");
        }
    }

    void Parrying(){
        // 그래서 뭐함?
    }
}
