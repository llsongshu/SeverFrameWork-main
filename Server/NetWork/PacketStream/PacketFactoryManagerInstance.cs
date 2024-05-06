//This code create by CodeEngine Author:Wendy ,don't modify

namespace SPacket.SocketInstance
{
    public class PacketFactoryManagerInstance : PacketFactoryManager
    {
        public override bool Init()
        {
            AddFactory(new GC_LOGIN_RET_PF());
            AddFactory(new GC_CONNECTED_HEARTBEAT_PF());
            AddFactory(new GC_NOTICE_PF());
            AddFactory(new GC_MISSION_SYNC_MISSIONLIST_PF());
            AddFactory(new GC_ACCEPTMISSION_RET_PF());
            AddFactory(new GC_COMPLETEMISSION_RET_PF());
            AddFactory(new GC_ABANDONMISSION_RET_PF());
            AddFactory(new GC_MISSION_STATE_PF());
            AddFactory(new GC_MISSION_PARAM_PF());
            AddFactory(new GC_ENTER_SCENE_PF());
            AddFactory(new GC_CREATE_PLAYER_PF());
            AddFactory(new GC_DELETE_OBJ_PF());
            AddFactory(new GC_SYNC_POS_PF());
            AddFactory(new GC_MOVE_PF());
            AddFactory(new GC_STOP_PF());
            AddFactory(new GC_SYSTEMSHOP_MERCHANDISELIST_PF());
            AddFactory(new GC_UPDATENOTICEDATA_PF());
            AddFactory(new GC_UPDATEITEM_PF());
            AddFactory(new GC_TEAM_LEAVE_PF());
            AddFactory(new GC_TEAM_SYNC_TEAMINFO_PF());
            AddFactory(new GC_TEAM_SYNC_MEMBERINFO_PF());
            AddFactory(new GC_JOIN_TEAM_INVITE_PF());
            AddFactory(new GC_JOIN_TEAM_REQUEST_PF());
            AddFactory(new GC_NEAR_PLAYERLIST_PF());
            AddFactory(new GC_NEAR_TEAMLIST_PF());
            AddFactory(new GC_CREATEROLE_RET_PF());
            AddFactory(new GC_SELECTROLE_RET_PF());
            AddFactory(new GC_CDTIME_UPDATE_PF());
            AddFactory(new GC_BROADCAST_ATTR_PF());
            AddFactory(new GC_SYN_ATTR_PF());
            AddFactory(new GC_BELLE_DATA_PF());
            AddFactory(new GC_BELLE_CLOSE_RET_PF());
            AddFactory(new GC_BELLE_EVOLUTION_RET_PF());
            AddFactory(new GC_BELLE_EVOLUTIONRAPID_RET_PF());
            AddFactory(new GC_BELLE_BATTLE_RET_PF());
            AddFactory(new GC_BELLE_REST_RET_PF());
            AddFactory(new GC_BELLE_ACTIVEMATRIX_RET_PF());
            AddFactory(new GC_BELLE_ACTIVE_PF());
            AddFactory(new GC_UPDATE_ALL_TITLEINVESTITIVE_PF());
            AddFactory(new GC_GAIN_TITLE_PF());
            AddFactory(new GC_DELETE_TITLE_PF());
            AddFactory(new GC_ACTIVE_TITLE_PF());
            AddFactory(new GC_SYNC_ACTIVETITLE_PF());
            AddFactory(new GC_MOUNTCOLLECTED_FLAG_PF());
            AddFactory(new GC_MOUNT_DATA_PF());
            AddFactory(new GC_MOUNT_MARK_RET_PF());
            AddFactory(new GC_EQUIP_ENCHANCE_RET_PF());
            AddFactory(new GC_EQUIP_STAR_RET_PF());
            AddFactory(new GC_CHAT_PF());
            AddFactory(new GC_ADDFRIEND_PF());
            AddFactory(new GC_RET_FRIEND_USERINFO_PF());
            AddFactory(new GC_DELFRIEND_PF());
            AddFactory(new GC_NOTICE_ADDED_FRIEND_PF());
            AddFactory(new GC_SYC_FRIEND_STATE_PF());
            AddFactory(new GC_SYC_FRIEND_INFO_PF());
            AddFactory(new GC_SYC_FULL_FRIEND_LIST_PF());
            AddFactory(new GC_ADDBLACKLIST_PF());
            AddFactory(new GC_SYC_FULL_BLACK_LIST_PF());
            AddFactory(new GC_DELBLACKLIST_PF());
            AddFactory(new GC_FINDPLAYER_PF());
            AddFactory(new GC_SYNSELTRAGET_ATTR_PF());
            AddFactory(new GC_CREATE_NPC_PF());
            AddFactory(new GC_PLAYSTORY_PF());
            AddFactory(new GC_RET_RELIVE_PF());
            AddFactory(new GC_DROPITEM_INFO_PF());
            AddFactory(new GC_RET_PICKUP_ITEM_PF());
            AddFactory(new GC_UPDATE_FELLOW_PF());
            AddFactory(new GC_SERVER_SERIOUSERROR_PF());
            AddFactory(new GC_ADDITIONINFO_UPDATE_PF());
            AddFactory(new GC_RET_SELOBJ_INFO_PF());
            AddFactory(new GC_RET_USE_SKILL_PF());
            AddFactory(new GC_CREATE_FELLOW_PF());
            AddFactory(new GC_RET_ROLE_DATA_PF());
            AddFactory(new GC_CALL_FELLOW_RET_PF());
            AddFactory(new GC_UNCALL_FELLOW_RET_PF());
            AddFactory(new GC_NEWSERVERAWARD_DATA_PF());
            AddFactory(new GC_DAYAWARD_DATA_PF());
            AddFactory(new GC_ONLINEAWARD_DATA_PF());
            AddFactory(new GC_ASK_ACTIVENESSAWARD_RET_PF());
            AddFactory(new GC_SYNC_ACTIVENESSAWARD_PF());
            AddFactory(new GC_DAMAGEBOARD_INFO_PF());
            AddFactory(new GC_COPYSCENE_INVITE_PF());
            AddFactory(new GC_COPYSCENE_RESULT_PF());
            AddFactory(new GC_RET_COPYSCENE_REWARD_PF());
            AddFactory(new GC_RET_COPYSCENE_SWEEP_PF());
            AddFactory(new GC_MISSION_IGNOREMISSIONPREFLAG_PF());
            AddFactory(new GC_COMBATVALUE_RET_PF());
            AddFactory(new GC_PLAY_EFFECT_PF());
            AddFactory(new GC_RET_PKINFO_PF());
            AddFactory(new GC_RET_CHANGE_PKMODLE_PF());
            AddFactory(new GC_CHANGE_PKLIST_PF());
            AddFactory(new GC_MAIL_UPDATE_PF());
            AddFactory(new GC_MAIL_DELETE_PF());
            AddFactory(new GC_OP_TELEPORT_PF());
            AddFactory(new GC_OP_QINGGONGPOINT_PF());
            AddFactory(new GC_CHALLENGE_MYDATA_PF());
            AddFactory(new GC_OPPONENT_LIST_PF());
            AddFactory(new GC_CHALLENGERANKLIST_PF());
            AddFactory(new GC_CREATE_ZOMBIEUSER_PF());
            AddFactory(new GC_CHALLENGE_REWARD_PF());
            AddFactory(new GC_CHALLENGE_HISTORY_PF());
            AddFactory(new GC_UI_OPERATION_PF());
            AddFactory(new GC_SCENE_TIMESCALE_PF());
            AddFactory(new GC_SKILL_FINISH_PF());
            AddFactory(new GC_SHOW_EQUIPREMIND_PF());
            AddFactory(new GC_UI_NEWPLAYERGUIDE_PF());
            AddFactory(new GC_SKILL_STUDY_PF());
            AddFactory(new GC_PLAY_MODELSOTRY_PF());
            AddFactory(new GC_SYN_SKILLINFO_PF());
            AddFactory(new GC_UPDATE_SCENE_INSTACTIVATION_PF());
            AddFactory(new GC_UPDATE_ANIMATION_STATE_PF());
            AddFactory(new GC_UPDATE_HITPONIT_PF());
            AddFactory(new GC_TELEMOVE_PF());
            AddFactory(new GC_PLAYSHANDIANLIANEFFECT_PF());
            AddFactory(new GC_REMOVEEFFECT_PF());
            AddFactory(new GC_ATTACKFLY_PF());
            AddFactory(new GC_COUNTDOWN_PF());
            AddFactory(new GC_BACKPACK_RESIZE_PF());
            AddFactory(new GC_USE_ITEM_RET_PF());
            AddFactory(new GC_USERTIP_PF());
            AddFactory(new GC_MONEYTREE_DATA_PF());
            AddFactory(new GC_RET_QUIT_GAME_PF());
            AddFactory(new GC_RESOLVE_FELLOW_RET_PF());
            AddFactory(new GC_SYNC_REACHEDSCENE_PF());
            AddFactory(new GC_UPDATE_ACTIVE_FELLOWSKILL_PF());
            AddFactory(new GC_EQUIP_FELLOW_SKILL_RET_PF());
            AddFactory(new GC_UNEQUIP_FELLOW_SKILL_RET_PF());
            AddFactory(new GC_LEVELUP_FELLOW_SKILL_RET_PF());
            AddFactory(new GC_FORCE_SETPOS_PF());
            AddFactory(new GC_DEBUG_MY_POS_PF());
            AddFactory(new GC_PLAY_SOUNDS_PF());
            AddFactory(new GC_DAILYMISSION_UPDATE_RET_PF());
            AddFactory(new GC_ASK_LOUDSPEAKER_CONTENT_PF());
            AddFactory(new GC_ASK_GAIN_FELLOW_RET_PF());
            AddFactory(new GC_UPDATE_GAIN_FELLOW_COUNT_PF());
            AddFactory(new GC_HUASHAN_PVP_MEMBERLIST_PF());
            AddFactory(new GC_HUASHAN_PVP_STATE_PF());
            AddFactory(new GC_HUASHAN_PVP_SELFPOSITION_PF());
            AddFactory(new GC_HUASHAN_PVP_SHOWSEARCH_PF());
            AddFactory(new GC_HUASHAN_PVP_OPPONENTVIEW_PF());
            AddFactory(new GC_HUASHAN_PVP_ASSIST_STATE_PF());
            AddFactory(new GC_DUEL_REQUESTU_PF());
            AddFactory(new GC_DUEL_STATE_PF());
            AddFactory(new GC_MERCENARY_LIST_RES_PF());
            AddFactory(new GC_MERCENARY_LEFTTIMES_PF());
            AddFactory(new GC_MERCENARY_EMPLOYLIST_PF());
            AddFactory(new GC_WORLDBOSS_DEAD_PF());
            AddFactory(new GC_WORLDBOSS_TEAMLIST_PF());
            AddFactory(new GC_WORLDBOSS_OPEN_PF());
            AddFactory(new GC_RET_MYCONSIGNSALEITEM_PF());
            AddFactory(new GC_RET_CONSIGNSALEITEMINFO_PF());
            AddFactory(new GC_SYNC_COMMONDATA_PF());
            AddFactory(new GC_SYNC_COMMONFLAG_PF());
            AddFactory(new GC_ASK_COMMONFLAG_RET_PF());
            AddFactory(new GC_DAILYLUCKYDRAW_GAINBONUS_PF());
            AddFactory(new GC_DAILYLUCKYDRAW_UPDATE_PF());
            AddFactory(new GC_DAILYLUCKYDRAW_FAIL_PF());
            AddFactory(new GC_UPDATE_GEM_INFO_PF());
            AddFactory(new GC_PUT_GEM_RET_PF());
            AddFactory(new GC_TAKE_GEM_RET_PF());
            AddFactory(new GC_SYNC_ACTIVENESS_PF());
            AddFactory(new GC_SEND_FASHIONINFO_PF());
            AddFactory(new GC_SYNC_FASHION_PF());
            AddFactory(new GC_SEND_CURFASHION_PF());
            AddFactory(new GC_RET_TEAMPLATFORMINFO_PF());
            AddFactory(new GC_RET_AUTOTEAM_PF());
            AddFactory(new GC_FELLOW_STAR_RET_PF());
            AddFactory(new GC_FELLOW_ENCHANCE_RET_PF());
            AddFactory(new GC_FELLOW_APPLY_POINT_RET_PF());
            AddFactory(new GC_GUILD_RET_LIST_PF());
            AddFactory(new GC_GUILD_RET_INFO_PF());
            AddFactory(new GC_GUILD_CREATE_PF());
            AddFactory(new GC_GUILD_JOIN_PF());
            AddFactory(new GC_GUILD_LEAVE_PF());
            AddFactory(new GC_GUILD_RET_LEVELUP_PF());
            AddFactory(new GC_DYNAMICOBSTACLE_OPT_PF());
            AddFactory(new GC_FELLOW_CHANGE_NAME_RET_PF());
            AddFactory(new GC_UPDATE_NEEDIMPACTINFO_PF());
            AddFactory(new GC_MASTER_RET_LIST_PF());
            AddFactory(new GC_MASTER_RET_INFO_PF());
            AddFactory(new GC_MASTER_CREATE_PF());
            AddFactory(new GC_MASTER_JOIN_PF());
            AddFactory(new GC_MASTER_LEAVE_PF());
            AddFactory(new GC_MASTER_KICK_PF());
            AddFactory(new GC_MASTER_APPROVE_RESERVE_PF());
            AddFactory(new GC_MASTER_LEARN_SKILL_PF());
            AddFactory(new GC_MASTER_FORGET_SKILL_PF());
            AddFactory(new GC_MASTER_ACTIVE_SKILL_PF());
            AddFactory(new GC_RET_RANK_PF());
            AddFactory(new GC_RESTAURANT_UPDATE_PF());
            AddFactory(new GC_RESTAURANT_DESTUPDATE_PF());
            AddFactory(new GC_RESTAURANT_LEVELUPDATE_PF());
            AddFactory(new GC_SYNC_COPYSCENENUMBER_PF());
            AddFactory(new GC_CHANGE_SHOWFASHION_PF());
            AddFactory(new GC_CREATE_SNARE_PF());
            AddFactory(new GC_RET_PRELIMINARY_WARINFO_PF());
            AddFactory(new GC_SYN_TORCH_VALUE_PF());
            AddFactory(new GC_ASK_STARTGUILDWAR_PF());
            AddFactory(new GC_SHOW_PRELIMINARY_WARRET_PF());
            AddFactory(new GC_QIANKUNDAI_PRODUCT_PF());
            AddFactory(new GC_RET_FINALGUILDWARGROUPINFO_PF());
            AddFactory(new GC_RET_FINALGUILDWARPOINTINFO_PF());
            AddFactory(new GC_UPDATE_STAMINA_TIME_PF());
            AddFactory(new GC_LOGIN_QUEUE_STATUS_PF());
            AddFactory(new GC_RET_YUANBAOSHOP_OPEN_PF());
            AddFactory(new GC_SHOW_BLACKMARKET_PF());
            AddFactory(new GC_OPENFUNCTION_PF());
            AddFactory(new GC_RET_OTHERROLE_DATA_PF());
            AddFactory(new GC_SHOW_ITEMREMIND_PF());
            AddFactory(new GC_RET_PUT_GEM_PF());
            AddFactory(new GC_UPDATE_SWORDSMAN_PF());
            AddFactory(new GC_UPDATE_SWORDSMAN_VISITSTATE_PF());
            AddFactory(new GC_ACTIVITYNOTICE_PF());
            AddFactory(new GC_RET_FELLOW_RESET_POINT_PF());
            AddFactory(new GC_RES_POWERUP_PF());
            AddFactory(new GC_POWERUP_LIST_PF());
            AddFactory(new GC_BUY_GUILDGOODS_PF());
            AddFactory(new GC_SYNC_AWARDTABLE_PF());
            AddFactory(new GC_RET_RANDOMNAME_PF());
            AddFactory(new GC_GUILD_NEWRESERVE_PF());
            AddFactory(new GC_SHOW_SKILLNAME_PF());
            AddFactory(new GC_RET_CURGUILDWARTYPE_PF());
            AddFactory(new GC_SWORDSMANPACK_RESIZE_PF());
            AddFactory(new GC_RET_VISIT_SWORDSMAN_PF());
            AddFactory(new GC_RET_LEVELUP_SWORDSMAN_PF());
            AddFactory(new GC_RET_MARRAGE_PF());
            AddFactory(new GC_SYN_LOVERINFO_PF());
            AddFactory(new GC_SNS_INVITE_CODE_RESPONSE_PF());
            AddFactory(new GC_SNS_ACTIVE_SHOW_PF());
            AddFactory(new GC_PUSH_NOTIFICATION_PF());
            AddFactory(new GC_SHOW_USEITEMREMIND_PF());
            AddFactory(new GC_NEWONLINEAWARD_DATA_PF());
            AddFactory(new GC_SYNC_NEWONLINEAWARDTABLE_PF());
            AddFactory(new GC_ASK_GAIN_10_FELLOW_RET_PF());
            AddFactory(new GC_GUILD_INVITE_CONFIRM_PF());
            AddFactory(new GC_SYNC_PAY_ACTIVITY_DATA_PF());
            AddFactory(new GC_ASK_PAY_ACTIVITY_PRIZE_RET_PF());
            AddFactory(new GC_RET_LOCK_TITLE_PF());
            AddFactory(new GC_UPDATE_STORAGEPACK_PF());
            AddFactory(new GC_ASK_UPDATE_STORAGEPACK_RET_PF());
            AddFactory(new GC_PUT_ITEM_STORAGEPACK_RET_PF());
            AddFactory(new GC_TAKE_ITEM_STORAGEPACK_RET_PF());
            AddFactory(new GC_RET_CHANGENAME_PF());
            AddFactory(new GC_WORLDBOSS_SOMECHALL_ME_PF());
            AddFactory(new GC_SYNC_MASTER_SKILL_NAME_PF());
            AddFactory(new GC_SYNC_COPYSCENEEXTRANUMBER_PF());
            AddFactory(new GC_CHANGENAME_PF());
            AddFactory(new GC_RET_BLACKMARKETITEMINFO_PF());
            AddFactory(new GC_CLOSE_BLACKMARKET_PF());
            AddFactory(new GC_WORLDBOSS_CHALLEGE_RES_PF());
            AddFactory(new GC_RET_HUASHAN_PKINFO_PF());
            AddFactory(new GC_PLAY_YANHUA_PF());
            AddFactory(new GC_CREATE_YANHUA_PF());
            AddFactory(new GC_SYC_FULL_HATE_LIST_PF());
            AddFactory(new GC_DELHATELIST_PF());
            AddFactory(new GC_RET_TRAIL_PF());
            AddFactory(new GC_ADDHATELIST_PF());
            AddFactory(new GC_UPDATE_DEF_TITLE_PF());
            AddFactory(new GC_SERVER_CONFIG_PF());
            AddFactory(new GC_OPEN_SHAREWINDOW_PF());
            AddFactory(new GC_MASTERSHOP_BUY_PF());
            AddFactory(new GC_UPDATE_RECHARGESTATE_PF());
            AddFactory(new GC_RET_ENEMYGUILDINFO_PF());
            AddFactory(new GC_RET_ISWILDENEMY2USER_PF());
            AddFactory(new GC_RESTAURANT_VISITFRIENDINFO_PF());
            AddFactory(new GC_SHOWPKNOTICE_PF());
            AddFactory(new GC_GUILDACTIVITY_BOSSDATA_PF());
            AddFactory(new GC_NEW7DAYONLINEAWARD_DATA_PF());
            AddFactory(new GC_SYNC_NEW7DAYONLINEAWARDTABLE_PF());
            AddFactory(new GC_SERVERFLAGS_PF());
            AddFactory(new GC_TODAY_FIRST_LOGIN_PF());
            AddFactory(new GC_RET_GUILDBUSINESSINFO_PF());
            AddFactory(new GC_SYNC_PLAYER_STATE_PF());
            AddFactory(new GC_RET_GUILDMISSIONINFO_PF());
            AddFactory(new GC_SYNC_PLAYERFACEDIR_PF());
            AddFactory(new GC_DO_CLIENT_SCRIPT_PF());
            AddFactory(new GC_LEVELAWARD_DATA_PF());
            AddFactory(new GC_RET_JUQINGITEM_PLAYEFFECT_PF());
            AddFactory(new GC_BELLE_CANCELMATRIX_RET_PF());
            AddFactory(new GC_DAILYAWARD_DATA_PF());
            AddFactory(new GC_ADDPAY_TEST_PF());
            AddFactory(new GC_7DAYAWARD_DATA_PF());
            AddFactory(new GC_PAY_ORDER_PF());
            AddFactory(new GC_ASK_PAY_ACTIVITY_RET_PF());
            AddFactory(new GC_ASK_BINDNUMBER_RET_PF());
            AddFactory(new GC_RET_FANKUI_PF());
            AddFactory(new GC_RET_ACTIVE_YUEKA_PF());
            AddFactory(new GC_RET_ACTIVE_LEICHONG_PF());
            AddFactory(new CG_LOGIN_PF());
            AddFactory(new CG_CONNECTED_HEARTBEAT_PF());
            AddFactory(new CG_ACCEPTMISSION_PF());
            AddFactory(new CG_COMPLETEMISSION_PF());
            AddFactory(new CG_ABANDONMISSION_PF());
            AddFactory(new CG_REQ_CHANGE_SCENE_PF());
            AddFactory(new CG_ENTER_SCENE_OK_PF());
            AddFactory(new CG_SYNC_POS_PF());
            AddFactory(new CG_MOVE_PF());
            AddFactory(new CG_SYSTEMSHOP_VIEW_PF());
            AddFactory(new CG_SYSTEMSHOP_BUY_PF());
            AddFactory(new CG_SYSTEMSHOP_BUYBACK_PF());
            AddFactory(new CG_SYSTEMSHOP_SELL_PF());
            AddFactory(new CG_REQ_TEAM_INVITE_PF());
            AddFactory(new CG_REQ_TEAM_JOIN_PF());
            AddFactory(new CG_REQ_TEAM_LEAVE_PF());
            AddFactory(new CG_REQ_TEAM_KICK_MEMBER_PF());
            AddFactory(new CG_REQ_TEAM_CHANGE_LEADER_PF());
            AddFactory(new CG_JOIN_TEAM_INVITE_RESULT_PF());
            AddFactory(new CG_JOIN_TEAM_REQUEST_RESULT_PF());
            AddFactory(new CG_REQ_NEAR_LIST_PF());
            AddFactory(new CG_USE_ITEM_PF());
            AddFactory(new CG_EQUIP_ITEM_PF());
            AddFactory(new CG_UNEQUIP_ITEM_PF());
            AddFactory(new CG_CREATEROLE_PF());
            AddFactory(new CG_SELECTROLE_PF());
            AddFactory(new CG_SKILL_USE_PF());
            AddFactory(new CG_THROW_ITEM_PF());
            AddFactory(new CG_BELLE_CLOSE_PF());
            AddFactory(new CG_BELLE_EVOLUTION_PF());
            AddFactory(new CG_BELLE_EVOLUTIONRAPID_PF());
            AddFactory(new CG_BELLE_BATTLE_PF());
            AddFactory(new CG_BELLE_REST_PF());
            AddFactory(new CG_BELLE_ACTIVEMATRIX_PF());
            AddFactory(new CG_ACTIVE_TITLE_PF());
            AddFactory(new CG_DELETE_TITLE_PF());
            AddFactory(new CG_MOUNT_MARK_PF());
            AddFactory(new CG_MOUNT_MOUNT_PF());
            AddFactory(new CG_MOUNT_UNMOUNT_PF());
            AddFactory(new CG_EQUIP_ENCHANCE_PF());
            AddFactory(new CG_EQUIP_STAR_PF());
            AddFactory(new CG_CHAT_PF());
            AddFactory(new CG_ADDFRIEND_PF());
            AddFactory(new CG_DELFRIEND_PF());
            AddFactory(new CG_REQ_FRIEND_USERINFO_PF());
            AddFactory(new CG_ADDBLACKLIST_PF());
            AddFactory(new CG_DELBLACKLIST_PF());
            AddFactory(new CG_FINDPLAYER_PF());
            AddFactory(new CG_GMCOMMAND_PF());
            AddFactory(new CG_PLAYSTORY_OVER_PF());
            AddFactory(new CG_ASK_RELIVE_PF());
            AddFactory(new CG_ASK_PICKUP_ITEM_PF());
            AddFactory(new CG_ASK_SELOBJ_INFO_PF());
            AddFactory(new CG_ASK_ROLE_DATA_PF());
            AddFactory(new CG_CALL_FELLOW_PF());
            AddFactory(new CG_UNCALL_FELLOW_PF());
            AddFactory(new CG_ASK_NEWSERVERAWARD_PF());
            AddFactory(new CG_ASK_DAYAWARD_PF());
            AddFactory(new CG_ASK_ONLINEAWARD_PF());
            AddFactory(new CG_ASK_ACTIVENESSAWARD_PF());
            AddFactory(new CG_OPEN_COPYSCENE_PF());
            AddFactory(new CG_COPYSCENE_INVITE_RET_PF());
            AddFactory(new CG_ASK_COPYSCENE_REWARD_PF());
            AddFactory(new CG_ASK_COPYSCENE_SWEEP_PF());
            AddFactory(new CG_COMBATVALUE_ASK_PF());
            AddFactory(new CG_ASK_PKINFO_PF());
            AddFactory(new CG_CHANGE_PKMODLE_PF());
            AddFactory(new CG_MAIL_SEND_PF());
            AddFactory(new CG_MAIL_OPERATION_PF());
            AddFactory(new CG_SEND_GUILDMAIL_PF());
            AddFactory(new CG_RANDOM_OPPONENT_PF());
            AddFactory(new CG_CHALLENGERANKLIST_REQ_PF());
            AddFactory(new CG_REQ_CHALLENGE_PF());
            AddFactory(new CG_LEAVE_COPYSCENE_PF());
            AddFactory(new CG_USER_BEHAVIOR_PF());
            AddFactory(new CG_ASK_LEVELUPSKILL_PF());
            AddFactory(new CG_BACKPACK_UNLOCK_PF());
            AddFactory(new CG_MONEYTREE_ASKAWARD_PF());
            AddFactory(new CG_CHANGE_MAJORCITY_PF());
            AddFactory(new CG_ASK_QUIT_GAME_PF());
            AddFactory(new CG_LOCK_FELLOW_PF());
            AddFactory(new CG_UNLOCK_FELLOW_PF());
            AddFactory(new CG_RESOLVE_FELLOW_PF());
            AddFactory(new CG_EQUIP_FELLOW_SKILL_PF());
            AddFactory(new CG_UNEQUIP_FELLOW_SKILL_PF());
            AddFactory(new CG_LEVELUP_FELLOW_SKILL_PF());
            AddFactory(new CG_DAILYMISSION_UPDATE_PF());
            AddFactory(new CG_ASK_LOUDSPEAKER_POOL_PF());
            AddFactory(new CG_ASK_GAIN_FELLOW_PF());
            AddFactory(new CG_HUASHAN_PVP_REGISTER_PF());
            AddFactory(new CG_HUASHAN_PVP_MEMBERLIST_PF());
            AddFactory(new CG_HUASHAN_ASSIST_REQ_PF());
            AddFactory(new CG_DUEL_REQUEST_PF());
            AddFactory(new CG_DUEL_RESPONSE_PF());
            AddFactory(new CG_MERCENARY_LIST_REQ_PF());
            AddFactory(new CG_MERCENARY_REQ_PF());
            AddFactory(new CG_WORLDBOSS_TEAMLIST_REQ_PF());
            AddFactory(new CG_WORLDBOSS_CHALLENGE_PF());
            AddFactory(new CG_WORLDBOSS_JOIN_PF());
            AddFactory(new CG_CONSIGNSALEITEM_PF());
            AddFactory(new CG_CANCELCONSIGNSALEITEM_PF());
            AddFactory(new CG_ASK_MYCONSIGNSALEITEM_PF());
            AddFactory(new CG_ASK_CONSIGNSALEITEMINFO_PF());
            AddFactory(new CG_BUY_CONSIGNSALEITEMINFO_PF());
            AddFactory(new CG_ASK_SETCOMMONFLAG_PF());
            AddFactory(new CG_DAILYLUCKYDRAW_DRAW_PF());
            AddFactory(new CG_PUT_GEM_PF());
            AddFactory(new CG_TAKE_GEM_PF());
            AddFactory(new CG_BUY_FASHION_PF());
            AddFactory(new CG_WEAR_FASHION_PF());
            AddFactory(new CG_TAKEOFF_FASHION_PF());
            AddFactory(new CG_ASK_TEAMPLATFORMINFO_PF());
            AddFactory(new CG_ASK_AUTOTEAM_PF());
            AddFactory(new CG_FELLOW_STAR_PF());
            AddFactory(new CG_FELLOW_ENCHANCE_PF());
            AddFactory(new CG_FELLOW_APPLY_POINT_PF());
            AddFactory(new CG_GUILD_REQ_LIST_PF());
            AddFactory(new CG_GUILD_REQ_INFO_PF());
            AddFactory(new CG_GUILD_REQ_CHANGE_NOTICE_PF());
            AddFactory(new CG_GUILD_CREATE_PF());
            AddFactory(new CG_GUILD_JOIN_PF());
            AddFactory(new CG_GUILD_LEAVE_PF());
            AddFactory(new CG_GUILD_KICK_PF());
            AddFactory(new CG_GUILD_JOB_CHANGE_PF());
            AddFactory(new CG_GUILD_APPROVE_RESERVE_PF());
            AddFactory(new CG_GUILD_REQ_LEVELUP_PF());
            AddFactory(new CG_FELLOW_CHANGE_NAME_PF());
            AddFactory(new CG_BUY_YUANBAOGOODS_PF());
            AddFactory(new CG_BUY_GUILDGOODS_PF());
            AddFactory(new CG_MASTER_REQ_LIST_PF());
            AddFactory(new CG_MASTER_REQ_INFO_PF());
            AddFactory(new CG_MASTER_REQ_CHANGE_NOTICE_PF());
            AddFactory(new CG_MASTER_CREATE_PF());
            AddFactory(new CG_MASTER_JOIN_PF());
            AddFactory(new CG_MASTER_LEAVE_PF());
            AddFactory(new CG_MASTER_KICK_PF());
            AddFactory(new CG_MASTER_APPROVE_RESERVE_PF());
            AddFactory(new CG_MASTER_ACTIVE_SKILL_PF());
            AddFactory(new CG_MASTER_FORGET_SKILL_PF());
            AddFactory(new CG_MASTER_LEARN_SKILL_PF());
            AddFactory(new CG_ASK_RANK_PF());
            AddFactory(new CG_RESTAURANT_PREPAREFOOD_PF());
            AddFactory(new CG_RESTAURANT_BILLINGALL_PF());
            AddFactory(new CG_RESTAURANT_FINISHPREPARE_PF());
            AddFactory(new CG_RESTAURANT_ACTIVEDESK_PF());
            AddFactory(new CG_RESTAURANT_VISITFRIEND_PF());
            AddFactory(new CG_SCENE_CHANGEINST_PF());
            AddFactory(new CG_COPYSCENERESET_PF());
            AddFactory(new CG_CHANGE_SHOWFASHION_PF());
            AddFactory(new CG_USE_LIVINGSKILL_PF());
            AddFactory(new CG_PRELIMINARY_APPLYGUILDWAR_PF());
            AddFactory(new CG_ASK_PRELIMINARY_WARINFO_PF());
            AddFactory(new CG_ASK_TORCH_VALUE_PF());
            AddFactory(new CG_RET_STARTWAR_PF());
            AddFactory(new CG_QIANKUNDAI_COMBINE_PF());
            AddFactory(new CG_ACTIVE_FELLOW_SKILL_PF());
            AddFactory(new CG_BUY_STAMINA_PF());
            AddFactory(new CG_FIGHTGUILDWARPOINT_PF());
            AddFactory(new CG_ASK_FINALGUILDWARGROUPINFO_PF());
            AddFactory(new CG_ASK_FINALGUILDWARPOINTINFO_PF());
            AddFactory(new CG_ASK_YUANBAOSHOP_OPEN_PF());
            AddFactory(new CG_ASK_OTHERROLE_DATA_PF());
            AddFactory(new CG_ASK_HIDE_FELLOW_PF());
            AddFactory(new CG_ASK_SHOW_FELLOW_PF());
            AddFactory(new CG_CYPAY_SUCCESS_PF());
            AddFactory(new CG_VISIT_SWORDSMAN_PF());
            AddFactory(new CG_SWORDSMAN_LEVELUP_PF());
            AddFactory(new CG_BUY_SWORDSMAN_PF());
            AddFactory(new CG_EQUIP_SWORDSMAN_PF());
            AddFactory(new CG_UNEQUIP_SWORDSMAN_PF());
            AddFactory(new CG_FELLOW_RESET_POINT_PF());
            AddFactory(new CG_REQ_POWERUP_PF());
            AddFactory(new CG_REQ_RANDOMNAME_PF());
            AddFactory(new CG_ASK_CURGUILDWARTYPE_PF());
            AddFactory(new CG_SET_DEATH_PUSH_PF());
            AddFactory(new CG_REQ_MARRAGE_PF());
            AddFactory(new CG_ASK_CHALLENGEGUILDWAR_PF());
            AddFactory(new CG_LOCK_SWORDSMAN_PF());
            AddFactory(new CG_UNLOCK_SWORDSMAN_PF());
            AddFactory(new CG_ASK_HUASHANPVP_STATE_PF());
            AddFactory(new CG_SNS_INVITE_CODE_PF());
            AddFactory(new CG_SNS_SHARE_PF());
            AddFactory(new CG_ASK_NEWONLINEAWARD_PF());
            AddFactory(new CG_ASK_GAIN_10_FELLOW_PF());
            AddFactory(new CG_GUILD_INVITE_PF());
            AddFactory(new CG_GUILD_INVITE_CONFIRM_PF());
            AddFactory(new CG_ASK_PAY_ACTIVITY_PRIZE_PF());
            AddFactory(new CG_ASK_LOCK_TITLE_PF());
            AddFactory(new CG_REQUEST_CDKEY_PF());
            AddFactory(new CG_ASK_UPDATE_STORAGEPACK_PF());
            AddFactory(new CG_PUT_ITEM_STORAGEPACK_PF());
            AddFactory(new CG_TAKE_ITEM_STORAGEPACK_PF());
            AddFactory(new CG_STORAGEPACK_UNLOCK_PF());
            AddFactory(new CG_REQ_CHANGENAME_PF());
            AddFactory(new CG_WORLDBOSS_CHALL_RESPONSE_PF());
            AddFactory(new CG_ASK_BLACKMARKETITEMINFO_PF());
            AddFactory(new CG_BUY_BLACKMARKETITEM_PF());
            AddFactory(new CG_REQ_HUASHAN_PKINFO_PF());
            AddFactory(new CG_DELHATELIST_PF());
            AddFactory(new CG_ASK_TRAIL_PF());
            AddFactory(new CG_GUILD_JOIN_OTHERPLAYER_PF());
            AddFactory(new CG_MASTERSHOP_BUY_PF());
            AddFactory(new CG_ASK_ISRECHARGE_ENABLE_PF());
            AddFactory(new CG_ASK_GUILDWILDWAR_PF());
            AddFactory(new CG_ASK_ENEMYGUILDINFO_PF());
            AddFactory(new CG_ASK_NEW7DAYONLINEAWARD_PF());
            AddFactory(new CG_ASK_SPECIALAWARD_PF());
            AddFactory(new CG_ASK_SETAUTOASSIGNPSTIMES_PF());
            AddFactory(new CG_ASSIGN_GUILDBUSINESS_TIME_PF());
            AddFactory(new CG_ASK_GUILDBUSINESSINFO_PF());
            AddFactory(new CG_ASK_GUILDBUSINESS_ACCEPT_PF());
            AddFactory(new CG_ADDPAY_TEST_PF());
            AddFactory(new CG_ASK_GUILDMISSIONINFO_PF());
            AddFactory(new CG_ASSIGN_GUILDMISSION_PF());
            AddFactory(new CG_PARTAKE_GUILDMISSION_PF());
            AddFactory(new CG_ASK_GUILD_MAKE_PF());
            AddFactory(new CG_ASK_TIDY_PF());
            AddFactory(new CG_ASK_NEWPLAYER_CREATE_NPC_PF());
            AddFactory(new CG_GUIDE_STEP_PF());
            AddFactory(new CG_CH_MON_FIGHT_PF());
            AddFactory(new CG_FACEDIR_PLAYER_PF());
            AddFactory(new CG_ASK_LEVELAWARD_PF());
            AddFactory(new CG_JUQINGITEM_PLAYEFFECT_PF());
            AddFactory(new CG_BELLE_CANCELMATRIX_PF());
            AddFactory(new CG_ASK_DAILYAWARD_PF());
            AddFactory(new CG_ASK_7DAYAWARD_PF());
            AddFactory(new CG_PAY_ORDER_PF());
            AddFactory(new CG_ASK_PAY_ACTIVITY_PF());
            AddFactory(new CG_ASK_BINDNUMBER_PF());
            AddFactory(new CG_SEND_FANKUI_PF());
            AddFactory(new CG_ACK_ACTIVE_LEICHONG_PF());
            AddPacketHander(MessageID.PACKET_GC_LOGIN_RET, new GC_LOGIN_RETHandler());
            AddPacketHander(MessageID.PACKET_GC_CONNECTED_HEARTBEAT, new GC_CONNECTED_HEARTBEATHandler());
            //AddPacketHander(MessageID.PACKET_GC_NOTICE, new GC_NOTICEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MISSION_SYNC_MISSIONLIST, new GC_MISSION_SYNC_MISSIONLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_ACCEPTMISSION_RET, new GC_ACCEPTMISSION_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_COMPLETEMISSION_RET, new GC_COMPLETEMISSION_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_ABANDONMISSION_RET, new GC_ABANDONMISSION_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_MISSION_STATE, new GC_MISSION_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MISSION_PARAM, new GC_MISSION_PARAMHandler());
            //AddPacketHander(MessageID.PACKET_GC_ENTER_SCENE, new GC_ENTER_SCENEHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_PLAYER, new GC_CREATE_PLAYERHandler());
            //AddPacketHander(MessageID.PACKET_GC_DELETE_OBJ, new GC_DELETE_OBJHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_POS, new GC_SYNC_POSHandler());
            //AddPacketHander(MessageID.PACKET_GC_MOVE, new GC_MOVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_STOP, new GC_STOPHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYSTEMSHOP_MERCHANDISELIST, new GC_SYSTEMSHOP_MERCHANDISELISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATENOTICEDATA, new GC_UPDATENOTICEDATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATEITEM, new GC_UPDATEITEMHandler());
            //AddPacketHander(MessageID.PACKET_GC_TEAM_LEAVE, new GC_TEAM_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_TEAM_SYNC_TEAMINFO, new GC_TEAM_SYNC_TEAMINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_TEAM_SYNC_MEMBERINFO, new GC_TEAM_SYNC_MEMBERINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_JOIN_TEAM_INVITE, new GC_JOIN_TEAM_INVITEHandler());
            //AddPacketHander(MessageID.PACKET_GC_JOIN_TEAM_REQUEST, new GC_JOIN_TEAM_REQUESTHandler());
            //AddPacketHander(MessageID.PACKET_GC_NEAR_PLAYERLIST, new GC_NEAR_PLAYERLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_NEAR_TEAMLIST, new GC_NEAR_TEAMLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATEROLE_RET, new GC_CREATEROLE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_SELECTROLE_RET, new GC_SELECTROLE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_CDTIME_UPDATE, new GC_CDTIME_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_BROADCAST_ATTR, new GC_BROADCAST_ATTRHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYN_ATTR, new GC_SYN_ATTRHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_DATA, new GC_BELLE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_CLOSE_RET, new GC_BELLE_CLOSE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_EVOLUTION_RET, new GC_BELLE_EVOLUTION_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_EVOLUTIONRAPID_RET, new GC_BELLE_EVOLUTIONRAPID_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_BATTLE_RET, new GC_BELLE_BATTLE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_REST_RET, new GC_BELLE_REST_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_ACTIVEMATRIX_RET, new GC_BELLE_ACTIVEMATRIX_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_ACTIVE, new GC_BELLE_ACTIVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_ALL_TITLEINVESTITIVE, new GC_UPDATE_ALL_TITLEINVESTITIVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_GAIN_TITLE, new GC_GAIN_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_DELETE_TITLE, new GC_DELETE_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_ACTIVE_TITLE, new GC_ACTIVE_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_ACTIVETITLE, new GC_SYNC_ACTIVETITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MOUNTCOLLECTED_FLAG, new GC_MOUNTCOLLECTED_FLAGHandler());
            //AddPacketHander(MessageID.PACKET_GC_MOUNT_DATA, new GC_MOUNT_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_MOUNT_MARK_RET, new GC_MOUNT_MARK_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_EQUIP_ENCHANCE_RET, new GC_EQUIP_ENCHANCE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_EQUIP_STAR_RET, new GC_EQUIP_STAR_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHAT, new GC_CHATHandler());
            //AddPacketHander(MessageID.PACKET_GC_ADDFRIEND, new GC_ADDFRIENDHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_FRIEND_USERINFO, new GC_RET_FRIEND_USERINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_DELFRIEND, new GC_DELFRIENDHandler());
            //AddPacketHander(MessageID.PACKET_GC_NOTICE_ADDED_FRIEND, new GC_NOTICE_ADDED_FRIENDHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYC_FRIEND_STATE, new GC_SYC_FRIEND_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYC_FRIEND_INFO, new GC_SYC_FRIEND_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYC_FULL_FRIEND_LIST, new GC_SYC_FULL_FRIEND_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_ADDBLACKLIST, new GC_ADDBLACKLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYC_FULL_BLACK_LIST, new GC_SYC_FULL_BLACK_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_DELBLACKLIST, new GC_DELBLACKLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_FINDPLAYER, new GC_FINDPLAYERHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNSELTRAGET_ATTR, new GC_SYNSELTRAGET_ATTRHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_NPC, new GC_CREATE_NPCHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAYSTORY, new GC_PLAYSTORYHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_RELIVE, new GC_RET_RELIVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_DROPITEM_INFO, new GC_DROPITEM_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_PICKUP_ITEM, new GC_RET_PICKUP_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_FELLOW, new GC_UPDATE_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_GC_SERVER_SERIOUSERROR, new GC_SERVER_SERIOUSERRORHandler());
            //AddPacketHander(MessageID.PACKET_GC_ADDITIONINFO_UPDATE, new GC_ADDITIONINFO_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_SELOBJ_INFO, new GC_RET_SELOBJ_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_USE_SKILL, new GC_RET_USE_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_FELLOW, new GC_CREATE_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_ROLE_DATA, new GC_RET_ROLE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_CALL_FELLOW_RET, new GC_CALL_FELLOW_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_UNCALL_FELLOW_RET, new GC_UNCALL_FELLOW_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_NEWSERVERAWARD_DATA, new GC_NEWSERVERAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAYAWARD_DATA, new GC_DAYAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_ONLINEAWARD_DATA, new GC_ONLINEAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_ACTIVENESSAWARD_RET, new GC_ASK_ACTIVENESSAWARD_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_ACTIVENESSAWARD, new GC_SYNC_ACTIVENESSAWARDHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAMAGEBOARD_INFO, new GC_DAMAGEBOARD_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_COPYSCENE_INVITE, new GC_COPYSCENE_INVITEHandler());
            //AddPacketHander(MessageID.PACKET_GC_COPYSCENE_RESULT, new GC_COPYSCENE_RESULTHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_COPYSCENE_REWARD, new GC_RET_COPYSCENE_REWARDHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_COPYSCENE_SWEEP, new GC_RET_COPYSCENE_SWEEPHandler());
            //AddPacketHander(MessageID.PACKET_GC_MISSION_IGNOREMISSIONPREFLAG, new GC_MISSION_IGNOREMISSIONPREFLAGHandler());
            //AddPacketHander(MessageID.PACKET_GC_COMBATVALUE_RET, new GC_COMBATVALUE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAY_EFFECT, new GC_PLAY_EFFECTHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_PKINFO, new GC_RET_PKINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_CHANGE_PKMODLE, new GC_RET_CHANGE_PKMODLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHANGE_PKLIST, new GC_CHANGE_PKLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_MAIL_UPDATE, new GC_MAIL_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MAIL_DELETE, new GC_MAIL_DELETEHandler());
            //AddPacketHander(MessageID.PACKET_GC_OP_TELEPORT, new GC_OP_TELEPORTHandler());
            //AddPacketHander(MessageID.PACKET_GC_OP_QINGGONGPOINT, new GC_OP_QINGGONGPOINTHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHALLENGE_MYDATA, new GC_CHALLENGE_MYDATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_OPPONENT_LIST, new GC_OPPONENT_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHALLENGERANKLIST, new GC_CHALLENGERANKLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_ZOMBIEUSER, new GC_CREATE_ZOMBIEUSERHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHALLENGE_REWARD, new GC_CHALLENGE_REWARDHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHALLENGE_HISTORY, new GC_CHALLENGE_HISTORYHandler());
            //AddPacketHander(MessageID.PACKET_GC_UI_OPERATION, new GC_UI_OPERATIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_SCENE_TIMESCALE, new GC_SCENE_TIMESCALEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SKILL_FINISH, new GC_SKILL_FINISHHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_EQUIPREMIND, new GC_SHOW_EQUIPREMINDHandler());
            //AddPacketHander(MessageID.PACKET_GC_UI_NEWPLAYERGUIDE, new GC_UI_NEWPLAYERGUIDEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SKILL_STUDY, new GC_SKILL_STUDYHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAY_MODELSOTRY, new GC_PLAY_MODELSOTRYHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYN_SKILLINFO, new GC_SYN_SKILLINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_SCENE_INSTACTIVATION, new GC_UPDATE_SCENE_INSTACTIVATIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_ANIMATION_STATE, new GC_UPDATE_ANIMATION_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_HITPONIT, new GC_UPDATE_HITPONITHandler());
            //AddPacketHander(MessageID.PACKET_GC_TELEMOVE, new GC_TELEMOVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAYSHANDIANLIANEFFECT, new GC_PLAYSHANDIANLIANEFFECTHandler());
            //AddPacketHander(MessageID.PACKET_GC_REMOVEEFFECT, new GC_REMOVEEFFECTHandler());
            //AddPacketHander(MessageID.PACKET_GC_ATTACKFLY, new GC_ATTACKFLYHandler());
            //AddPacketHander(MessageID.PACKET_GC_COUNTDOWN, new GC_COUNTDOWNHandler());
            //AddPacketHander(MessageID.PACKET_GC_BACKPACK_RESIZE, new GC_BACKPACK_RESIZEHandler());
            //AddPacketHander(MessageID.PACKET_GC_USE_ITEM_RET, new GC_USE_ITEM_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_USERTIP, new GC_USERTIPHandler());
            //AddPacketHander(MessageID.PACKET_GC_MONEYTREE_DATA, new GC_MONEYTREE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_QUIT_GAME, new GC_RET_QUIT_GAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RESOLVE_FELLOW_RET, new GC_RESOLVE_FELLOW_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_REACHEDSCENE, new GC_SYNC_REACHEDSCENEHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_ACTIVE_FELLOWSKILL, new GC_UPDATE_ACTIVE_FELLOWSKILLHandler());
            //AddPacketHander(MessageID.PACKET_GC_EQUIP_FELLOW_SKILL_RET, new GC_EQUIP_FELLOW_SKILL_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_UNEQUIP_FELLOW_SKILL_RET, new GC_UNEQUIP_FELLOW_SKILL_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_LEVELUP_FELLOW_SKILL_RET, new GC_LEVELUP_FELLOW_SKILL_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_FORCE_SETPOS, new GC_FORCE_SETPOSHandler());
            //AddPacketHander(MessageID.PACKET_GC_DEBUG_MY_POS, new GC_DEBUG_MY_POSHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAY_SOUNDS, new GC_PLAY_SOUNDSHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAILYMISSION_UPDATE_RET, new GC_DAILYMISSION_UPDATE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_LOUDSPEAKER_CONTENT, new GC_ASK_LOUDSPEAKER_CONTENTHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_GAIN_FELLOW_RET, new GC_ASK_GAIN_FELLOW_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_GAIN_FELLOW_COUNT, new GC_UPDATE_GAIN_FELLOW_COUNTHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_MEMBERLIST, new GC_HUASHAN_PVP_MEMBERLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_STATE, new GC_HUASHAN_PVP_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_SELFPOSITION, new GC_HUASHAN_PVP_SELFPOSITIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_SHOWSEARCH, new GC_HUASHAN_PVP_SHOWSEARCHHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_OPPONENTVIEW, new GC_HUASHAN_PVP_OPPONENTVIEWHandler());
            //AddPacketHander(MessageID.PACKET_GC_HUASHAN_PVP_ASSIST_STATE, new GC_HUASHAN_PVP_ASSIST_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_DUEL_REQUESTU, new GC_DUEL_REQUESTUHandler());
            //AddPacketHander(MessageID.PACKET_GC_DUEL_STATE, new GC_DUEL_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MERCENARY_LIST_RES, new GC_MERCENARY_LIST_RESHandler());
            //AddPacketHander(MessageID.PACKET_GC_MERCENARY_LEFTTIMES, new GC_MERCENARY_LEFTTIMESHandler());
            //AddPacketHander(MessageID.PACKET_GC_MERCENARY_EMPLOYLIST, new GC_MERCENARY_EMPLOYLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_WORLDBOSS_DEAD, new GC_WORLDBOSS_DEADHandler());
            //AddPacketHander(MessageID.PACKET_GC_WORLDBOSS_TEAMLIST, new GC_WORLDBOSS_TEAMLISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_WORLDBOSS_OPEN, new GC_WORLDBOSS_OPENHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_MYCONSIGNSALEITEM, new GC_RET_MYCONSIGNSALEITEMHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_CONSIGNSALEITEMINFO, new GC_RET_CONSIGNSALEITEMINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_COMMONDATA, new GC_SYNC_COMMONDATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_COMMONFLAG, new GC_SYNC_COMMONFLAGHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_COMMONFLAG_RET, new GC_ASK_COMMONFLAG_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAILYLUCKYDRAW_GAINBONUS, new GC_DAILYLUCKYDRAW_GAINBONUSHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAILYLUCKYDRAW_UPDATE, new GC_DAILYLUCKYDRAW_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAILYLUCKYDRAW_FAIL, new GC_DAILYLUCKYDRAW_FAILHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_GEM_INFO, new GC_UPDATE_GEM_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_PUT_GEM_RET, new GC_PUT_GEM_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_TAKE_GEM_RET, new GC_TAKE_GEM_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_ACTIVENESS, new GC_SYNC_ACTIVENESSHandler());
            //AddPacketHander(MessageID.PACKET_GC_SEND_FASHIONINFO, new GC_SEND_FASHIONINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_FASHION, new GC_SYNC_FASHIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_SEND_CURFASHION, new GC_SEND_CURFASHIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_TEAMPLATFORMINFO, new GC_RET_TEAMPLATFORMINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_AUTOTEAM, new GC_RET_AUTOTEAMHandler());
            //AddPacketHander(MessageID.PACKET_GC_FELLOW_STAR_RET, new GC_FELLOW_STAR_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_FELLOW_ENCHANCE_RET, new GC_FELLOW_ENCHANCE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_FELLOW_APPLY_POINT_RET, new GC_FELLOW_APPLY_POINT_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_RET_LIST, new GC_GUILD_RET_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_RET_INFO, new GC_GUILD_RET_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_CREATE, new GC_GUILD_CREATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_JOIN, new GC_GUILD_JOINHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_LEAVE, new GC_GUILD_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_RET_LEVELUP, new GC_GUILD_RET_LEVELUPHandler());
            //AddPacketHander(MessageID.PACKET_GC_DYNAMICOBSTACLE_OPT, new GC_DYNAMICOBSTACLE_OPTHandler());
            //AddPacketHander(MessageID.PACKET_GC_FELLOW_CHANGE_NAME_RET, new GC_FELLOW_CHANGE_NAME_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_NEEDIMPACTINFO, new GC_UPDATE_NEEDIMPACTINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_RET_LIST, new GC_MASTER_RET_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_RET_INFO, new GC_MASTER_RET_INFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_CREATE, new GC_MASTER_CREATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_JOIN, new GC_MASTER_JOINHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_LEAVE, new GC_MASTER_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_KICK, new GC_MASTER_KICKHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_APPROVE_RESERVE, new GC_MASTER_APPROVE_RESERVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_LEARN_SKILL, new GC_MASTER_LEARN_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_FORGET_SKILL, new GC_MASTER_FORGET_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTER_ACTIVE_SKILL, new GC_MASTER_ACTIVE_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_RANK, new GC_RET_RANKHandler());
            //AddPacketHander(MessageID.PACKET_GC_RESTAURANT_UPDATE, new GC_RESTAURANT_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RESTAURANT_DESTUPDATE, new GC_RESTAURANT_DESTUPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RESTAURANT_LEVELUPDATE, new GC_RESTAURANT_LEVELUPDATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_COPYSCENENUMBER, new GC_SYNC_COPYSCENENUMBERHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHANGE_SHOWFASHION, new GC_CHANGE_SHOWFASHIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_SNARE, new GC_CREATE_SNAREHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_PRELIMINARY_WARINFO, new GC_RET_PRELIMINARY_WARINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYN_TORCH_VALUE, new GC_SYN_TORCH_VALUEHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_STARTGUILDWAR, new GC_ASK_STARTGUILDWARHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_PRELIMINARY_WARRET, new GC_SHOW_PRELIMINARY_WARRETHandler());
            //AddPacketHander(MessageID.PACKET_GC_QIANKUNDAI_PRODUCT, new GC_QIANKUNDAI_PRODUCTHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_FINALGUILDWARGROUPINFO, new GC_RET_FINALGUILDWARGROUPINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_FINALGUILDWARPOINTINFO, new GC_RET_FINALGUILDWARPOINTINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_STAMINA_TIME, new GC_UPDATE_STAMINA_TIMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_LOGIN_QUEUE_STATUS, new GC_LOGIN_QUEUE_STATUSHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_YUANBAOSHOP_OPEN, new GC_RET_YUANBAOSHOP_OPENHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_BLACKMARKET, new GC_SHOW_BLACKMARKETHandler());
            //AddPacketHander(MessageID.PACKET_GC_OPENFUNCTION, new GC_OPENFUNCTIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_OTHERROLE_DATA, new GC_RET_OTHERROLE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_ITEMREMIND, new GC_SHOW_ITEMREMINDHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_PUT_GEM, new GC_RET_PUT_GEMHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_SWORDSMAN, new GC_UPDATE_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_SWORDSMAN_VISITSTATE, new GC_UPDATE_SWORDSMAN_VISITSTATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_ACTIVITYNOTICE, new GC_ACTIVITYNOTICEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_FELLOW_RESET_POINT, new GC_RET_FELLOW_RESET_POINTHandler());
            //AddPacketHander(MessageID.PACKET_GC_RES_POWERUP, new GC_RES_POWERUPHandler());
            //AddPacketHander(MessageID.PACKET_GC_POWERUP_LIST, new GC_POWERUP_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_BUY_GUILDGOODS, new GC_BUY_GUILDGOODSHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_AWARDTABLE, new GC_SYNC_AWARDTABLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_RANDOMNAME, new GC_RET_RANDOMNAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_NEWRESERVE, new GC_GUILD_NEWRESERVEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_SKILLNAME, new GC_SHOW_SKILLNAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_CURGUILDWARTYPE, new GC_RET_CURGUILDWARTYPEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SWORDSMANPACK_RESIZE, new GC_SWORDSMANPACK_RESIZEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_VISIT_SWORDSMAN, new GC_RET_VISIT_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_LEVELUP_SWORDSMAN, new GC_RET_LEVELUP_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_MARRAGE, new GC_RET_MARRAGEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYN_LOVERINFO, new GC_SYN_LOVERINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SNS_INVITE_CODE_RESPONSE, new GC_SNS_INVITE_CODE_RESPONSEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SNS_ACTIVE_SHOW, new GC_SNS_ACTIVE_SHOWHandler());
            //AddPacketHander(MessageID.PACKET_GC_PUSH_NOTIFICATION, new GC_PUSH_NOTIFICATIONHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOW_USEITEMREMIND, new GC_SHOW_USEITEMREMINDHandler());
            //AddPacketHander(MessageID.PACKET_GC_NEWONLINEAWARD_DATA, new GC_NEWONLINEAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_NEWONLINEAWARDTABLE, new GC_SYNC_NEWONLINEAWARDTABLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_GAIN_10_FELLOW_RET, new GC_ASK_GAIN_10_FELLOW_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILD_INVITE_CONFIRM, new GC_GUILD_INVITE_CONFIRMHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_PAY_ACTIVITY_DATA, new GC_SYNC_PAY_ACTIVITY_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_PAY_ACTIVITY_PRIZE_RET, new GC_ASK_PAY_ACTIVITY_PRIZE_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_LOCK_TITLE, new GC_RET_LOCK_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_STORAGEPACK, new GC_UPDATE_STORAGEPACKHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_UPDATE_STORAGEPACK_RET, new GC_ASK_UPDATE_STORAGEPACK_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_PUT_ITEM_STORAGEPACK_RET, new GC_PUT_ITEM_STORAGEPACK_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_TAKE_ITEM_STORAGEPACK_RET, new GC_TAKE_ITEM_STORAGEPACK_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_CHANGENAME, new GC_RET_CHANGENAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_WORLDBOSS_SOMECHALL_ME, new GC_WORLDBOSS_SOMECHALL_MEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_MASTER_SKILL_NAME, new GC_SYNC_MASTER_SKILL_NAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_COPYSCENEEXTRANUMBER, new GC_SYNC_COPYSCENEEXTRANUMBERHandler());
            //AddPacketHander(MessageID.PACKET_GC_CHANGENAME, new GC_CHANGENAMEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_BLACKMARKETITEMINFO, new GC_RET_BLACKMARKETITEMINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_CLOSE_BLACKMARKET, new GC_CLOSE_BLACKMARKETHandler());
            //AddPacketHander(MessageID.PACKET_GC_WORLDBOSS_CHALLEGE_RES, new GC_WORLDBOSS_CHALLEGE_RESHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_HUASHAN_PKINFO, new GC_RET_HUASHAN_PKINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_PLAY_YANHUA, new GC_PLAY_YANHUAHandler());
            //AddPacketHander(MessageID.PACKET_GC_CREATE_YANHUA, new GC_CREATE_YANHUAHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYC_FULL_HATE_LIST, new GC_SYC_FULL_HATE_LISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_DELHATELIST, new GC_DELHATELISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_TRAIL, new GC_RET_TRAILHandler());
            //AddPacketHander(MessageID.PACKET_GC_ADDHATELIST, new GC_ADDHATELISTHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_DEF_TITLE, new GC_UPDATE_DEF_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SERVER_CONFIG, new GC_SERVER_CONFIGHandler());
            //AddPacketHander(MessageID.PACKET_GC_OPEN_SHAREWINDOW, new GC_OPEN_SHAREWINDOWHandler());
            //AddPacketHander(MessageID.PACKET_GC_MASTERSHOP_BUY, new GC_MASTERSHOP_BUYHandler());
            //AddPacketHander(MessageID.PACKET_GC_UPDATE_RECHARGESTATE, new GC_UPDATE_RECHARGESTATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_ENEMYGUILDINFO, new GC_RET_ENEMYGUILDINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_ISWILDENEMY2USER, new GC_RET_ISWILDENEMY2USERHandler());
            //AddPacketHander(MessageID.PACKET_GC_RESTAURANT_VISITFRIENDINFO, new GC_RESTAURANT_VISITFRIENDINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SHOWPKNOTICE, new GC_SHOWPKNOTICEHandler());
            //AddPacketHander(MessageID.PACKET_GC_GUILDACTIVITY_BOSSDATA, new GC_GUILDACTIVITY_BOSSDATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_NEW7DAYONLINEAWARD_DATA, new GC_NEW7DAYONLINEAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_NEW7DAYONLINEAWARDTABLE, new GC_SYNC_NEW7DAYONLINEAWARDTABLEHandler());
            //AddPacketHander(MessageID.PACKET_GC_SERVERFLAGS, new GC_SERVERFLAGSHandler());
            //AddPacketHander(MessageID.PACKET_GC_TODAY_FIRST_LOGIN, new GC_TODAY_FIRST_LOGINHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_GUILDBUSINESSINFO, new GC_RET_GUILDBUSINESSINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_PLAYER_STATE, new GC_SYNC_PLAYER_STATEHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_GUILDMISSIONINFO, new GC_RET_GUILDMISSIONINFOHandler());
            //AddPacketHander(MessageID.PACKET_GC_SYNC_PLAYERFACEDIR, new GC_SYNC_PLAYERFACEDIRHandler());
            //AddPacketHander(MessageID.PACKET_GC_DO_CLIENT_SCRIPT, new GC_DO_CLIENT_SCRIPTHandler());
            //AddPacketHander(MessageID.PACKET_GC_LEVELAWARD_DATA, new GC_LEVELAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_JUQINGITEM_PLAYEFFECT, new GC_RET_JUQINGITEM_PLAYEFFECTHandler());
            //AddPacketHander(MessageID.PACKET_GC_BELLE_CANCELMATRIX_RET, new GC_BELLE_CANCELMATRIX_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_DAILYAWARD_DATA, new GC_DAILYAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_ADDPAY_TEST, new GC_ADDPAY_TESTHandler());
            //AddPacketHander(MessageID.PACKET_GC_7DAYAWARD_DATA, new GC_7DAYAWARD_DATAHandler());
            //AddPacketHander(MessageID.PACKET_GC_PAY_ORDER, new GC_PAY_ORDERHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_PAY_ACTIVITY_RET, new GC_ASK_PAY_ACTIVITY_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_ASK_BINDNUMBER_RET, new GC_ASK_BINDNUMBER_RETHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_FANKUI, new GC_RET_FANKUIHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_ACTIVE_YUEKA, new GC_RET_ACTIVE_YUEKAHandler());
            //AddPacketHander(MessageID.PACKET_GC_RET_ACTIVE_LEICHONG, new GC_RET_ACTIVE_LEICHONGHandler());
            //AddPacketHander(MessageID.PACKET_CG_LOGIN, new CG_LOGINHandler());
            //AddPacketHander(MessageID.PACKET_CG_CONNECTED_HEARTBEAT, new CG_CONNECTED_HEARTBEATHandler());
            //AddPacketHander(MessageID.PACKET_CG_ACCEPTMISSION, new CG_ACCEPTMISSIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_COMPLETEMISSION, new CG_COMPLETEMISSIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_ABANDONMISSION, new CG_ABANDONMISSIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_CHANGE_SCENE, new CG_REQ_CHANGE_SCENEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ENTER_SCENE_OK, new CG_ENTER_SCENE_OKHandler());
            //AddPacketHander(MessageID.PACKET_CG_SYNC_POS, new CG_SYNC_POSHandler());
            //AddPacketHander(MessageID.PACKET_CG_MOVE, new CG_MOVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SYSTEMSHOP_VIEW, new CG_SYSTEMSHOP_VIEWHandler());
            //AddPacketHander(MessageID.PACKET_CG_SYSTEMSHOP_BUY, new CG_SYSTEMSHOP_BUYHandler());
            //AddPacketHander(MessageID.PACKET_CG_SYSTEMSHOP_BUYBACK, new CG_SYSTEMSHOP_BUYBACKHandler());
            //AddPacketHander(MessageID.PACKET_CG_SYSTEMSHOP_SELL, new CG_SYSTEMSHOP_SELLHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_TEAM_INVITE, new CG_REQ_TEAM_INVITEHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_TEAM_JOIN, new CG_REQ_TEAM_JOINHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_TEAM_LEAVE, new CG_REQ_TEAM_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_TEAM_KICK_MEMBER, new CG_REQ_TEAM_KICK_MEMBERHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_TEAM_CHANGE_LEADER, new CG_REQ_TEAM_CHANGE_LEADERHandler());
            //AddPacketHander(MessageID.PACKET_CG_JOIN_TEAM_INVITE_RESULT, new CG_JOIN_TEAM_INVITE_RESULTHandler());
            //AddPacketHander(MessageID.PACKET_CG_JOIN_TEAM_REQUEST_RESULT, new CG_JOIN_TEAM_REQUEST_RESULTHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_NEAR_LIST, new CG_REQ_NEAR_LISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_USE_ITEM, new CG_USE_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_EQUIP_ITEM, new CG_EQUIP_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNEQUIP_ITEM, new CG_UNEQUIP_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_CREATEROLE, new CG_CREATEROLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SELECTROLE, new CG_SELECTROLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SKILL_USE, new CG_SKILL_USEHandler());
            //AddPacketHander(MessageID.PACKET_CG_THROW_ITEM, new CG_THROW_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_CLOSE, new CG_BELLE_CLOSEHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_EVOLUTION, new CG_BELLE_EVOLUTIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_EVOLUTIONRAPID, new CG_BELLE_EVOLUTIONRAPIDHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_BATTLE, new CG_BELLE_BATTLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_REST, new CG_BELLE_RESTHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_ACTIVEMATRIX, new CG_BELLE_ACTIVEMATRIXHandler());
            //AddPacketHander(MessageID.PACKET_CG_ACTIVE_TITLE, new CG_ACTIVE_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_DELETE_TITLE, new CG_DELETE_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MOUNT_MARK, new CG_MOUNT_MARKHandler());
            //AddPacketHander(MessageID.PACKET_CG_MOUNT_MOUNT, new CG_MOUNT_MOUNTHandler());
            //AddPacketHander(MessageID.PACKET_CG_MOUNT_UNMOUNT, new CG_MOUNT_UNMOUNTHandler());
            //AddPacketHander(MessageID.PACKET_CG_EQUIP_ENCHANCE, new CG_EQUIP_ENCHANCEHandler());
            //AddPacketHander(MessageID.PACKET_CG_EQUIP_STAR, new CG_EQUIP_STARHandler());
            //AddPacketHander(MessageID.PACKET_CG_CHAT, new CG_CHATHandler());
            //AddPacketHander(MessageID.PACKET_CG_ADDFRIEND, new CG_ADDFRIENDHandler());
            //AddPacketHander(MessageID.PACKET_CG_DELFRIEND, new CG_DELFRIENDHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_FRIEND_USERINFO, new CG_REQ_FRIEND_USERINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ADDBLACKLIST, new CG_ADDBLACKLISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_DELBLACKLIST, new CG_DELBLACKLISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_FINDPLAYER, new CG_FINDPLAYERHandler());
            //AddPacketHander(MessageID.PACKET_CG_GMCOMMAND, new CG_GMCOMMANDHandler());
            //AddPacketHander(MessageID.PACKET_CG_PLAYSTORY_OVER, new CG_PLAYSTORY_OVERHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_RELIVE, new CG_ASK_RELIVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_PICKUP_ITEM, new CG_ASK_PICKUP_ITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_SELOBJ_INFO, new CG_ASK_SELOBJ_INFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_ROLE_DATA, new CG_ASK_ROLE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_CG_CALL_FELLOW, new CG_CALL_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNCALL_FELLOW, new CG_UNCALL_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_NEWSERVERAWARD, new CG_ASK_NEWSERVERAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_DAYAWARD, new CG_ASK_DAYAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_ONLINEAWARD, new CG_ASK_ONLINEAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_ACTIVENESSAWARD, new CG_ASK_ACTIVENESSAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_OPEN_COPYSCENE, new CG_OPEN_COPYSCENEHandler());
            //AddPacketHander(MessageID.PACKET_CG_COPYSCENE_INVITE_RET, new CG_COPYSCENE_INVITE_RETHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_COPYSCENE_REWARD, new CG_ASK_COPYSCENE_REWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_COPYSCENE_SWEEP, new CG_ASK_COPYSCENE_SWEEPHandler());
            //AddPacketHander(MessageID.PACKET_CG_COMBATVALUE_ASK, new CG_COMBATVALUE_ASKHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_PKINFO, new CG_ASK_PKINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_CHANGE_PKMODLE, new CG_CHANGE_PKMODLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MAIL_SEND, new CG_MAIL_SENDHandler());
            //AddPacketHander(MessageID.PACKET_CG_MAIL_OPERATION, new CG_MAIL_OPERATIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_SEND_GUILDMAIL, new CG_SEND_GUILDMAILHandler());
            //AddPacketHander(MessageID.PACKET_CG_RANDOM_OPPONENT, new CG_RANDOM_OPPONENTHandler());
            //AddPacketHander(MessageID.PACKET_CG_CHALLENGERANKLIST_REQ, new CG_CHALLENGERANKLIST_REQHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_CHALLENGE, new CG_REQ_CHALLENGEHandler());
            //AddPacketHander(MessageID.PACKET_CG_LEAVE_COPYSCENE, new CG_LEAVE_COPYSCENEHandler());
            //AddPacketHander(MessageID.PACKET_CG_USER_BEHAVIOR, new CG_USER_BEHAVIORHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_LEVELUPSKILL, new CG_ASK_LEVELUPSKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_BACKPACK_UNLOCK, new CG_BACKPACK_UNLOCKHandler());
            //AddPacketHander(MessageID.PACKET_CG_MONEYTREE_ASKAWARD, new CG_MONEYTREE_ASKAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_CHANGE_MAJORCITY, new CG_CHANGE_MAJORCITYHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_QUIT_GAME, new CG_ASK_QUIT_GAMEHandler());
            //AddPacketHander(MessageID.PACKET_CG_LOCK_FELLOW, new CG_LOCK_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNLOCK_FELLOW, new CG_UNLOCK_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESOLVE_FELLOW, new CG_RESOLVE_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_EQUIP_FELLOW_SKILL, new CG_EQUIP_FELLOW_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNEQUIP_FELLOW_SKILL, new CG_UNEQUIP_FELLOW_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_LEVELUP_FELLOW_SKILL, new CG_LEVELUP_FELLOW_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_DAILYMISSION_UPDATE, new CG_DAILYMISSION_UPDATEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_LOUDSPEAKER_POOL, new CG_ASK_LOUDSPEAKER_POOLHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GAIN_FELLOW, new CG_ASK_GAIN_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_HUASHAN_PVP_REGISTER, new CG_HUASHAN_PVP_REGISTERHandler());
            //AddPacketHander(MessageID.PACKET_CG_HUASHAN_PVP_MEMBERLIST, new CG_HUASHAN_PVP_MEMBERLISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_HUASHAN_ASSIST_REQ, new CG_HUASHAN_ASSIST_REQHandler());
            //AddPacketHander(MessageID.PACKET_CG_DUEL_REQUEST, new CG_DUEL_REQUESTHandler());
            //AddPacketHander(MessageID.PACKET_CG_DUEL_RESPONSE, new CG_DUEL_RESPONSEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MERCENARY_LIST_REQ, new CG_MERCENARY_LIST_REQHandler());
            //AddPacketHander(MessageID.PACKET_CG_MERCENARY_REQ, new CG_MERCENARY_REQHandler());
            //AddPacketHander(MessageID.PACKET_CG_WORLDBOSS_TEAMLIST_REQ, new CG_WORLDBOSS_TEAMLIST_REQHandler());
            //AddPacketHander(MessageID.PACKET_CG_WORLDBOSS_CHALLENGE, new CG_WORLDBOSS_CHALLENGEHandler());
            //AddPacketHander(MessageID.PACKET_CG_WORLDBOSS_JOIN, new CG_WORLDBOSS_JOINHandler());
            //AddPacketHander(MessageID.PACKET_CG_CONSIGNSALEITEM, new CG_CONSIGNSALEITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_CANCELCONSIGNSALEITEM, new CG_CANCELCONSIGNSALEITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_MYCONSIGNSALEITEM, new CG_ASK_MYCONSIGNSALEITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_CONSIGNSALEITEMINFO, new CG_ASK_CONSIGNSALEITEMINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_CONSIGNSALEITEMINFO, new CG_BUY_CONSIGNSALEITEMINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_SETCOMMONFLAG, new CG_ASK_SETCOMMONFLAGHandler());
            //AddPacketHander(MessageID.PACKET_CG_DAILYLUCKYDRAW_DRAW, new CG_DAILYLUCKYDRAW_DRAWHandler());
            //AddPacketHander(MessageID.PACKET_CG_PUT_GEM, new CG_PUT_GEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_TAKE_GEM, new CG_TAKE_GEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_FASHION, new CG_BUY_FASHIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_WEAR_FASHION, new CG_WEAR_FASHIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_TAKEOFF_FASHION, new CG_TAKEOFF_FASHIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_TEAMPLATFORMINFO, new CG_ASK_TEAMPLATFORMINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_AUTOTEAM, new CG_ASK_AUTOTEAMHandler());
            //AddPacketHander(MessageID.PACKET_CG_FELLOW_STAR, new CG_FELLOW_STARHandler());
            //AddPacketHander(MessageID.PACKET_CG_FELLOW_ENCHANCE, new CG_FELLOW_ENCHANCEHandler());
            //AddPacketHander(MessageID.PACKET_CG_FELLOW_APPLY_POINT, new CG_FELLOW_APPLY_POINTHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_REQ_LIST, new CG_GUILD_REQ_LISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_REQ_INFO, new CG_GUILD_REQ_INFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_REQ_CHANGE_NOTICE, new CG_GUILD_REQ_CHANGE_NOTICEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_CREATE, new CG_GUILD_CREATEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_JOIN, new CG_GUILD_JOINHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_LEAVE, new CG_GUILD_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_KICK, new CG_GUILD_KICKHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_JOB_CHANGE, new CG_GUILD_JOB_CHANGEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_APPROVE_RESERVE, new CG_GUILD_APPROVE_RESERVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_REQ_LEVELUP, new CG_GUILD_REQ_LEVELUPHandler());
            //AddPacketHander(MessageID.PACKET_CG_FELLOW_CHANGE_NAME, new CG_FELLOW_CHANGE_NAMEHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_YUANBAOGOODS, new CG_BUY_YUANBAOGOODSHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_GUILDGOODS, new CG_BUY_GUILDGOODSHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_REQ_LIST, new CG_MASTER_REQ_LISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_REQ_INFO, new CG_MASTER_REQ_INFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_REQ_CHANGE_NOTICE, new CG_MASTER_REQ_CHANGE_NOTICEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_CREATE, new CG_MASTER_CREATEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_JOIN, new CG_MASTER_JOINHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_LEAVE, new CG_MASTER_LEAVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_KICK, new CG_MASTER_KICKHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_APPROVE_RESERVE, new CG_MASTER_APPROVE_RESERVEHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_ACTIVE_SKILL, new CG_MASTER_ACTIVE_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_FORGET_SKILL, new CG_MASTER_FORGET_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTER_LEARN_SKILL, new CG_MASTER_LEARN_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_RANK, new CG_ASK_RANKHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESTAURANT_PREPAREFOOD, new CG_RESTAURANT_PREPAREFOODHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESTAURANT_BILLINGALL, new CG_RESTAURANT_BILLINGALLHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESTAURANT_FINISHPREPARE, new CG_RESTAURANT_FINISHPREPAREHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESTAURANT_ACTIVEDESK, new CG_RESTAURANT_ACTIVEDESKHandler());
            //AddPacketHander(MessageID.PACKET_CG_RESTAURANT_VISITFRIEND, new CG_RESTAURANT_VISITFRIENDHandler());
            //AddPacketHander(MessageID.PACKET_CG_SCENE_CHANGEINST, new CG_SCENE_CHANGEINSTHandler());
            //AddPacketHander(MessageID.PACKET_CG_COPYSCENERESET, new CG_COPYSCENERESETHandler());
            //AddPacketHander(MessageID.PACKET_CG_CHANGE_SHOWFASHION, new CG_CHANGE_SHOWFASHIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_USE_LIVINGSKILL, new CG_USE_LIVINGSKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_PRELIMINARY_APPLYGUILDWAR, new CG_PRELIMINARY_APPLYGUILDWARHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_PRELIMINARY_WARINFO, new CG_ASK_PRELIMINARY_WARINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_TORCH_VALUE, new CG_ASK_TORCH_VALUEHandler());
            //AddPacketHander(MessageID.PACKET_CG_RET_STARTWAR, new CG_RET_STARTWARHandler());
            //AddPacketHander(MessageID.PACKET_CG_QIANKUNDAI_COMBINE, new CG_QIANKUNDAI_COMBINEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ACTIVE_FELLOW_SKILL, new CG_ACTIVE_FELLOW_SKILLHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_STAMINA, new CG_BUY_STAMINAHandler());
            //AddPacketHander(MessageID.PACKET_CG_FIGHTGUILDWARPOINT, new CG_FIGHTGUILDWARPOINTHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_FINALGUILDWARGROUPINFO, new CG_ASK_FINALGUILDWARGROUPINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_FINALGUILDWARPOINTINFO, new CG_ASK_FINALGUILDWARPOINTINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_YUANBAOSHOP_OPEN, new CG_ASK_YUANBAOSHOP_OPENHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_OTHERROLE_DATA, new CG_ASK_OTHERROLE_DATAHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_HIDE_FELLOW, new CG_ASK_HIDE_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_SHOW_FELLOW, new CG_ASK_SHOW_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_CYPAY_SUCCESS, new CG_CYPAY_SUCCESSHandler());
            //AddPacketHander(MessageID.PACKET_CG_VISIT_SWORDSMAN, new CG_VISIT_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_SWORDSMAN_LEVELUP, new CG_SWORDSMAN_LEVELUPHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_SWORDSMAN, new CG_BUY_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_EQUIP_SWORDSMAN, new CG_EQUIP_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNEQUIP_SWORDSMAN, new CG_UNEQUIP_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_FELLOW_RESET_POINT, new CG_FELLOW_RESET_POINTHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_POWERUP, new CG_REQ_POWERUPHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_RANDOMNAME, new CG_REQ_RANDOMNAMEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_CURGUILDWARTYPE, new CG_ASK_CURGUILDWARTYPEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SET_DEATH_PUSH, new CG_SET_DEATH_PUSHHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_MARRAGE, new CG_REQ_MARRAGEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_CHALLENGEGUILDWAR, new CG_ASK_CHALLENGEGUILDWARHandler());
            //AddPacketHander(MessageID.PACKET_CG_LOCK_SWORDSMAN, new CG_LOCK_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_UNLOCK_SWORDSMAN, new CG_UNLOCK_SWORDSMANHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_HUASHANPVP_STATE, new CG_ASK_HUASHANPVP_STATEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SNS_INVITE_CODE, new CG_SNS_INVITE_CODEHandler());
            //AddPacketHander(MessageID.PACKET_CG_SNS_SHARE, new CG_SNS_SHAREHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_NEWONLINEAWARD, new CG_ASK_NEWONLINEAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GAIN_10_FELLOW, new CG_ASK_GAIN_10_FELLOWHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_INVITE, new CG_GUILD_INVITEHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_INVITE_CONFIRM, new CG_GUILD_INVITE_CONFIRMHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_PAY_ACTIVITY_PRIZE, new CG_ASK_PAY_ACTIVITY_PRIZEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_LOCK_TITLE, new CG_ASK_LOCK_TITLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQUEST_CDKEY, new CG_REQUEST_CDKEYHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_UPDATE_STORAGEPACK, new CG_ASK_UPDATE_STORAGEPACKHandler());
            //AddPacketHander(MessageID.PACKET_CG_PUT_ITEM_STORAGEPACK, new CG_PUT_ITEM_STORAGEPACKHandler());
            //AddPacketHander(MessageID.PACKET_CG_TAKE_ITEM_STORAGEPACK, new CG_TAKE_ITEM_STORAGEPACKHandler());
            //AddPacketHander(MessageID.PACKET_CG_STORAGEPACK_UNLOCK, new CG_STORAGEPACK_UNLOCKHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_CHANGENAME, new CG_REQ_CHANGENAMEHandler());
            //AddPacketHander(MessageID.PACKET_CG_WORLDBOSS_CHALL_RESPONSE, new CG_WORLDBOSS_CHALL_RESPONSEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_BLACKMARKETITEMINFO, new CG_ASK_BLACKMARKETITEMINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_BUY_BLACKMARKETITEM, new CG_BUY_BLACKMARKETITEMHandler());
            //AddPacketHander(MessageID.PACKET_CG_REQ_HUASHAN_PKINFO, new CG_REQ_HUASHAN_PKINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_DELHATELIST, new CG_DELHATELISTHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_TRAIL, new CG_ASK_TRAILHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUILD_JOIN_OTHERPLAYER, new CG_GUILD_JOIN_OTHERPLAYERHandler());
            //AddPacketHander(MessageID.PACKET_CG_MASTERSHOP_BUY, new CG_MASTERSHOP_BUYHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_ISRECHARGE_ENABLE, new CG_ASK_ISRECHARGE_ENABLEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GUILDWILDWAR, new CG_ASK_GUILDWILDWARHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_ENEMYGUILDINFO, new CG_ASK_ENEMYGUILDINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_NEW7DAYONLINEAWARD, new CG_ASK_NEW7DAYONLINEAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_SPECIALAWARD, new CG_ASK_SPECIALAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_SETAUTOASSIGNPSTIMES, new CG_ASK_SETAUTOASSIGNPSTIMESHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASSIGN_GUILDBUSINESS_TIME, new CG_ASSIGN_GUILDBUSINESS_TIMEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GUILDBUSINESSINFO, new CG_ASK_GUILDBUSINESSINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GUILDBUSINESS_ACCEPT, new CG_ASK_GUILDBUSINESS_ACCEPTHandler());
            //AddPacketHander(MessageID.PACKET_CG_ADDPAY_TEST, new CG_ADDPAY_TESTHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GUILDMISSIONINFO, new CG_ASK_GUILDMISSIONINFOHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASSIGN_GUILDMISSION, new CG_ASSIGN_GUILDMISSIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_PARTAKE_GUILDMISSION, new CG_PARTAKE_GUILDMISSIONHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_GUILD_MAKE, new CG_ASK_GUILD_MAKEHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_TIDY, new CG_ASK_TIDYHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_NEWPLAYER_CREATE_NPC, new CG_ASK_NEWPLAYER_CREATE_NPCHandler());
            //AddPacketHander(MessageID.PACKET_CG_GUIDE_STEP, new CG_GUIDE_STEPHandler());
            //AddPacketHander(MessageID.PACKET_CG_CH_MON_FIGHT, new CG_CH_MON_FIGHTHandler());
            //AddPacketHander(MessageID.PACKET_CG_FACEDIR_PLAYER, new CG_FACEDIR_PLAYERHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_LEVELAWARD, new CG_ASK_LEVELAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_JUQINGITEM_PLAYEFFECT, new CG_JUQINGITEM_PLAYEFFECTHandler());
            //AddPacketHander(MessageID.PACKET_CG_BELLE_CANCELMATRIX, new CG_BELLE_CANCELMATRIXHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_DAILYAWARD, new CG_ASK_DAILYAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_7DAYAWARD, new CG_ASK_7DAYAWARDHandler());
            //AddPacketHander(MessageID.PACKET_CG_PAY_ORDER, new CG_PAY_ORDERHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_PAY_ACTIVITY, new CG_ASK_PAY_ACTIVITYHandler());
            //AddPacketHander(MessageID.PACKET_CG_ASK_BINDNUMBER, new CG_ASK_BINDNUMBERHandler());
            //AddPacketHander(MessageID.PACKET_CG_SEND_FANKUI, new CG_SEND_FANKUIHandler());
            //AddPacketHander(MessageID.PACKET_CG_ACK_ACTIVE_LEICHONG, new CG_ACK_ACTIVE_LEICHONGHandler());
            return true;
        }
    }




