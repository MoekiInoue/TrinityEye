using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//usingでPostProcessing関連を使えるようにする。
using UnityEngine.Rendering.PostProcessing;

public class ChangeTheCharactor : MonoBehaviour
{
    //Vector3 prevPosition;
    //public CharacterController character;
    public GameObject cameraRigObj;
    AudioSource audioSource;
    public AudioClip sound001;
    public AudioClip changeS;
    public AudioClip changeM;
    public AudioClip changeL;




    //Inspectorから、VFX用のVolumeオブジェクトをアタッチする。
    [SerializeField] private PostProcessVolume vfxVolume;

    public GameObject SHand;
    public GameObject MHand;
    public GameObject LHand;
    public GameObject See;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraRigObj.transform.localPosition.y == 0f)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, 2f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeL);

                FlipPostProcessProfile(3);

                MHand.SetActive(false);
                LHand.SetActive(true);
                See.SetActive(false);

            }
            if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, -2f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeS);

                FlipPostProcessProfile(1);

                MHand.SetActive(false);
                SHand.SetActive(true);
                See.SetActive(false);


            }
        }
        else if (cameraRigObj.transform.localPosition.y == 2f)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, -2f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeS);

                FlipPostProcessProfile(1);

                LHand.SetActive(false);
                SHand.SetActive(true);
                See.SetActive(false);


            }
            if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, 0f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeM);

                FlipPostProcessProfile(2);

                LHand.SetActive(false);
                MHand.SetActive(true);
                See.SetActive(true);

            }
        }
        else if (cameraRigObj.transform.localPosition.y == -2f)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))

            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, 0f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeM);

                FlipPostProcessProfile(2);

                SHand.SetActive(false);
                MHand.SetActive(true);
                See.SetActive(true);
            }
            if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
            {
                //Debug.Log("Y");

                cameraRigObj.transform.localPosition = new Vector3(0f, 2f, 0f);

                audioSource.PlayOneShot(sound001);
                audioSource.PlayOneShot(changeL);

                FlipPostProcessProfile(3);

                SHand.SetActive(false);
                LHand.SetActive(true);
                See.SetActive(false);
            }
        }

        // Debug.Log(character.height);
        /*if (character.height == 2)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.Y))
            {
                Debug.Log("Y");
                character.height = 4;

            }
            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {
                character.height = 1;

            }
        }
        else if (character.height == 1)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.Y))
            {
                character.height = 2;

            }
            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {
                character.height = 4;

            }
        }
        else if (character.height == 4)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.Y))
            {
                character.height = 1;

            }
            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {
                character.height = 2;

            }
        }
        */
    }
    void FlipPostProcessProfile (int characterType)
    {



        if(characterType == 1)
        {
            Debug.Log("DollView");

            ColorGrading parameterColorGrading;

            parameterColorGrading = ScriptableObject.CreateInstance<ColorGrading>();
            parameterColorGrading.enabled.Override(true);

            //P型色覚
            //ChannelMixer Redタブの値調整
            parameterColorGrading.mixerRedOutRedIn.Override(100f);
            parameterColorGrading.mixerGreenOutRedIn.Override(0f);
            //ChannelMixer Greenタブの値調整
            parameterColorGrading.mixerRedOutGreenIn.Override(0f);
            parameterColorGrading.mixerGreenOutGreenIn.Override(100f);

            /*
            //T型色覚
            //ChannelMixer Greenタブの値調整
            parameterColorGrading.mixerGreenOutGreenIn.Override(100f);
            */

            vfxVolume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, parameterColorGrading);


        }
        else if(characterType == 2)
        {


            Debug.Log("MaidView");

            ColorGrading parameterColorGrading;

            parameterColorGrading = ScriptableObject.CreateInstance<ColorGrading>();
            parameterColorGrading.enabled.Override(true);
            

            //P型色覚
            //ChannelMixer Redタブの値調整
            parameterColorGrading.mixerRedOutRedIn.Override(50f);
            parameterColorGrading.mixerGreenOutRedIn.Override(50f);
            //ChannelMixer Greenタブの値調整
            parameterColorGrading.mixerRedOutGreenIn.Override(50f);
            parameterColorGrading.mixerGreenOutGreenIn.Override(50f);
            

            /*
            //T型色覚
            //ChannelMixer Greenタブの値調整
            parameterColorGrading.mixerGreenOutGreenIn.Override(0f);
            */



            vfxVolume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, parameterColorGrading);


        }
        else if(characterType == 3)
        {
            Debug.Log("DragonewtView");

            ColorGrading parameterColorGrading;

            parameterColorGrading = ScriptableObject.CreateInstance<ColorGrading>();
            parameterColorGrading.enabled.Override(true);


            //P型色覚
            //ChannelMixer Redタブの値調整
           // parameterColorGrading.mixerRedOutRedIn.Override(100f);
            //parameterColorGrading.mixerGreenOutRedIn.Override(0f);
            //ChannelMixer Greenタブの値調整
            //parameterColorGrading.mixerRedOutGreenIn.Override(0f);
            //parameterColorGrading.mixerGreenOutGreenIn.Override(100f);
            

            /*
            //T型色覚
            //ChannelMixer Greenタブの値調整
            parameterColorGrading.mixerGreenOutGreenIn.Override(100f);
            */



            vfxVolume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, parameterColorGrading);

        }
        else
        {
            Debug.Log("OtherView");

        }


    }

}
     