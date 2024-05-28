using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VoiceChanger : MonoBehaviour
{

    // AudioSource コンポーネントを格納する変数
    private AudioSource audioSource;
    // AudioClip を格納する配列のインデックス番号
    private int index = 0;
    // AudioSource の再生中確認フラグ
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