    public class GC_7DAYAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_7DAYAWARD_DATA;
        }
    }
    public class GC_ABANDONMISSION_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ABANDONMISSION_RET;
        }
    }
    public class GC_ACCEPTMISSION_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ACCEPTMISSION_RET;
        }
    }
    public class GC_ACTIVE_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ACTIVE_TITLE;
        }
    }
    public class GC_ACTIVITYNOTICE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ACTIVITYNOTICE;
        }
    }
    public class GC_ADDBLACKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ADDBLACKLIST;
        }
    }
    public class GC_ADDFRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ADDFRIEND;
        }
    }
    public class GC_ADDHATELIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ADDHATELIST;
        }
    }
    public class GC_ADDITIONINFO_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ADDITIONINFO_UPDATE;
        }
    }
    public class GC_ADDPAY_TEST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ADDPAY_TEST;
        }
    }
    public class GC_ASK_ACTIVENESSAWARD_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_ACTIVENESSAWARD_RET;
        }
    }
    public class GC_ASK_BINDNUMBER_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_BINDNUMBER_RET;
        }
    }
    public class GC_ASK_COMMONFLAG_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_COMMONFLAG_RET;
        }
    }
    public class GC_ASK_GAIN_10_FELLOW_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_GAIN_10_FELLOW_RET;
        }
    }
    public class GC_ASK_GAIN_FELLOW_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_GAIN_FELLOW_RET;
        }
    }
    public class GC_ASK_LOUDSPEAKER_CONTENT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_LOUDSPEAKER_CONTENT;
        }
    }
    public class GC_ASK_PAY_ACTIVITY_PRIZE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_PAY_ACTIVITY_PRIZE_RET;
        }
    }
    public class GC_ASK_PAY_ACTIVITY_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_PAY_ACTIVITY_RET;
        }
    }
    public class GC_ASK_STARTGUILDWAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_STARTGUILDWAR;
        }
    }
    public class GC_ASK_UPDATE_STORAGEPACK_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ASK_UPDATE_STORAGEPACK_RET;
        }
    }
    public class GC_ATTACKFLY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ATTACKFLY;
        }
    }
    public class GC_BACKPACK_RESIZE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BACKPACK_RESIZE;
        }
    }
    public class GC_BELLE_ACTIVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_ACTIVE;
        }
    }
    public class GC_BELLE_ACTIVEMATRIX_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_ACTIVEMATRIX_RET;
        }
    }
    public class GC_BELLE_BATTLE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_BATTLE_RET;
        }
    }
    public class GC_BELLE_CANCELMATRIX_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_CANCELMATRIX_RET;
        }
    }
    public class GC_BELLE_CLOSE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_CLOSE_RET;
        }
    }
    public class GC_BELLE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_DATA;
        }
    }
    public class GC_BELLE_EVOLUTIONRAPID_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_EVOLUTIONRAPID_RET;
        }
    }
    public class GC_BELLE_EVOLUTION_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_EVOLUTION_RET;
        }
    }
    public class GC_BELLE_REST_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BELLE_REST_RET;
        }
    }
    public class GC_BROADCAST_ATTR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BROADCAST_ATTR;
        }
    }
    public class GC_BUY_GUILDGOODS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_BUY_GUILDGOODS;
        }
    }
    public class GC_CALL_FELLOW_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CALL_FELLOW_RET;
        }
    }
    public class GC_CDTIME_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CDTIME_UPDATE;
        }
    }
    public class GC_CHALLENGERANKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHALLENGERANKLIST;
        }
    }
    public class GC_CHALLENGE_HISTORY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHALLENGE_HISTORY;
        }
    }
    public class GC_CHALLENGE_MYDATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHALLENGE_MYDATA;
        }
    }
    public class GC_CHALLENGE_REWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHALLENGE_REWARD;
        }
    }
    public class GC_CHANGENAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHANGENAME;
        }
    }
    public class GC_CHANGE_PKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHANGE_PKLIST;
        }
    }
    public class GC_CHANGE_SHOWFASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHANGE_SHOWFASHION;
        }
    }
    public class GC_CHAT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CHAT;
        }
    }
    public class GC_CLOSE_BLACKMARKET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CLOSE_BLACKMARKET;
        }
    }
    public class GC_COMBATVALUE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_COMBATVALUE_RET;
        }
    }
    public class GC_COMPLETEMISSION_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_COMPLETEMISSION_RET;
        }
    }
    public class GC_CONNECTED_HEARTBEAT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CONNECTED_HEARTBEAT;
        }
    }
    public class GC_COPYSCENE_INVITE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_COPYSCENE_INVITE;
        }
    }
    public class GC_COPYSCENE_RESULT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_COPYSCENE_RESULT;
        }
    }
    public class GC_COUNTDOWN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_COUNTDOWN;
        }
    }
    public class GC_CREATEROLE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATEROLE_RET;
        }
    }
    public class GC_CREATE_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_FELLOW;
        }
    }
    public class GC_CREATE_NPC_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_NPC;
        }
    }
    public class GC_CREATE_PLAYER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_PLAYER;
        }
    }
    public class GC_CREATE_SNARE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_SNARE;
        }
    }
    public class GC_CREATE_YANHUA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_YANHUA;
        }
    }
    public class GC_CREATE_ZOMBIEUSER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_CREATE_ZOMBIEUSER;
        }
    }
    public class GC_DAILYAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAILYAWARD_DATA;
        }
    }
    public class GC_DAILYLUCKYDRAW_FAIL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAILYLUCKYDRAW_FAIL;
        }
    }
    public class GC_DAILYLUCKYDRAW_GAINBONUS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAILYLUCKYDRAW_GAINBONUS;
        }
    }
    public class GC_DAILYLUCKYDRAW_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAILYLUCKYDRAW_UPDATE;
        }
    }
    public class GC_DAILYMISSION_UPDATE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAILYMISSION_UPDATE_RET;
        }
    }
    public class GC_DAMAGEBOARD_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAMAGEBOARD_INFO;
        }
    }
    public class GC_DAYAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DAYAWARD_DATA;
        }
    }
    public class GC_DEBUG_MY_POS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DEBUG_MY_POS;
        }
    }
    public class GC_DELBLACKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DELBLACKLIST;
        }
    }
    public class GC_DELETE_OBJ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DELETE_OBJ;
        }
    }
    public class GC_DELETE_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DELETE_TITLE;
        }
    }
    public class GC_DELFRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DELFRIEND;
        }
    }
    public class GC_DELHATELIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DELHATELIST;
        }
    }
    public class GC_DO_CLIENT_SCRIPT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DO_CLIENT_SCRIPT;
        }
    }
    public class GC_DROPITEM_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DROPITEM_INFO;
        }
    }
    public class GC_DUEL_REQUESTU_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DUEL_REQUESTU;
        }
    }
    public class GC_DUEL_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DUEL_STATE;
        }
    }
    public class GC_DYNAMICOBSTACLE_OPT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_DYNAMICOBSTACLE_OPT;
        }
    }
    public class GC_ENTER_SCENE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ENTER_SCENE;
        }
    }
    public class GC_EQUIP_ENCHANCE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_EQUIP_ENCHANCE_RET;
        }
    }
    public class GC_EQUIP_FELLOW_SKILL_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_EQUIP_FELLOW_SKILL_RET;
        }
    }
    public class GC_EQUIP_STAR_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_EQUIP_STAR_RET;
        }
    }
    public class GC_FELLOW_APPLY_POINT_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FELLOW_APPLY_POINT_RET;
        }
    }
    public class GC_FELLOW_CHANGE_NAME_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FELLOW_CHANGE_NAME_RET;
        }
    }
    public class GC_FELLOW_ENCHANCE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FELLOW_ENCHANCE_RET;
        }
    }
    public class GC_FELLOW_STAR_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FELLOW_STAR_RET;
        }
    }
    public class GC_FINDPLAYER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FINDPLAYER;
        }
    }
    public class GC_FORCE_SETPOS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_FORCE_SETPOS;
        }
    }
    public class GC_GAIN_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GAIN_TITLE;
        }
    }
    public class GC_GUILDACTIVITY_BOSSDATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILDACTIVITY_BOSSDATA;
        }
    }
    public class GC_GUILD_CREATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_CREATE;
        }
    }
    public class GC_GUILD_INVITE_CONFIRM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_INVITE_CONFIRM;
        }
    }
    public class GC_GUILD_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_JOIN;
        }
    }
    public class GC_GUILD_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_LEAVE;
        }
    }
    public class GC_GUILD_NEWRESERVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_NEWRESERVE;
        }
    }
    public class GC_GUILD_RET_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_RET_INFO;
        }
    }
    public class GC_GUILD_RET_LEVELUP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_RET_LEVELUP;
        }
    }
    public class GC_GUILD_RET_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_GUILD_RET_LIST;
        }
    }
    public class GC_HUASHAN_PVP_ASSIST_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_ASSIST_STATE;
        }
    }
    public class GC_HUASHAN_PVP_MEMBERLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_MEMBERLIST;
        }
    }
    public class GC_HUASHAN_PVP_OPPONENTVIEW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_OPPONENTVIEW;
        }
    }
    public class GC_HUASHAN_PVP_SELFPOSITION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_SELFPOSITION;
        }
    }
    public class GC_HUASHAN_PVP_SHOWSEARCH_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_SHOWSEARCH;
        }
    }
    public class GC_HUASHAN_PVP_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_HUASHAN_PVP_STATE;
        }
    }
    public class GC_JOIN_TEAM_INVITE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_JOIN_TEAM_INVITE;
        }
    }
    public class GC_JOIN_TEAM_REQUEST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_JOIN_TEAM_REQUEST;
        }
    }
    public class GC_LEVELAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_LEVELAWARD_DATA;
        }
    }
    public class GC_LEVELUP_FELLOW_SKILL_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_LEVELUP_FELLOW_SKILL_RET;
        }
    }
    public class GC_LOGIN_QUEUE_STATUS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_LOGIN_QUEUE_STATUS;
        }
    }
    public class GC_LOGIN_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_LOGIN_RET;
        }
    }
    public class GC_MAIL_DELETE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MAIL_DELETE;
        }
    }
    public class GC_MAIL_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MAIL_UPDATE;
        }
    }
    public class GC_MASTERSHOP_BUY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTERSHOP_BUY;
        }
    }
    public class GC_MASTER_ACTIVE_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_ACTIVE_SKILL;
        }
    }
    public class GC_MASTER_APPROVE_RESERVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_APPROVE_RESERVE;
        }
    }
    public class GC_MASTER_CREATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_CREATE;
        }
    }
    public class GC_MASTER_FORGET_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_FORGET_SKILL;
        }
    }
    public class GC_MASTER_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_JOIN;
        }
    }
    public class GC_MASTER_KICK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_KICK;
        }
    }
    public class GC_MASTER_LEARN_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_LEARN_SKILL;
        }
    }
    public class GC_MASTER_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_LEAVE;
        }
    }
    public class GC_MASTER_RET_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_RET_INFO;
        }
    }
    public class GC_MASTER_RET_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MASTER_RET_LIST;
        }
    }
    public class GC_MERCENARY_EMPLOYLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MERCENARY_EMPLOYLIST;
        }
    }
    public class GC_MERCENARY_LEFTTIMES_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MERCENARY_LEFTTIMES;
        }
    }
    public class GC_MERCENARY_LIST_RES_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MERCENARY_LIST_RES;
        }
    }
    public class GC_MISSION_IGNOREMISSIONPREFLAG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MISSION_IGNOREMISSIONPREFLAG;
        }
    }
    public class GC_MISSION_PARAM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MISSION_PARAM;
        }
    }
    public class GC_MISSION_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MISSION_STATE;
        }
    }
    public class GC_MISSION_SYNC_MISSIONLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MISSION_SYNC_MISSIONLIST;
        }
    }
    public class GC_MONEYTREE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MONEYTREE_DATA;
        }
    }
    public class GC_MOUNTCOLLECTED_FLAG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MOUNTCOLLECTED_FLAG;
        }
    }
    public class GC_MOUNT_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MOUNT_DATA;
        }
    }
    public class GC_MOUNT_MARK_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MOUNT_MARK_RET;
        }
    }
    public class GC_MOVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_MOVE;
        }
    }
    public class GC_NEAR_PLAYERLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NEAR_PLAYERLIST;
        }
    }
    public class GC_NEAR_TEAMLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NEAR_TEAMLIST;
        }
    }
    public class GC_NEW7DAYONLINEAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NEW7DAYONLINEAWARD_DATA;
        }
    }
    public class GC_NEWONLINEAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NEWONLINEAWARD_DATA;
        }
    }
    public class GC_NEWSERVERAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NEWSERVERAWARD_DATA;
        }
    }
    public class GC_NOTICE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NOTICE;
        }
    }
    public class GC_NOTICE_ADDED_FRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_NOTICE_ADDED_FRIEND;
        }
    }
    public class GC_ONLINEAWARD_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_ONLINEAWARD_DATA;
        }
    }
    public class GC_OPENFUNCTION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_OPENFUNCTION;
        }
    }
    public class GC_OPEN_SHAREWINDOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_OPEN_SHAREWINDOW;
        }
    }
    public class GC_OPPONENT_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_OPPONENT_LIST;
        }
    }
    public class GC_OP_QINGGONGPOINT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_OP_QINGGONGPOINT;
        }
    }
    public class GC_OP_TELEPORT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_OP_TELEPORT;
        }
    }
    public class GC_PAY_ORDER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PAY_ORDER;
        }
    }
    public class GC_PLAYSHANDIANLIANEFFECT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAYSHANDIANLIANEFFECT;
        }
    }
    public class GC_PLAYSTORY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAYSTORY;
        }
    }
    public class GC_PLAY_EFFECT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAY_EFFECT;
        }
    }
    public class GC_PLAY_MODELSOTRY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAY_MODELSOTRY;
        }
    }
    public class GC_PLAY_SOUNDS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAY_SOUNDS;
        }
    }
    public class GC_PLAY_YANHUA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PLAY_YANHUA;
        }
    }
    public class GC_POWERUP_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_POWERUP_LIST;
        }
    }
    public class GC_PUSH_NOTIFICATION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PUSH_NOTIFICATION;
        }
    }
    public class GC_PUT_GEM_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PUT_GEM_RET;
        }
    }
    public class GC_PUT_ITEM_STORAGEPACK_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_PUT_ITEM_STORAGEPACK_RET;
        }
    }
    public class GC_QIANKUNDAI_PRODUCT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_QIANKUNDAI_PRODUCT;
        }
    }
    public class GC_REMOVEEFFECT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_REMOVEEFFECT;
        }
    }
    public class GC_RESOLVE_FELLOW_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RESOLVE_FELLOW_RET;
        }
    }
    public class GC_RESTAURANT_DESTUPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RESTAURANT_DESTUPDATE;
        }
    }
    public class GC_RESTAURANT_LEVELUPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RESTAURANT_LEVELUPDATE;
        }
    }
    public class GC_RESTAURANT_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RESTAURANT_UPDATE;
        }
    }
    public class GC_RESTAURANT_VISITFRIENDINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RESTAURANT_VISITFRIENDINFO;
        }
    }
    public class GC_RES_POWERUP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RES_POWERUP;
        }
    }
    public class GC_RET_ACTIVE_LEICHONG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_ACTIVE_LEICHONG;
        }
    }
    public class GC_RET_ACTIVE_YUEKA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_ACTIVE_YUEKA;
        }
    }
    public class GC_RET_AUTOTEAM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_AUTOTEAM;
        }
    }
    public class GC_RET_BLACKMARKETITEMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_BLACKMARKETITEMINFO;
        }
    }
    public class GC_RET_CHANGENAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_CHANGENAME;
        }
    }
    public class GC_RET_CHANGE_PKMODLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_CHANGE_PKMODLE;
        }
    }
    public class GC_RET_CONSIGNSALEITEMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_CONSIGNSALEITEMINFO;
        }
    }
    public class GC_RET_COPYSCENE_REWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_COPYSCENE_REWARD;
        }
    }
    public class GC_RET_COPYSCENE_SWEEP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_COPYSCENE_SWEEP;
        }
    }
    public class GC_RET_CURGUILDWARTYPE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_CURGUILDWARTYPE;
        }
    }
    public class GC_RET_ENEMYGUILDINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_ENEMYGUILDINFO;
        }
    }
    public class GC_RET_FANKUI_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_FANKUI;
        }
    }
    public class GC_RET_FELLOW_RESET_POINT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_FELLOW_RESET_POINT;
        }
    }
    public class GC_RET_FINALGUILDWARGROUPINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_FINALGUILDWARGROUPINFO;
        }
    }
    public class GC_RET_FINALGUILDWARPOINTINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_FINALGUILDWARPOINTINFO;
        }
    }
    public class GC_RET_FRIEND_USERINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_FRIEND_USERINFO;
        }
    }
    public class GC_RET_GUILDBUSINESSINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_GUILDBUSINESSINFO;
        }
    }
    public class GC_RET_GUILDMISSIONINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_GUILDMISSIONINFO;
        }
    }
    public class GC_RET_HUASHAN_PKINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_HUASHAN_PKINFO;
        }
    }
    public class GC_RET_ISWILDENEMY2USER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_ISWILDENEMY2USER;
        }
    }
    public class GC_RET_JUQINGITEM_PLAYEFFECT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_JUQINGITEM_PLAYEFFECT;
        }
    }
    public class GC_RET_LEVELUP_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_LEVELUP_SWORDSMAN;
        }
    }
    public class GC_RET_LOCK_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_LOCK_TITLE;
        }
    }
    public class GC_RET_MARRAGE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_MARRAGE;
        }
    }
    public class GC_RET_MYCONSIGNSALEITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_MYCONSIGNSALEITEM;
        }
    }
    public class GC_RET_OTHERROLE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_OTHERROLE_DATA;
        }
    }
    public class GC_RET_PICKUP_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_PICKUP_ITEM;
        }
    }
    public class GC_RET_PKINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_PKINFO;
        }
    }
    public class GC_RET_PRELIMINARY_WARINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_PRELIMINARY_WARINFO;
        }
    }
    public class GC_RET_PUT_GEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_PUT_GEM;
        }
    }
    public class GC_RET_QUIT_GAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_QUIT_GAME;
        }
    }
    public class GC_RET_RANDOMNAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_RANDOMNAME;
        }
    }
    public class GC_RET_RANK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_RANK;
        }
    }
    public class GC_RET_RELIVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_RELIVE;
        }
    }
    public class GC_RET_ROLE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_ROLE_DATA;
        }
    }
    public class GC_RET_SELOBJ_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_SELOBJ_INFO;
        }
    }
    public class GC_RET_TEAMPLATFORMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_TEAMPLATFORMINFO;
        }
    }
    public class GC_RET_TRAIL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_TRAIL;
        }
    }
    public class GC_RET_USE_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_USE_SKILL;
        }
    }
    public class GC_RET_VISIT_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_VISIT_SWORDSMAN;
        }
    }
    public class GC_RET_YUANBAOSHOP_OPEN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_RET_YUANBAOSHOP_OPEN;
        }
    }
    public class GC_SCENE_TIMESCALE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SCENE_TIMESCALE;
        }
    }
    public class GC_SELECTROLE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SELECTROLE_RET;
        }
    }
    public class GC_SEND_CURFASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SEND_CURFASHION;
        }
    }
    public class GC_SEND_FASHIONINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SEND_FASHIONINFO;
        }
    }
    public class GC_SERVERFLAGS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SERVERFLAGS;
        }
    }
    public class GC_SERVER_CONFIG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SERVER_CONFIG;
        }
    }
    public class GC_SERVER_SERIOUSERROR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SERVER_SERIOUSERROR;
        }
    }
    public class GC_SHOWPKNOTICE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOWPKNOTICE;
        }
    }
    public class GC_SHOW_BLACKMARKET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_BLACKMARKET;
        }
    }
    public class GC_SHOW_EQUIPREMIND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_EQUIPREMIND;
        }
    }
    public class GC_SHOW_ITEMREMIND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_ITEMREMIND;
        }
    }
    public class GC_SHOW_PRELIMINARY_WARRET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_PRELIMINARY_WARRET;
        }
    }
    public class GC_SHOW_SKILLNAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_SKILLNAME;
        }
    }
    public class GC_SHOW_USEITEMREMIND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SHOW_USEITEMREMIND;
        }
    }
    public class GC_SKILL_FINISH_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SKILL_FINISH;
        }
    }
    public class GC_SKILL_STUDY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SKILL_STUDY;
        }
    }
    public class GC_SNS_ACTIVE_SHOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SNS_ACTIVE_SHOW;
        }
    }
    public class GC_SNS_INVITE_CODE_RESPONSE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SNS_INVITE_CODE_RESPONSE;
        }
    }
    public class GC_STOP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_STOP;
        }
    }
    public class GC_SWORDSMANPACK_RESIZE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SWORDSMANPACK_RESIZE;
        }
    }
    public class GC_SYC_FRIEND_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYC_FRIEND_INFO;
        }
    }
    public class GC_SYC_FRIEND_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYC_FRIEND_STATE;
        }
    }
    public class GC_SYC_FULL_BLACK_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYC_FULL_BLACK_LIST;
        }
    }
    public class GC_SYC_FULL_FRIEND_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYC_FULL_FRIEND_LIST;
        }
    }
    public class GC_SYC_FULL_HATE_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYC_FULL_HATE_LIST;
        }
    }
    public class GC_SYNC_ACTIVENESS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_ACTIVENESS;
        }
    }
    public class GC_SYNC_ACTIVENESSAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_ACTIVENESSAWARD;
        }
    }
    public class GC_SYNC_ACTIVETITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_ACTIVETITLE;
        }
    }
    public class GC_SYNC_AWARDTABLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_AWARDTABLE;
        }
    }
    public class GC_SYNC_COMMONDATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_COMMONDATA;
        }
    }
    public class GC_SYNC_COMMONFLAG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_COMMONFLAG;
        }
    }
    public class GC_SYNC_COPYSCENEEXTRANUMBER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_COPYSCENEEXTRANUMBER;
        }
    }
    public class GC_SYNC_COPYSCENENUMBER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_COPYSCENENUMBER;
        }
    }
    public class GC_SYNC_FASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_FASHION;
        }
    }
    public class GC_SYNC_MASTER_SKILL_NAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_MASTER_SKILL_NAME;
        }
    }
    public class GC_SYNC_NEW7DAYONLINEAWARDTABLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_NEW7DAYONLINEAWARDTABLE;
        }
    }
    public class GC_SYNC_NEWONLINEAWARDTABLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_NEWONLINEAWARDTABLE;
        }
    }
    public class GC_SYNC_PAY_ACTIVITY_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_PAY_ACTIVITY_DATA;
        }
    }
    public class GC_SYNC_PLAYERFACEDIR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_PLAYERFACEDIR;
        }
    }
    public class GC_SYNC_PLAYER_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_PLAYER_STATE;
        }
    }
    public class GC_SYNC_POS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_POS;
        }
    }
    public class GC_SYNC_REACHEDSCENE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNC_REACHEDSCENE;
        }
    }
    public class GC_SYNSELTRAGET_ATTR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYNSELTRAGET_ATTR;
        }
    }
    public class GC_SYN_ATTR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYN_ATTR;
        }
    }
    public class GC_SYN_LOVERINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYN_LOVERINFO;
        }
    }
    public class GC_SYN_SKILLINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYN_SKILLINFO;
        }
    }
    public class GC_SYN_TORCH_VALUE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYN_TORCH_VALUE;
        }
    }
    public class GC_SYSTEMSHOP_MERCHANDISELIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_SYSTEMSHOP_MERCHANDISELIST;
        }
    }
    public class GC_TAKE_GEM_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TAKE_GEM_RET;
        }
    }
    public class GC_TAKE_ITEM_STORAGEPACK_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TAKE_ITEM_STORAGEPACK_RET;
        }
    }
    public class GC_TEAM_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TEAM_LEAVE;
        }
    }
    public class GC_TEAM_SYNC_MEMBERINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TEAM_SYNC_MEMBERINFO;
        }
    }
    public class GC_TEAM_SYNC_TEAMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TEAM_SYNC_TEAMINFO;
        }
    }
    public class GC_TELEMOVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TELEMOVE;
        }
    }
    public class GC_TODAY_FIRST_LOGIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_TODAY_FIRST_LOGIN;
        }
    }
    public class GC_UI_NEWPLAYERGUIDE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UI_NEWPLAYERGUIDE;
        }
    }
    public class GC_UI_OPERATION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UI_OPERATION;
        }
    }
    public class GC_UNCALL_FELLOW_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UNCALL_FELLOW_RET;
        }
    }
    public class GC_UNEQUIP_FELLOW_SKILL_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UNEQUIP_FELLOW_SKILL_RET;
        }
    }
    public class GC_UPDATEITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATEITEM;
        }
    }
    public class GC_UPDATENOTICEDATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATENOTICEDATA;
        }
    }
    public class GC_UPDATE_ACTIVE_FELLOWSKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_ACTIVE_FELLOWSKILL;
        }
    }
    public class GC_UPDATE_ALL_TITLEINVESTITIVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_ALL_TITLEINVESTITIVE;
        }
    }
    public class GC_UPDATE_ANIMATION_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_ANIMATION_STATE;
        }
    }
    public class GC_UPDATE_DEF_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_DEF_TITLE;
        }
    }
    public class GC_UPDATE_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_FELLOW;
        }
    }
    public class GC_UPDATE_GAIN_FELLOW_COUNT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_GAIN_FELLOW_COUNT;
        }
    }
    public class GC_UPDATE_GEM_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_GEM_INFO;
        }
    }
    public class GC_UPDATE_HITPONIT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_HITPONIT;
        }
    }
    public class GC_UPDATE_NEEDIMPACTINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_NEEDIMPACTINFO;
        }
    }
    public class GC_UPDATE_RECHARGESTATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_RECHARGESTATE;
        }
    }
    public class GC_UPDATE_SCENE_INSTACTIVATION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_SCENE_INSTACTIVATION;
        }
    }
    public class GC_UPDATE_STAMINA_TIME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_STAMINA_TIME;
        }
    }
    public class GC_UPDATE_STORAGEPACK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_STORAGEPACK;
        }
    }
    public class GC_UPDATE_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_SWORDSMAN;
        }
    }
    public class GC_UPDATE_SWORDSMAN_VISITSTATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_UPDATE_SWORDSMAN_VISITSTATE;
        }
    }
    public class GC_USERTIP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_USERTIP;
        }
    }
    public class GC_USE_ITEM_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_USE_ITEM_RET;
        }
    }
    public class GC_WORLDBOSS_CHALLEGE_RES_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_WORLDBOSS_CHALLEGE_RES;
        }
    }
    public class GC_WORLDBOSS_DEAD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_WORLDBOSS_DEAD;
        }
    }
    public class GC_WORLDBOSS_OPEN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_WORLDBOSS_OPEN;
        }
    }
    public class GC_WORLDBOSS_SOMECHALL_ME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_WORLDBOSS_SOMECHALL_ME;
        }
    }
    public class GC_WORLDBOSS_TEAMLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_GC_WORLDBOSS_TEAMLIST;
        }
    }
    public class CG_ABANDONMISSION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ABANDONMISSION;
        }
    }
    public class CG_ACCEPTMISSION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ACCEPTMISSION;
        }
    }
    public class CG_ACK_ACTIVE_LEICHONG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ACK_ACTIVE_LEICHONG;
        }
    }
    public class CG_ACTIVE_FELLOW_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ACTIVE_FELLOW_SKILL;
        }
    }
    public class CG_ACTIVE_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ACTIVE_TITLE;
        }
    }
    public class CG_ADDBLACKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ADDBLACKLIST;
        }
    }
    public class CG_ADDFRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ADDFRIEND;
        }
    }
    public class CG_ADDPAY_TEST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ADDPAY_TEST;
        }
    }
    public class CG_ASK_7DAYAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_7DAYAWARD;
        }
    }
    public class CG_ASK_ACTIVENESSAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_ACTIVENESSAWARD;
        }
    }
    public class CG_ASK_AUTOTEAM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_AUTOTEAM;
        }
    }
    public class CG_ASK_BINDNUMBER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_BINDNUMBER;
        }
    }
    public class CG_ASK_BLACKMARKETITEMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_BLACKMARKETITEMINFO;
        }
    }
    public class CG_ASK_CHALLENGEGUILDWAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_CHALLENGEGUILDWAR;
        }
    }
    public class CG_ASK_CONSIGNSALEITEMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_CONSIGNSALEITEMINFO;
        }
    }
    public class CG_ASK_COPYSCENE_REWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_COPYSCENE_REWARD;
        }
    }
    public class CG_ASK_COPYSCENE_SWEEP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_COPYSCENE_SWEEP;
        }
    }
    public class CG_ASK_CURGUILDWARTYPE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_CURGUILDWARTYPE;
        }
    }
    public class CG_ASK_DAILYAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_DAILYAWARD;
        }
    }
    public class CG_ASK_DAYAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_DAYAWARD;
        }
    }
    public class CG_ASK_ENEMYGUILDINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_ENEMYGUILDINFO;
        }
    }
    public class CG_ASK_FINALGUILDWARGROUPINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_FINALGUILDWARGROUPINFO;
        }
    }
    public class CG_ASK_FINALGUILDWARPOINTINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_FINALGUILDWARPOINTINFO;
        }
    }
    public class CG_ASK_GAIN_10_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GAIN_10_FELLOW;
        }
    }
    public class CG_ASK_GAIN_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GAIN_FELLOW;
        }
    }
    public class CG_ASK_GUILDBUSINESSINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GUILDBUSINESSINFO;
        }
    }
    public class CG_ASK_GUILDBUSINESS_ACCEPT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GUILDBUSINESS_ACCEPT;
        }
    }
    public class CG_ASK_GUILDMISSIONINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GUILDMISSIONINFO;
        }
    }
    public class CG_ASK_GUILDWILDWAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GUILDWILDWAR;
        }
    }
    public class CG_ASK_GUILD_MAKE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_GUILD_MAKE;
        }
    }
    public class CG_ASK_HIDE_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_HIDE_FELLOW;
        }
    }
    public class CG_ASK_HUASHANPVP_STATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_HUASHANPVP_STATE;
        }
    }
    public class CG_ASK_ISRECHARGE_ENABLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_ISRECHARGE_ENABLE;
        }
    }
    public class CG_ASK_LEVELAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_LEVELAWARD;
        }
    }
    public class CG_ASK_LEVELUPSKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_LEVELUPSKILL;
        }
    }
    public class CG_ASK_LOCK_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_LOCK_TITLE;
        }
    }
    public class CG_ASK_LOUDSPEAKER_POOL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_LOUDSPEAKER_POOL;
        }
    }
    public class CG_ASK_MYCONSIGNSALEITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_MYCONSIGNSALEITEM;
        }
    }
    public class CG_ASK_NEW7DAYONLINEAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_NEW7DAYONLINEAWARD;
        }
    }
    public class CG_ASK_NEWONLINEAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_NEWONLINEAWARD;
        }
    }
    public class CG_ASK_NEWPLAYER_CREATE_NPC_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_NEWPLAYER_CREATE_NPC;
        }
    }
    public class CG_ASK_NEWSERVERAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_NEWSERVERAWARD;
        }
    }
    public class CG_ASK_ONLINEAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_ONLINEAWARD;
        }
    }
    public class CG_ASK_OTHERROLE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_OTHERROLE_DATA;
        }
    }
    public class CG_ASK_PAY_ACTIVITY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_PAY_ACTIVITY;
        }
    }
    public class CG_ASK_PAY_ACTIVITY_PRIZE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_PAY_ACTIVITY_PRIZE;
        }
    }
    public class CG_ASK_PICKUP_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_PICKUP_ITEM;
        }
    }
    public class CG_ASK_PKINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_PKINFO;
        }
    }
    public class CG_ASK_PRELIMINARY_WARINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_PRELIMINARY_WARINFO;
        }
    }
    public class CG_ASK_QUIT_GAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_QUIT_GAME;
        }
    }
    public class CG_ASK_RANK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_RANK;
        }
    }
    public class CG_ASK_RELIVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_RELIVE;
        }
    }
    public class CG_ASK_ROLE_DATA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_ROLE_DATA;
        }
    }
    public class CG_ASK_SELOBJ_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_SELOBJ_INFO;
        }
    }
    public class CG_ASK_SETAUTOASSIGNPSTIMES_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_SETAUTOASSIGNPSTIMES;
        }
    }
    public class CG_ASK_SETCOMMONFLAG_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_SETCOMMONFLAG;
        }
    }
    public class CG_ASK_SHOW_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_SHOW_FELLOW;
        }
    }
    public class CG_ASK_SPECIALAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_SPECIALAWARD;
        }
    }
    public class CG_ASK_TEAMPLATFORMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_TEAMPLATFORMINFO;
        }
    }
    public class CG_ASK_TIDY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_TIDY;
        }
    }
    public class CG_ASK_TORCH_VALUE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_TORCH_VALUE;
        }
    }
    public class CG_ASK_TRAIL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_TRAIL;
        }
    }
    public class CG_ASK_UPDATE_STORAGEPACK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_UPDATE_STORAGEPACK;
        }
    }
    public class CG_ASK_YUANBAOSHOP_OPEN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASK_YUANBAOSHOP_OPEN;
        }
    }
    public class CG_ASSIGN_GUILDBUSINESS_TIME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASSIGN_GUILDBUSINESS_TIME;
        }
    }
    public class CG_ASSIGN_GUILDMISSION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ASSIGN_GUILDMISSION;
        }
    }
    public class CG_BACKPACK_UNLOCK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BACKPACK_UNLOCK;
        }
    }
    public class CG_BELLE_ACTIVEMATRIX_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_ACTIVEMATRIX;
        }
    }
    public class CG_BELLE_BATTLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_BATTLE;
        }
    }
    public class CG_BELLE_CANCELMATRIX_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_CANCELMATRIX;
        }
    }
    public class CG_BELLE_CLOSE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_CLOSE;
        }
    }
    public class CG_BELLE_EVOLUTION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_EVOLUTION;
        }
    }
    public class CG_BELLE_EVOLUTIONRAPID_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_EVOLUTIONRAPID;
        }
    }
    public class CG_BELLE_REST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BELLE_REST;
        }
    }
    public class CG_BUY_BLACKMARKETITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_BLACKMARKETITEM;
        }
    }
    public class CG_BUY_CONSIGNSALEITEMINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_CONSIGNSALEITEMINFO;
        }
    }
    public class CG_BUY_FASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_FASHION;
        }
    }
    public class CG_BUY_GUILDGOODS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_GUILDGOODS;
        }
    }
    public class CG_BUY_STAMINA_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_STAMINA;
        }
    }
    public class CG_BUY_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_SWORDSMAN;
        }
    }
    public class CG_BUY_YUANBAOGOODS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_BUY_YUANBAOGOODS;
        }
    }
    public class CG_CALL_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CALL_FELLOW;
        }
    }
    public class CG_CANCELCONSIGNSALEITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CANCELCONSIGNSALEITEM;
        }
    }
    public class CG_CHALLENGERANKLIST_REQ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CHALLENGERANKLIST_REQ;
        }
    }
    public class CG_CHANGE_MAJORCITY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CHANGE_MAJORCITY;
        }
    }
    public class CG_CHANGE_PKMODLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CHANGE_PKMODLE;
        }
    }
    public class CG_CHANGE_SHOWFASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CHANGE_SHOWFASHION;
        }
    }
    public class CG_CHAT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CHAT;
        }
    }
    public class CG_CH_MON_FIGHT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CH_MON_FIGHT;
        }
    }
    public class CG_COMBATVALUE_ASK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_COMBATVALUE_ASK;
        }
    }
    public class CG_COMPLETEMISSION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_COMPLETEMISSION;
        }
    }
    public class CG_CONNECTED_HEARTBEAT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CONNECTED_HEARTBEAT;
        }
    }
    public class CG_CONSIGNSALEITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CONSIGNSALEITEM;
        }
    }
    public class CG_COPYSCENERESET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_COPYSCENERESET;
        }
    }
    public class CG_COPYSCENE_INVITE_RET_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_COPYSCENE_INVITE_RET;
        }
    }
    public class CG_CREATEROLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CREATEROLE;
        }
    }
    public class CG_CYPAY_SUCCESS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_CYPAY_SUCCESS;
        }
    }
    public class CG_DAILYLUCKYDRAW_DRAW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DAILYLUCKYDRAW_DRAW;
        }
    }
    public class CG_DAILYMISSION_UPDATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DAILYMISSION_UPDATE;
        }
    }
    public class CG_DELBLACKLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DELBLACKLIST;
        }
    }
    public class CG_DELETE_TITLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DELETE_TITLE;
        }
    }
    public class CG_DELFRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DELFRIEND;
        }
    }
    public class CG_DELHATELIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DELHATELIST;
        }
    }
    public class CG_DUEL_REQUEST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DUEL_REQUEST;
        }
    }
    public class CG_DUEL_RESPONSE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_DUEL_RESPONSE;
        }
    }
    public class CG_ENTER_SCENE_OK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_ENTER_SCENE_OK;
        }
    }
    public class CG_EQUIP_ENCHANCE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_EQUIP_ENCHANCE;
        }
    }
    public class CG_EQUIP_FELLOW_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_EQUIP_FELLOW_SKILL;
        }
    }
    public class CG_EQUIP_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_EQUIP_ITEM;
        }
    }
    public class CG_EQUIP_STAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_EQUIP_STAR;
        }
    }
    public class CG_EQUIP_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_EQUIP_SWORDSMAN;
        }
    }
    public class CG_FACEDIR_PLAYER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FACEDIR_PLAYER;
        }
    }
    public class CG_FELLOW_APPLY_POINT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FELLOW_APPLY_POINT;
        }
    }
    public class CG_FELLOW_CHANGE_NAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FELLOW_CHANGE_NAME;
        }
    }
    public class CG_FELLOW_ENCHANCE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FELLOW_ENCHANCE;
        }
    }
    public class CG_FELLOW_RESET_POINT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FELLOW_RESET_POINT;
        }
    }
    public class CG_FELLOW_STAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FELLOW_STAR;
        }
    }
    public class CG_FIGHTGUILDWARPOINT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FIGHTGUILDWARPOINT;
        }
    }
    public class CG_FINDPLAYER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_FINDPLAYER;
        }
    }
    public class CG_GMCOMMAND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GMCOMMAND;
        }
    }
    public class CG_GUIDE_STEP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUIDE_STEP;
        }
    }
    public class CG_GUILD_APPROVE_RESERVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_APPROVE_RESERVE;
        }
    }
    public class CG_GUILD_CREATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_CREATE;
        }
    }
    public class CG_GUILD_INVITE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_INVITE;
        }
    }
    public class CG_GUILD_INVITE_CONFIRM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_INVITE_CONFIRM;
        }
    }
    public class CG_GUILD_JOB_CHANGE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_JOB_CHANGE;
        }
    }
    public class CG_GUILD_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_JOIN;
        }
    }
    public class CG_GUILD_JOIN_OTHERPLAYER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_JOIN_OTHERPLAYER;
        }
    }
    public class CG_GUILD_KICK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_KICK;
        }
    }
    public class CG_GUILD_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_LEAVE;
        }
    }
    public class CG_GUILD_REQ_CHANGE_NOTICE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_REQ_CHANGE_NOTICE;
        }
    }
    public class CG_GUILD_REQ_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_REQ_INFO;
        }
    }
    public class CG_GUILD_REQ_LEVELUP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_REQ_LEVELUP;
        }
    }
    public class CG_GUILD_REQ_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_GUILD_REQ_LIST;
        }
    }
    public class CG_HUASHAN_ASSIST_REQ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_HUASHAN_ASSIST_REQ;
        }
    }
    public class CG_HUASHAN_PVP_MEMBERLIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_HUASHAN_PVP_MEMBERLIST;
        }
    }
    public class CG_HUASHAN_PVP_REGISTER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_HUASHAN_PVP_REGISTER;
        }
    }
    public class CG_JOIN_TEAM_INVITE_RESULT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_JOIN_TEAM_INVITE_RESULT;
        }
    }
    public class CG_JOIN_TEAM_REQUEST_RESULT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_JOIN_TEAM_REQUEST_RESULT;
        }
    }
    public class CG_JUQINGITEM_PLAYEFFECT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_JUQINGITEM_PLAYEFFECT;
        }
    }
    public class CG_LEAVE_COPYSCENE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_LEAVE_COPYSCENE;
        }
    }
    public class CG_LEVELUP_FELLOW_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_LEVELUP_FELLOW_SKILL;
        }
    }
    public class CG_LOCK_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_LOCK_FELLOW;
        }
    }
    public class CG_LOCK_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_LOCK_SWORDSMAN;
        }
    }
    public class CG_LOGIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_LOGIN;
        }
    }
    public class CG_MAIL_OPERATION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MAIL_OPERATION;
        }
    }
    public class CG_MAIL_SEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MAIL_SEND;
        }
    }
    public class CG_MASTERSHOP_BUY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTERSHOP_BUY;
        }
    }
    public class CG_MASTER_ACTIVE_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_ACTIVE_SKILL;
        }
    }
    public class CG_MASTER_APPROVE_RESERVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_APPROVE_RESERVE;
        }
    }
    public class CG_MASTER_CREATE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_CREATE;
        }
    }
    public class CG_MASTER_FORGET_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_FORGET_SKILL;
        }
    }
    public class CG_MASTER_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_JOIN;
        }
    }
    public class CG_MASTER_KICK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_KICK;
        }
    }
    public class CG_MASTER_LEARN_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_LEARN_SKILL;
        }
    }
    public class CG_MASTER_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_LEAVE;
        }
    }
    public class CG_MASTER_REQ_CHANGE_NOTICE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_REQ_CHANGE_NOTICE;
        }
    }
    public class CG_MASTER_REQ_INFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_REQ_INFO;
        }
    }
    public class CG_MASTER_REQ_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MASTER_REQ_LIST;
        }
    }
    public class CG_MERCENARY_LIST_REQ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MERCENARY_LIST_REQ;
        }
    }
    public class CG_MERCENARY_REQ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MERCENARY_REQ;
        }
    }
    public class CG_MONEYTREE_ASKAWARD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MONEYTREE_ASKAWARD;
        }
    }
    public class CG_MOUNT_MARK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MOUNT_MARK;
        }
    }
    public class CG_MOUNT_MOUNT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MOUNT_MOUNT;
        }
    }
    public class CG_MOUNT_UNMOUNT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MOUNT_UNMOUNT;
        }
    }
    public class CG_MOVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_MOVE;
        }
    }
    public class CG_OPEN_COPYSCENE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_OPEN_COPYSCENE;
        }
    }
    public class CG_PARTAKE_GUILDMISSION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PARTAKE_GUILDMISSION;
        }
    }
    public class CG_PAY_ORDER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PAY_ORDER;
        }
    }
    public class CG_PLAYSTORY_OVER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PLAYSTORY_OVER;
        }
    }
    public class CG_PRELIMINARY_APPLYGUILDWAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PRELIMINARY_APPLYGUILDWAR;
        }
    }
    public class CG_PUT_GEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PUT_GEM;
        }
    }
    public class CG_PUT_ITEM_STORAGEPACK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_PUT_ITEM_STORAGEPACK;
        }
    }
    public class CG_QIANKUNDAI_COMBINE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_QIANKUNDAI_COMBINE;
        }
    }
    public class CG_RANDOM_OPPONENT_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RANDOM_OPPONENT;
        }
    }
    public class CG_REQUEST_CDKEY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQUEST_CDKEY;
        }
    }
    public class CG_REQ_CHALLENGE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_CHALLENGE;
        }
    }
    public class CG_REQ_CHANGENAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_CHANGENAME;
        }
    }
    public class CG_REQ_CHANGE_SCENE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_CHANGE_SCENE;
        }
    }
    public class CG_REQ_FRIEND_USERINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_FRIEND_USERINFO;
        }
    }
    public class CG_REQ_HUASHAN_PKINFO_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_HUASHAN_PKINFO;
        }
    }
    public class CG_REQ_MARRAGE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_MARRAGE;
        }
    }
    public class CG_REQ_NEAR_LIST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_NEAR_LIST;
        }
    }
    public class CG_REQ_POWERUP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_POWERUP;
        }
    }
    public class CG_REQ_RANDOMNAME_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_RANDOMNAME;
        }
    }
    public class CG_REQ_TEAM_CHANGE_LEADER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_TEAM_CHANGE_LEADER;
        }
    }
    public class CG_REQ_TEAM_INVITE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_TEAM_INVITE;
        }
    }
    public class CG_REQ_TEAM_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_TEAM_JOIN;
        }
    }
    public class CG_REQ_TEAM_KICK_MEMBER_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_TEAM_KICK_MEMBER;
        }
    }
    public class CG_REQ_TEAM_LEAVE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_REQ_TEAM_LEAVE;
        }
    }
    public class CG_RESOLVE_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESOLVE_FELLOW;
        }
    }
    public class CG_RESTAURANT_ACTIVEDESK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESTAURANT_ACTIVEDESK;
        }
    }
    public class CG_RESTAURANT_BILLINGALL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESTAURANT_BILLINGALL;
        }
    }
    public class CG_RESTAURANT_FINISHPREPARE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESTAURANT_FINISHPREPARE;
        }
    }
    public class CG_RESTAURANT_PREPAREFOOD_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESTAURANT_PREPAREFOOD;
        }
    }
    public class CG_RESTAURANT_VISITFRIEND_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RESTAURANT_VISITFRIEND;
        }
    }
    public class CG_RET_STARTWAR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_RET_STARTWAR;
        }
    }
    public class CG_SCENE_CHANGEINST_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SCENE_CHANGEINST;
        }
    }
    public class CG_SELECTROLE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SELECTROLE;
        }
    }
    public class CG_SEND_FANKUI_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SEND_FANKUI;
        }
    }
    public class CG_SEND_GUILDMAIL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SEND_GUILDMAIL;
        }
    }
    public class CG_SET_DEATH_PUSH_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SET_DEATH_PUSH;
        }
    }
    public class CG_SKILL_USE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SKILL_USE;
        }
    }
    public class CG_SNS_INVITE_CODE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SNS_INVITE_CODE;
        }
    }
    public class CG_SNS_SHARE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SNS_SHARE;
        }
    }
    public class CG_STORAGEPACK_UNLOCK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_STORAGEPACK_UNLOCK;
        }
    }
    public class CG_SWORDSMAN_LEVELUP_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SWORDSMAN_LEVELUP;
        }
    }
    public class CG_SYNC_POS_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SYNC_POS;
        }
    }
    public class CG_SYSTEMSHOP_BUY_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SYSTEMSHOP_BUY;
        }
    }
    public class CG_SYSTEMSHOP_BUYBACK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SYSTEMSHOP_BUYBACK;
        }
    }
    public class CG_SYSTEMSHOP_SELL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SYSTEMSHOP_SELL;
        }
    }
    public class CG_SYSTEMSHOP_VIEW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_SYSTEMSHOP_VIEW;
        }
    }
    public class CG_TAKEOFF_FASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_TAKEOFF_FASHION;
        }
    }
    public class CG_TAKE_GEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_TAKE_GEM;
        }
    }
    public class CG_TAKE_ITEM_STORAGEPACK_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_TAKE_ITEM_STORAGEPACK;
        }
    }
    public class CG_THROW_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_THROW_ITEM;
        }
    }
    public class CG_UNCALL_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNCALL_FELLOW;
        }
    }
    public class CG_UNEQUIP_FELLOW_SKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNEQUIP_FELLOW_SKILL;
        }
    }
    public class CG_UNEQUIP_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNEQUIP_ITEM;
        }
    }
    public class CG_UNEQUIP_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNEQUIP_SWORDSMAN;
        }
    }
    public class CG_UNLOCK_FELLOW_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNLOCK_FELLOW;
        }
    }
    public class CG_UNLOCK_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_UNLOCK_SWORDSMAN;
        }
    }
    public class CG_USER_BEHAVIOR_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_USER_BEHAVIOR;
        }
    }
    public class CG_USE_ITEM_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_USE_ITEM;
        }
    }
    public class CG_USE_LIVINGSKILL_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_USE_LIVINGSKILL;
        }
    }
    public class CG_VISIT_SWORDSMAN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_VISIT_SWORDSMAN;
        }
    }
    public class CG_WEAR_FASHION_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_WEAR_FASHION;
        }
    }
    public class CG_WORLDBOSS_CHALLENGE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_WORLDBOSS_CHALLENGE;
        }
    }
    public class CG_WORLDBOSS_CHALL_RESPONSE_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_WORLDBOSS_CHALL_RESPONSE;
        }
    }
    public class CG_WORLDBOSS_JOIN_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_WORLDBOSS_JOIN;
        }
    }
    public class CG_WORLDBOSS_TEAMLIST_REQ_PF : PacketFactory
    {
        public MessageID GetPacketID()
        {
            return MessageID.PACKET_CG_WORLDBOSS_TEAMLIST_REQ;
        }
    }
}
