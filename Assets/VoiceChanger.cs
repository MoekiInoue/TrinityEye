using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VoiceChanger : MonoBehaviour
{

    // AudioSource �R���|�[�l���g���i�[����ϐ�
    private AudioSource audioSource;
    // AudioClip ���i�[����z��̃C���f�b�N�X�ԍ�
    private int index = 0;
    // AudioSource �̍Đ����m�F�t���O
    private bool isPlaying;
    public AudioClip[] audioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {

        }
    }
}
