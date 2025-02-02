using System;

public enum ApolloVoiceErr
{
	APOLLO_VOICE_SUCC,
	APOLLO_VOICE_NONE,
	APOLLO_VOICE_UNKNOWN = 3,
	APOLLO_VOICE_STATE_ERR,
	APOLLO_VOICE_CREATE_ERR,
	APOLLO_VOICE_IN_ROOM,
	APOLLO_VOICE_PATH_NULL,
	APOLLO_VOICE_PATH_ACCESS,
	APOLLO_VOICE_UPLOAD,
	APOLLO_VOICE_DOWNLOAD,
	APOLLO_VOICE_HTTP_BUSY,
	APOLLO_VOICE_RECORDING,
	APOLLO_VOICE_OPENID,
	APOLLO_VOICE_AUDIENCE,
	APOLLO_VOICE_JOIN_TIMEOUT = 50,
	APOLLO_VOICE_JOIN_SUCC,
	APOLLO_VOICE_JOIN_NOTIN,
	APOLLO_VOICE_JOIN_FAIL,
	APOLLO_VOICE_JOIN_URL,
	APOLLO_VOICE_NET_TIMEOUT = 121,
	APOLLO_VOICE_PERMISSION_MIC = 200,
	APOLLO_VOICE_SPEAKER,
	APOLLO_VOICE_EMPTY_AUTHKEY,
	APOLLO_VOICE_EMPTY_FILE,
	APOLLO_VOICE_EMPTY_OPENID,
	APOLLO_VOICE_EMPTY_FILE_ID,
	APOLLO_VOICE_TVE_CREATE = 300,
	APOLLO_VOICE_TVE_NULL,
	APOLLO_VOICE_TVE_STOP,
	APOLLO_VOICE_TVE_INIT,
	APOLLO_VOICE_TVE_START,
	APOLLO_VOICE_TVE_CREATE_NTFY,
	APOLLO_VOICE_TVE_FILEKEY_NULL,
	APOLLO_VOICE_TVE_BUF_NULL,
	APOLLO_VOICE_TVE_PLAYSOUND,
	APOLLO_VOICE_TVE_FORBID,
	APOLLO_VOICE_CHANGE_MODE,
	APOLLO_VOICE_CDNV_CREATE = 400,
	APOLLO_VOICE_CDNV_NULL,
	APOLLO_VOICE_CDNV_QUIT,
	APOLLO_VOICE_CDNV_CREATE_NTFY,
	APOLLO_VOICE_HTTP_ERROR_DATA,
	APOLLO_VOICE_HTTP_BADPARAM,
	APOLLO_VOICE_PARAM_NULL,
	APOLLO_VOICE_STOP_PLAY_FILE,
	APOLLO_VOICE_CDNV_URL,
	APOLLO_VOICE_PAUSED,
	APOLLO_VOICE_WRONG_MODE,
	APOLLO_VOICE_RECORD_FILE_FAILED,
	APOLLO_VOICE_CLOSE_MIC,
	APOLLO_VOICE_FILE_OPERATION,
	APOLLO_VOICE_HTTP_INIT,
	APOLLO_VOICE_HTTP_GET
}
