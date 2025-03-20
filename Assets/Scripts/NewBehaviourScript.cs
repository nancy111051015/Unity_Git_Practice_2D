using UnityEngine;

namespace Nancy
{
    public class NewBehaviourScript : MonoBehaviour
    {
        //喚醒事件：在撥放遊戲後會執行一次
        private void Awake()
        {
            Debug.Log(message: "Awake");
        }

        //開始事件：喚醒事件之後執行一次
        private void Start()
        {
            Debug.Log(message: $"Start");

        }

        //使用事件：物件被啟用時執行 (常用於重置腳本狀態)
        private void OnEnable()
        {
            Debug.Log(message: $"OnEnable 物件被啟用");
        }

        //停用事件：物件被停用時執行 (用於取消事件監聽如暫停計時器或動畫)
        private void OnDisable()
        {
            Debug.Log(message: $"OnDisable 物件被停用");
        }

        //刪除事件：當遊戲物件被刪除時執行
        private void OnDestroy()
        {
            Debug.Log(message: $"OnDestroy 物件被刪除");
        }

        //更新事件：每秒約執行60次，可用於需要不斷偵測到的動作，如角色移動控制
        private void Update()
        {
            Debug.Log(message: $"Update");
        }

        //固定更新：固定時間間隔執行 (用於物理行為如跟場景有互動的角色控制 *不受FPS影響)
        private void FixedUpdate()
        {
            Debug.Log(message: $"FixedUpdate");
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log(message: $"碰到地板");
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            Debug.Log(message: $"持續碰到地板");
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            Debug.Log(message: $"離開地板");
        }

        [SerializeField] private GameObject qrCode;

        private void OnTriggerEnter2D(Collider2D col)
        {
            Debug.Log(message: $"進入偵測區域");
            
            qrCode.SetActive(false);

        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log(message: $"離開偵測區域");
        }



    }

}
