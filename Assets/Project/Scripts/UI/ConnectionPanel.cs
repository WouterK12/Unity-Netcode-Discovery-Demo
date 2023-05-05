using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionPanel : MonoBehaviour
{
    [SerializeField]
    private Button btnServer;

    private void Awake()
    {
        btnServer.onClick.AddListener(OnClickServer);
    }

    private void OnClickServer()
    {
        NetworkManager.Singleton.StartServer();
    }
}
