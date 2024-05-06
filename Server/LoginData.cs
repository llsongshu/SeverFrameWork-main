/********************************************************************
	created:	2014/01/15
	created:	15:1:2014   16:04
	filename: 	LoginData.cs
	author:		王迪
	
	purpose:	存放登陆相关玩家数据
*********************************************************************/
using System;
using System.Collections.Generic;

public class LoginData
{
    public class PlayerRoleData : IComparable
    {
        public PlayerRoleData(ulong _guid, int _type, string _name, int _level, int _ModelVisualID, int _WeaponID, int _WeaponEffectGem, UInt32 _roleCreateTime)
        {
            guid = _guid;
            type = _type;
            name = _name;
            level = _level;
            ModelVisualID = _ModelVisualID;
            WeaponID = _WeaponID;
            WeaponEffectGem = _WeaponEffectGem;
            RoleCreateTime = _roleCreateTime;
        }
        public ulong guid;
        public int type;
        public string name;
        public int level;
        public int ModelVisualID;
        public int WeaponID;
        public int WeaponEffectGem;
        public UInt32 RoleCreateTime;
        public int CompareTo(object obj)
        {
            PlayerRoleData info = obj as PlayerRoleData;
            return (this.guid < info.guid ? -1 : 1);
        }
    }

    public class ServerListData //: IComparable
    {
        public ServerListData(string id, string name, string ip, string port, string state, string type)
        {
            if (!int.TryParse(id, out m_id))
            {

            }

            m_name = name;
            m_ip = "192.168.43.128";// ip;//"10.161.21.42";//ip;//

            if (!int.TryParse(port, out m_port))
            {

            }

            if (!int.TryParse(state, out m_state))
            {

            }

            if (!int.TryParse(type, out m_type))
            {

            }
        }
        public int m_id;
        public string m_name;
        public string m_ip;
        public int m_port;
        public int m_state;
        public int m_type;      // 是否推荐 大于1推荐

        /*
        public int CompareTo(object obj)
        {
            ServerListData info = obj as ServerListData;
            return (this.m_id > info.m_id ? -1 : 1);
        }
         * */
    }


    public class ServerPageData
    {
        public ServerPageData(int pagePos, string pageName)
        {
            m_pagePos = pagePos;
            m_pageName = pageName;
        }

        public int m_pagePos;
        public string m_pageName;
    }
    public class AccountData
    {
        public enum ConnnectType
        {
            NONE,
            TEST,
            CYOU,
        }
        public string m_account = "";
        public string m_validateInfo = "";
        public string m_userID = "";
        public bool m_bInit = false;
        public ConnnectType m_connectType = ConnnectType.NONE;
        public string m_oid = "";
        public string m_accessToken = "";
        public int m_gameServerValidateInfo = 0;
        public string productCode = "";
        public string channelCode = "";
        public void SetTestData(string account)
        {
            m_account = account;
            m_validateInfo = "";
            m_userID = "";
            m_bInit = true;
            m_connectType = ConnnectType.TEST;
            //PlayerPreferenceData.LastAccount = m_account;
        }

        public void SetCYData(string validateInfo)
        {
            m_account = "";
            m_userID = "";
            m_validateInfo = validateInfo;
            m_bInit = true;
            m_connectType = ConnnectType.CYOU;
        }

        public void SetAccountInfo(string userID, string oid, string accessToken, int gameServerValidateInfo)
        {
            m_userID = userID;
            if (m_connectType != ConnnectType.TEST)
            {
                // 测试登陆会把账号作为ID
                // 其他情况用UID作为ID
                //PlayerPreferenceData.LastAccount = userID;
            }
            //PlayerPreferenceData.UserID = userID;
            m_oid = oid;
            m_accessToken = accessToken;
            m_gameServerValidateInfo = gameServerValidateInfo;
        }
        public void CleanData()
        {
            m_account = "";
            m_validateInfo = "";
            m_userID = "";
            m_bInit = false;
            m_gameServerValidateInfo = 0;
            m_connectType = ConnnectType.NONE;
            //PlayerPreferenceData.LastAccount = "";
            //PlayerPreferenceData.UserID = "";
        }
    }

