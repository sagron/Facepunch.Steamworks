using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamUser : SteamInterface
	{
		public override void InitInternals()
		{
		}
		internal override void Shutdown()
		{
			base.Shutdown();
			
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetHSteamUser")]
		private static extern HSteamUser _GetHSteamUser( IntPtr self );
		
		#endregion
		internal HSteamUser GetHSteamUser()
		{
			var returnValue = _GetHSteamUser( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BLoggedOn")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BLoggedOn( IntPtr self );
		
		#endregion
		internal bool BLoggedOn()
		{
			var returnValue = _BLoggedOn( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetSteamID")]
		private static extern SteamId _GetSteamID( IntPtr self );
		
		#endregion
		internal SteamId GetSteamID()
		{
			var returnValue = _GetSteamID( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection")]
		private static extern int _InitiateGameConnection( IntPtr self, IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs( UnmanagedType.U1 )] bool bSecure );
		
		#endregion
		internal int InitiateGameConnection( IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs( UnmanagedType.U1 )] bool bSecure )
		{
			var returnValue = _InitiateGameConnection( Self, pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection")]
		private static extern void _TerminateGameConnection( IntPtr self, uint unIPServer, ushort usPortServer );
		
		#endregion
		internal void TerminateGameConnection( uint unIPServer, ushort usPortServer )
		{
			_TerminateGameConnection( Self, unIPServer, usPortServer );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_TrackAppUsageEvent")]
		private static extern void _TrackAppUsageEvent( IntPtr self, GameId gameID, int eAppUsageEvent, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchExtraInfo );
		
		#endregion
		internal void TrackAppUsageEvent( GameId gameID, int eAppUsageEvent, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchExtraInfo )
		{
			_TrackAppUsageEvent( Self, gameID, eAppUsageEvent, pchExtraInfo );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetUserDataFolder")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetUserDataFolder( IntPtr self, IntPtr pchBuffer, int cubBuffer );
		
		#endregion
		internal bool GetUserDataFolder( out string pchBuffer )
		{
			IntPtr mempchBuffer = Helpers.TakeMemory();
			var returnValue = _GetUserDataFolder( Self, mempchBuffer, (1024 * 32) );
			pchBuffer = Helpers.MemoryToString( mempchBuffer );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_StartVoiceRecording")]
		private static extern void _StartVoiceRecording( IntPtr self );
		
		#endregion
		internal void StartVoiceRecording()
		{
			_StartVoiceRecording( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_StopVoiceRecording")]
		private static extern void _StopVoiceRecording( IntPtr self );
		
		#endregion
		internal void StopVoiceRecording()
		{
			_StopVoiceRecording( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetAvailableVoice")]
		private static extern VoiceResult _GetAvailableVoice( IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated );
		
		#endregion
		internal VoiceResult GetAvailableVoice( ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated )
		{
			var returnValue = _GetAvailableVoice( Self, ref pcbCompressed, ref pcbUncompressed_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetVoice")]
		private static extern VoiceResult _GetVoice( IntPtr self, [MarshalAs( UnmanagedType.U1 )] bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, [MarshalAs( UnmanagedType.U1 )] bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated );
		
		#endregion
		internal VoiceResult GetVoice( [MarshalAs( UnmanagedType.U1 )] bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, [MarshalAs( UnmanagedType.U1 )] bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated )
		{
			var returnValue = _GetVoice( Self, bWantCompressed, pDestBuffer, cbDestBufferSize, ref nBytesWritten, bWantUncompressed_Deprecated, pUncompressedDestBuffer_Deprecated, cbUncompressedDestBufferSize_Deprecated, ref nUncompressBytesWritten_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_DecompressVoice")]
		private static extern VoiceResult _DecompressVoice( IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate );
		
		#endregion
		internal VoiceResult DecompressVoice( IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate )
		{
			var returnValue = _DecompressVoice( Self, pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, ref nBytesWritten, nDesiredSampleRate );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetVoiceOptimalSampleRate")]
		private static extern uint _GetVoiceOptimalSampleRate( IntPtr self );
		
		#endregion
		internal uint GetVoiceOptimalSampleRate()
		{
			var returnValue = _GetVoiceOptimalSampleRate( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetAuthSessionTicket")]
		private static extern HAuthTicket _GetAuthSessionTicket( IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket );
		
		#endregion
		internal HAuthTicket GetAuthSessionTicket( IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket )
		{
			var returnValue = _GetAuthSessionTicket( Self, pTicket, cbMaxTicket, ref pcbTicket );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BeginAuthSession")]
		private static extern BeginAuthResult _BeginAuthSession( IntPtr self, IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID );
		
		#endregion
		internal BeginAuthResult BeginAuthSession( IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID )
		{
			var returnValue = _BeginAuthSession( Self, pAuthTicket, cbAuthTicket, steamID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_EndAuthSession")]
		private static extern void _EndAuthSession( IntPtr self, SteamId steamID );
		
		#endregion
		internal void EndAuthSession( SteamId steamID )
		{
			_EndAuthSession( Self, steamID );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_CancelAuthTicket")]
		private static extern void _CancelAuthTicket( IntPtr self, HAuthTicket hAuthTicket );
		
		#endregion
		internal void CancelAuthTicket( HAuthTicket hAuthTicket )
		{
			_CancelAuthTicket( Self, hAuthTicket );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_UserHasLicenseForApp")]
		private static extern UserHasLicenseForAppResult _UserHasLicenseForApp( IntPtr self, SteamId steamID, AppId appID );
		
		#endregion
		internal UserHasLicenseForAppResult UserHasLicenseForApp( SteamId steamID, AppId appID )
		{
			var returnValue = _UserHasLicenseForApp( Self, steamID, appID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BIsBehindNAT")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsBehindNAT( IntPtr self );
		
		#endregion
		internal bool BIsBehindNAT()
		{
			var returnValue = _BIsBehindNAT( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_AdvertiseGame")]
		private static extern void _AdvertiseGame( IntPtr self, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer );
		
		#endregion
		internal void AdvertiseGame( SteamId steamIDGameServer, uint unIPServer, ushort usPortServer )
		{
			_AdvertiseGame( Self, steamIDGameServer, unIPServer, usPortServer );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_RequestEncryptedAppTicket")]
		private static extern SteamAPICall_t _RequestEncryptedAppTicket( IntPtr self, IntPtr pDataToInclude, int cbDataToInclude );
		
		#endregion
		internal CallbackResult RequestEncryptedAppTicket( IntPtr pDataToInclude, int cbDataToInclude )
		{
			var returnValue = _RequestEncryptedAppTicket( Self, pDataToInclude, cbDataToInclude );
			return new CallbackResult( returnValue );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetEncryptedAppTicket")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetEncryptedAppTicket( IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket );
		
		#endregion
		internal bool GetEncryptedAppTicket( IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket )
		{
			var returnValue = _GetEncryptedAppTicket( Self, pTicket, cbMaxTicket, ref pcbTicket );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetGameBadgeLevel")]
		private static extern int _GetGameBadgeLevel( IntPtr self, int nSeries, [MarshalAs( UnmanagedType.U1 )] bool bFoil );
		
		#endregion
		internal int GetGameBadgeLevel( int nSeries, [MarshalAs( UnmanagedType.U1 )] bool bFoil )
		{
			var returnValue = _GetGameBadgeLevel( Self, nSeries, bFoil );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetPlayerSteamLevel")]
		private static extern int _GetPlayerSteamLevel( IntPtr self );
		
		#endregion
		internal int GetPlayerSteamLevel()
		{
			var returnValue = _GetPlayerSteamLevel( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_RequestStoreAuthURL")]
		private static extern SteamAPICall_t _RequestStoreAuthURL( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchRedirectURL );
		
		#endregion
		internal CallbackResult RequestStoreAuthURL( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchRedirectURL )
		{
			var returnValue = _RequestStoreAuthURL( Self, pchRedirectURL );
			return new CallbackResult( returnValue );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneVerified")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsPhoneVerified( IntPtr self );
		
		#endregion
		internal bool BIsPhoneVerified()
		{
			var returnValue = _BIsPhoneVerified( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BIsTwoFactorEnabled")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsTwoFactorEnabled( IntPtr self );
		
		#endregion
		internal bool BIsTwoFactorEnabled()
		{
			var returnValue = _BIsTwoFactorEnabled( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneIdentifying")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsPhoneIdentifying( IntPtr self );
		
		#endregion
		internal bool BIsPhoneIdentifying()
		{
			var returnValue = _BIsPhoneIdentifying( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneRequiringVerification")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsPhoneRequiringVerification( IntPtr self );
		
		#endregion
		internal bool BIsPhoneRequiringVerification()
		{
			var returnValue = _BIsPhoneRequiringVerification( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUser_GetMarketEligibility")]
		private static extern SteamAPICall_t _GetMarketEligibility( IntPtr self );
		
		#endregion
		internal CallbackResult GetMarketEligibility()
		{
			var returnValue = _GetMarketEligibility( Self );
			return new CallbackResult( returnValue );
		}
		
	}
}
