using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassField : MonoBehaviour
{
    ///<summary>
    ///2D�̐N������ł�
    ///OnTriggerEnter2D�͐N�����ɍs������ł�
    ///��/summary��
    ///<param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
    
    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;

    }
    /// <summary>
    /// 2D�̐N������ł�
    /// OnTriggerExit2D�͐N�����Ă��甲���Ă���̔���ł�
    /// </summary>
    /// <param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
    void OnTriggerExit2D(Collider2D characterCollider) 
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 2f;
    }

    private void Start()
    {
        Multiplication(20,15);
    }
    public void Multiplication(int a,int b) 
    {
        int MuiliplicationValue = a * b;
        Debug.Log(MuiliplicationValue);
    }
}