    public static AccountData accountData = new AccountData();
    public static List<PlayerRoleData> loginRoleList = new List<PlayerRoleData>();

    public static PlayerRoleData GetPlayerRoleData(ulong roleGUID)
    {
        foreach (PlayerRoleData curData in loginRoleList)
        {
            if (curData.guid == roleGUID)
            {
                return curData;
            }
        }

        return null;
    }

    public delegate void LoginRet(GC_LOGIN_RET.LOGINRESULT result, int validateResult);
    public static LoginRet retLogin;
    public static void UpdateLoginData(GC_LOGIN_RET data)
    {
        if (data.Result == (int)GC_LOGIN_RET.LOGINRESULT.SUCCESS)
        {
            LoginData.accountData.SetAccountInfo(data.Userid, data.Oid, data.Accesstoken, data.Rapidvalidatecode);
            LoginData.loginRoleList.Clear();
            for (int i = 0; i < data.roleGUIDListCount; i++)
            {
                LoginData.loginRoleList.Add(new LoginData.PlayerRoleData(
                    data.roleGUIDListList[i],
                    data.roleTypeListList[i],
                    data.playerNameListList[i],
                    data.roleLevelListList[i] > 0 ? data.roleLevelListList[i] : 1,
                    data.ModelVisualIDList[i],
                    data.WeaponIDList[i],
                    data.WeaponEffectGemList[i],
                    data.RoleCreateTimeList[i]));

            }
            LoginData.loginRoleList.Sort();
        }
        if (retLogin != null)
        {
            retLogin((GC_LOGIN_RET.LOGINRESULT)data.Result, data.Validateresult);
        }
    }


    public static string m_sRoleName = "xxx";
    public static bool m_sbIsMale = false;
    public static void UpdateLoginRoleInfo(ulong roleGUID)
    {

        //PlayerPreferenceData.LastRoleGUID = roleGUID;
        foreach (PlayerRoleData curData in loginRoleList)
        {
            if (curData.guid == roleGUID)
            {
                m_sRoleName = curData.name;
                //m_sbIsMale = (curData.type == (int)CharacterDefine.PROFESSION.DALI || curData.type == (int)CharacterDefine.PROFESSION.SHAOLIN) ? true : false;
                //PlatformHelper.RoleEnterGame(curData.guid.ToString(), curData.type.ToString(), curData.name, curData.level);
            }
        }
    }

    public const int QueueDefaultNum = 100000;
    public static GC_LOGIN_QUEUE_STATUS.QUEUESTATUS m_curQueueState;
    public static int m_curQueueNum = QueueDefaultNum;
    public static void UpdateLoginQueueState(int state, int num)
    {
        m_curQueueState = (GC_LOGIN_QUEUE_STATUS.QUEUESTATUS)state;
        /*
        m_curQueueState = (GC_LOGIN_QUEUE_STATUS.QUEUESTATUS)data.Status;
        m_curQueueNum = data.Index;
        */
        if (m_curQueueState == GC_LOGIN_QUEUE_STATUS.QUEUESTATUS.BEGINQUEUE || m_curQueueState == GC_LOGIN_QUEUE_STATUS.QUEUESTATUS.QUEUING)
        {
            if (m_curQueueState == GC_LOGIN_QUEUE_STATUS.QUEUESTATUS.BEGINQUEUE)
            {
                m_curQueueNum = QueueDefaultNum;
            }
            else
            {
                if (num < m_curQueueNum)
                {
                    m_curQueueNum = num;
                }
            }

        }
        else if (m_curQueueState == GC_LOGIN_QUEUE_STATUS.QUEUESTATUS.ENDQUEUE)
        {
        }
    }

    public static List<ServerListData> serverListData = new List<ServerListData>();
    public static List<ServerPageData> serverPageData = new List<ServerPageData>();

    public static ServerListData GetServerListDataByID(int id)
    {
        foreach (ServerListData curData in serverListData)
        {
            if (curData.m_id == id)
            {
                return curData;
            }
        }

        return null;
    }

