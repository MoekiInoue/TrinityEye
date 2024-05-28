using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Open : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public ChangeTheCharactor changeTheCharactor;
    public GameObject[] slides;
    private int nextSlideIndex = 0;
    private int lastSlideIndex = 0;
    [SerializeField] private VideoPlayer video;
    private bool isFinishVideo = false;
    public GameObject black;
    public GameObject Image;
    public GameObject Video;
    public GameObject filter;
    public GameObject filter2;



    void Start()
    {
        characterController.enabled = false;
        changeTheCharactor.enabled = false;
        lastSlideIndex = slides.Length - 1;
        video.loopPointReached += FinishVideo;
        filter.SetActive(false);
        filter2.SetActive(false);

    }

    private void FinishVideo(VideoPlayer _v)
    {
        isFinishVideo = true;
        // �X�t�B�A�������������
        black.SetActive(false);

        // 1�ڂ̃C���[�W��\�����鏈��
        Image.SetActive(true);
        Video.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isFinishVideo && OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            slides[nextSlideIndex].SetActive(false);
            if (lastSlideIndex > nextSlideIndex)
            {
                slides[++nextSlideIndex].SetActive(true);
            }
        }

        if (lastSlideIndex == nextSlideIndex && characterController.enabled == false)
        {
            characterController.enabled = true;
            changeTheCharactor.enabled = true;
            filter.SetActive(true);
            filter2.SetActive(true);
        }

    }
}
