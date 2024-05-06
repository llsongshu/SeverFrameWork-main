/********************************************************************************
 *	文件名：NetManager.cs
 *	全路径：	\Script\LogicCore\NetManager.cs
 *	创建人：	王华
 *	创建时间：2013-12-05
 *
 *	功能说明： 网络管理器
 *	       
 *	修改记录：王迪 2014.02.14 增加一些登陆用的消息包发送协议，用于断线重连
*********************************************************************************/

using SPacket.SocketInstance;
using UnityEngine;

public class NetManager : MonoBehaviour
{

    public static bool IsReconnecting = false;

    static public NetManager m_netManager;

    private static NetManager m_instance = null;
    public static NetManager Instance()
    {
        return m_instance;
    }

    private bool m_bAskConnecting = false;      // 是否正处于询问断线状态
    void Awake()
    {
        if (m_netManager != null)
        {
            Destroy(this.gameObject);
        }

        m_netManager = this;
        DontDestroyOnLoad(this.gameObject);

        //NetWorkLogic.SetConnectLostDelegate(ConnectLost);
        m_instance = this;
    }

    void OnEnable()
    {
        m_bAskConnecting = false;
    }

    void Update()
    {
        NetWorkLogic.GetMe().Update();
    }

    public void ConnectToServer(string _ip, int _port, NetWorkLogic.ConnectDelegate delConnect)
    {
        NetWorkLogic.SetConcnectDelegate(delConnect);
        NetWorkLogic.GetMe().ConnectToServer(_ip, _port, 100);
    }


    public static void SendUserLogin(LoginData.LoginRet retFun, bool bForce, bool bReconnect = false)
    {
        //if (!LoginData.accountData.m_bInit)
        //{
        //    Debug.Log("账户数据未初始化");
        //    return;
        //}

        //帐户和密码
        LoginData.retLogin = retFun;
        CG_LOGIN accountInfo = (CG_LOGIN)PacketDistributed.CreatePacket(MessageID.PACKET_CG_LOGIN);

        accountInfo.SetVtype((int)CG_LOGIN.VALIDATETYPE.TEST);

        accountInfo.SetGameversion(1/*(int)PlatformHelper.GetGameVersion()*/);
        accountInfo.SetProgramversion(0/*(int)PlatformHelper.GetProgramVersion()*/);
        accountInfo.SetPublicresourceversion(0);
        accountInfo.SetMaxpacketid((int)MessageID.PACKET_SIZE);
        accountInfo.SetForceenter(0);
        accountInfo.SetDeviceid("1263f7fa47a47d2ffa20bf1a8dacd1a1e20cae56");
        accountInfo.SetDevicetype("Desktop_LAPTOP-9MKD5JP2");
        accountInfo.SetDeviceversion("OpenGL ES 2.0 [emulated]");

        accountInfo.SetAccount("1263f70");
        accountInfo.SetValidateinfo("");
        accountInfo.SetChannelid("TEST");
        accountInfo.SetMediachannel("0"/*PlatformHelper.GetMediaChannel()*/);

        accountInfo.SetRapidvalidatecode(0);
        accountInfo.SetReservedint1(0);
        accountInfo.SetReservedint2(0);
        accountInfo.SetReservedint3(0);
        accountInfo.SetReservedint4(0);
        accountInfo.SetReservedstring1("");
        accountInfo.SetReservedstring2("");
        accountInfo.SetReservedstring3("");
        accountInfo.SetReservedstring4("");
        accountInfo.SendPacket();
    }

    public static void SendChooseRole(ulong roleGUID, GC_SELECTROLE_RETHandler.SelectRoleFailRet funRet)
    {
        /*
        CG_SELECTROLE selectRolePacket = (CG_SELECTROLE)PacketDistributed.CreatePacket(MessageID.PACKET_CG_SELECTROLE);
        selectRolePacket.SetRoleGUID(roleGUID);
        selectRolePacket.SendPacket();
         * */

        GC_SELECTROLE_RETHandler.retSelectRoleFail = funRet;
        CG_SELECTROLE createRolePacket = (CG_SELECTROLE)PacketDistributed.CreatePacket(MessageID.PACKET_CG_SELECTROLE);
        createRolePacket.SetRoleGUID(10000112);
        createRolePacket.SendPacket();
    }

    public static void SendUserLogout()
    {
        CG_ASK_QUIT_GAME packet = (CG_ASK_QUIT_GAME)PacketDistributed.CreatePacket(MessageID.PACKET_CG_ASK_QUIT_GAME);
        packet.Type = (int)CG_ASK_QUIT_GAME.GameSelecTType.GAMESELECTTYPE_ACCOUNT;
        packet.SendPacket();
    }


    public static void OnWaitPacketTimeOut()
    {
    }

    private static void OnReturnServerChoose()
    {
        NetWorkLogic.GetMe().DisconnectServer();
    }

    public void OnReconnect()
    {

        m_bAskConnecting = false;
        NetWorkLogic.SetConcnectDelegate(Ret_Reconnect);
        NetWorkLogic.GetMe().ReConnectToServer();
    }
    void Ret_Reconnect(bool bSuccess, string strResult)
    {
        if (bSuccess)
        {
            // 重新登录
            //NetManager.SendUserLogin(Ret_Login, true, true);
            //NetManager.SendUserLogin(PlayerPreferenceData.LastAccount, PlayerPreferenceData.LastPsw, Ret_Login);
        }
        else
        {

        }
    }

    public void Ret_Login(GC_LOGIN_RET.LOGINRESULT result, int validateResult)
    {
        if (result == GC_LOGIN_RET.LOGINRESULT.SUCCESS)
        {
            Debug.Log("登录成功");
        }
        else
        {
            Debug.Log("登录失败");
        }
    }
}