    //public static int GetRecommandServerID()
    //{
    //    List<int> idRecomand = new List<int>();
    //    for (int curDataIndex = 0; curDataIndex < LoginData.serverListData.Count; curDataIndex++)
    //    {
    //        if (LoginData.serverListData[curDataIndex].m_id == PlayerPreferenceData.LastServer)
    //        {

    //            return LoginData.serverListData[curDataIndex].m_id;
    //        }
    //        if (LoginData.serverListData[curDataIndex].m_type > 0)
    //        {
    //            idRecomand.Add(LoginData.serverListData[curDataIndex].m_id);
    //        }
    //    }

    //    if (idRecomand.Count > 0)
    //    {
    //        return idRecomand[UnityEngine.Random.Range(0, idRecomand.Count - 1)];
    //    }

    //    if (LoginData.serverListData.Count > 0)
    //    {
    //        return LoginData.serverListData[LoginData.serverListData.Count - 1].m_id;
    //    }

    //    return 0;
    //}

    //public static void Ret_Login(GC_LOGIN_RET.LOGINRESULT result, int validateResult)
    //{
    //   // PlatformHelper.SendUserAction(UserBehaviorDefine.LoginVarifyTokenFinish);

    //    LogModule.DebugLog("connect result: " + result.ToString() + " validateResult: " + validateResult);
    //    UIManager.CloseUI(UIInfo.QueueWindow);
    //    MessageBoxLogic.CloseBox();
    //    if (result == GC_LOGIN_RET.LOGINRESULT.SUCCESS)
    //    {
    //        LoginUILogic.Instance().LoginSuccess();
    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.ACCOUNTVERIFYFAIL)
    //    {
    //        // 登录失败
    //        if (validateResult == 6)
    //        {
    //           // PlatformHelper.UserLogout();
    //            accountData.CleanData();
    //            MessageBoxLogic.OpenOKBox(2369, 1000, SDKVarifyFail);
    //        }
    //        else
    //        {
    //            string strTip = StrDictionary.GetClientDictionaryString("#{1284}", (int)validateResult);
    //            string strTitle = StrDictionary.GetClientDictionaryString("#{1000}");
    //            MessageBoxLogic.OpenOKBox(strTip, strTitle);
    //        }

    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.ALREADYLOGIN)
    //    {
    //        // 该账户已经登录
    //        MessageBoxLogic.OpenOKBox(1285, 1000);
    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.READROLELISTFAIL)
    //    {
    //        // 获取角色列表失败
    //        MessageBoxLogic.OpenOKBox(1286, 1000);
    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.QUEUEFULL)
    //    {
    //        // 队伍已满，请稍后尝试
    //        MessageBoxLogic.OpenOKBox(1852, 1000);
    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.VERSIONNOTMATCH || result == GC_LOGIN_RET.LOGINRESULT.PACKETNOTMATCH)
    //    {
    //        // 客户端版本过低
    //        MessageBoxLogic.OpenOKBox(2161, 1000, VersionNotMatch);
    //    }
    //    else if (result == GC_LOGIN_RET.LOGINRESULT.NEEDFORCEENTER)
    //    {
    //        if (null != ServerChooseController.Instance())
    //        {
    //            ServerChooseController.Instance().ShowForceEnterTip(true);
    //        }
    //        else
    //        {
    //            MessageBoxLogic.OpenOKBox(2161, 1000, VersionNotMatch);
    //        }
    //    }
    //    else
    //    {
    //        MessageBoxLogic.OpenOKBox(1287, 1000);
    //    }
    //}

    //  static void VersionNotMatch()
    //  {
    //LoginUILogic.DoUpdateApp();
    //  }

    //  static void SDKVarifyFail()
    //  {
    //      PlatformHelper.UserLogin();
    //  }

    public static string m_strTestAccount = "";
    public static bool m_bEnableTestAccount = false;

    public static List<string> m_randomNameList = new List<string>();

    public static void UpdateRandomNameList(GC_RET_RANDOMNAME packet)
    {
        for (int i = 0, count = packet.namesCount; i < count; i++)
        {
            if (packet.GetNames(i).Length > 0)
            {
                m_randomNameList.Add(packet.GetNames(i));
            }
        }
    }
}