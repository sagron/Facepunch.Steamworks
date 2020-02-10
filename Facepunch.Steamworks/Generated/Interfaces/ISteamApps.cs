using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamApps : SteamInterface
	{
		public override void InitInternals()
		{
		}
		internal override void Shutdown()
		{
			base.Shutdown();
			
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribed")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsSubscribed( IntPtr self );
		
		#endregion
		internal bool BIsSubscribed()
		{
			var returnValue = _BIsSubscribed( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsLowViolence")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsLowViolence( IntPtr self );
		
		#endregion
		internal bool BIsLowViolence()
		{
			var returnValue = _BIsLowViolence( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsCybercafe")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsCybercafe( IntPtr self );
		
		#endregion
		internal bool BIsCybercafe()
		{
			var returnValue = _BIsCybercafe( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsVACBanned")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsVACBanned( IntPtr self );
		
		#endregion
		internal bool BIsVACBanned()
		{
			var returnValue = _BIsVACBanned( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetCurrentGameLanguage")]
		private static extern Utf8StringPointer _GetCurrentGameLanguage( IntPtr self );
		
		#endregion
		internal string GetCurrentGameLanguage()
		{
			var returnValue = _GetCurrentGameLanguage( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAvailableGameLanguages")]
		private static extern Utf8StringPointer _GetAvailableGameLanguages( IntPtr self );
		
		#endregion
		internal string GetAvailableGameLanguages()
		{
			var returnValue = _GetAvailableGameLanguages( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedApp")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsSubscribedApp( IntPtr self, AppId appID );
		
		#endregion
		internal bool BIsSubscribedApp( AppId appID )
		{
			var returnValue = _BIsSubscribedApp( Self, appID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsDlcInstalled")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsDlcInstalled( IntPtr self, AppId appID );
		
		#endregion
		internal bool BIsDlcInstalled( AppId appID )
		{
			var returnValue = _BIsDlcInstalled( Self, appID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime")]
		private static extern uint _GetEarliestPurchaseUnixTime( IntPtr self, AppId nAppID );
		
		#endregion
		internal uint GetEarliestPurchaseUnixTime( AppId nAppID )
		{
			var returnValue = _GetEarliestPurchaseUnixTime( Self, nAppID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsSubscribedFromFreeWeekend( IntPtr self );
		
		#endregion
		internal bool BIsSubscribedFromFreeWeekend()
		{
			var returnValue = _BIsSubscribedFromFreeWeekend( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetDLCCount")]
		private static extern int _GetDLCCount( IntPtr self );
		
		#endregion
		internal int GetDLCCount()
		{
			var returnValue = _GetDLCCount( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BGetDLCDataByIndex")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BGetDLCDataByIndex( IntPtr self, int iDLC, ref AppId pAppID, [MarshalAs( UnmanagedType.U1 )] ref bool pbAvailable, IntPtr pchName, int cchNameBufferSize );
		
		#endregion
		internal bool BGetDLCDataByIndex( int iDLC, ref AppId pAppID, [MarshalAs( UnmanagedType.U1 )] ref bool pbAvailable, out string pchName )
		{
			IntPtr mempchName = Helpers.TakeMemory();
			var returnValue = _BGetDLCDataByIndex( Self, iDLC, ref pAppID, ref pbAvailable, mempchName, (1024 * 32) );
			pchName = Helpers.MemoryToString( mempchName );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_InstallDLC")]
		private static extern void _InstallDLC( IntPtr self, AppId nAppID );
		
		#endregion
		internal void InstallDLC( AppId nAppID )
		{
			_InstallDLC( Self, nAppID );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_UninstallDLC")]
		private static extern void _UninstallDLC( IntPtr self, AppId nAppID );
		
		#endregion
		internal void UninstallDLC( AppId nAppID )
		{
			_UninstallDLC( Self, nAppID );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey")]
		private static extern void _RequestAppProofOfPurchaseKey( IntPtr self, AppId nAppID );
		
		#endregion
		internal void RequestAppProofOfPurchaseKey( AppId nAppID )
		{
			_RequestAppProofOfPurchaseKey( Self, nAppID );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetCurrentBetaName")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetCurrentBetaName( IntPtr self, IntPtr pchName, int cchNameBufferSize );
		
		#endregion
		internal bool GetCurrentBetaName( out string pchName )
		{
			IntPtr mempchName = Helpers.TakeMemory();
			var returnValue = _GetCurrentBetaName( Self, mempchName, (1024 * 32) );
			pchName = Helpers.MemoryToString( mempchName );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_MarkContentCorrupt")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _MarkContentCorrupt( IntPtr self, [MarshalAs( UnmanagedType.U1 )] bool bMissingFilesOnly );
		
		#endregion
		internal bool MarkContentCorrupt( [MarshalAs( UnmanagedType.U1 )] bool bMissingFilesOnly )
		{
			var returnValue = _MarkContentCorrupt( Self, bMissingFilesOnly );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetInstalledDepots")]
		private static extern uint _GetInstalledDepots( IntPtr self, AppId appID, [In,Out] DepotId_t[]  pvecDepots, uint cMaxDepots );
		
		#endregion
		internal uint GetInstalledDepots( AppId appID, [In,Out] DepotId_t[]  pvecDepots, uint cMaxDepots )
		{
			var returnValue = _GetInstalledDepots( Self, appID, pvecDepots, cMaxDepots );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppInstallDir")]
		private static extern uint _GetAppInstallDir( IntPtr self, AppId appID, IntPtr pchFolder, uint cchFolderBufferSize );
		
		#endregion
		internal uint GetAppInstallDir( AppId appID, out string pchFolder )
		{
			IntPtr mempchFolder = Helpers.TakeMemory();
			var returnValue = _GetAppInstallDir( Self, appID, mempchFolder, (1024 * 32) );
			pchFolder = Helpers.MemoryToString( mempchFolder );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsAppInstalled")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsAppInstalled( IntPtr self, AppId appID );
		
		#endregion
		internal bool BIsAppInstalled( AppId appID )
		{
			var returnValue = _BIsAppInstalled( Self, appID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppOwner")]
		private static extern SteamId _GetAppOwner( IntPtr self );
		
		#endregion
		internal SteamId GetAppOwner()
		{
			var returnValue = _GetAppOwner( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetLaunchQueryParam")]
		private static extern Utf8StringPointer _GetLaunchQueryParam( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey );
		
		#endregion
		internal string GetLaunchQueryParam( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey )
		{
			var returnValue = _GetLaunchQueryParam( Self, pchKey );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetDlcDownloadProgress")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetDlcDownloadProgress( IntPtr self, AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal );
		
		#endregion
		internal bool GetDlcDownloadProgress( AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal )
		{
			var returnValue = _GetDlcDownloadProgress( Self, nAppID, ref punBytesDownloaded, ref punBytesTotal );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppBuildId")]
		private static extern int _GetAppBuildId( IntPtr self );
		
		#endregion
		internal int GetAppBuildId()
		{
			var returnValue = _GetAppBuildId( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys")]
		private static extern void _RequestAllProofOfPurchaseKeys( IntPtr self );
		
		#endregion
		internal void RequestAllProofOfPurchaseKeys()
		{
			_RequestAllProofOfPurchaseKeys( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetFileDetails")]
		private static extern SteamAPICall_t _GetFileDetails( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszFileName );
		
		#endregion
		internal CallbackResult GetFileDetails( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszFileName )
		{
			var returnValue = _GetFileDetails( Self, pszFileName );
			return new CallbackResult( returnValue );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetLaunchCommandLine")]
		private static extern int _GetLaunchCommandLine( IntPtr self, IntPtr pszCommandLine, int cubCommandLine );
		
		#endregion
		internal int GetLaunchCommandLine( out string pszCommandLine )
		{
			IntPtr mempszCommandLine = Helpers.TakeMemory();
			var returnValue = _GetLaunchCommandLine( Self, mempszCommandLine, (1024 * 32) );
			pszCommandLine = Helpers.MemoryToString( mempszCommandLine );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFamilySharing")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BIsSubscribedFromFamilySharing( IntPtr self );
		
		#endregion
		internal bool BIsSubscribedFromFamilySharing()
		{
			var returnValue = _BIsSubscribedFromFamilySharing( Self );
			return returnValue;
		}
		
	}
}
