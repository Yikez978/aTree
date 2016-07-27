// SIDInfo wrapper, Joseph E. Mills, July 2012. jmills@josephemills.com
// Last Revision August 2013
// 
// This is a simple class which imports and relates Win32 functions that you can use to query and
// manipulate security principals and other such objects. Use, redistribute, butcher as you please,
// But please give credit where credit is due. 
using System.Runtime.InteropServices;
using System;
// 

namespace aTree
{

    // '' <summary>
    // '' A wrapper class for retrieving and retaining information relating to an account's SID, domain, and SAMID
    // '' </summary>
    // '' <remarks></remarks>
    public class SIDInfo
    {

        // Indicates a SID for a computer.
        // '' <summary>
        // ''The LookupAccountSid function accepts a security identifier (SID) as input. It retrieves the name of the account for this SID and the name of the first domain on which this SID is found.
        // '' </summary>
        // '' <param name="SystemName">The name of the system or domain controller to check. Can be left blank to initialize translation.</param>
        // '' <param name="SID">The SID to check for.</param>
        // '' <param name="AccountNamePointer">A pointer that will reference the account name of the SID.</param>
        // '' <param name="AccountNameBufferSize">An integer that specifies how long the account name buffer must be.</param>
        // '' <param name="DomainNamePointer">A pointer that will reference the domain of the SID.</param>
        // '' <param name="DomainNameBufferSize">An integer that specifies how long the domain name buffer must be.</param>
        // '' <param name="SIDType">The type of SID.</param>
        // '' <returns>Returns an integer indicating 0 for failure or non-zero for success.</returns>
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountSidA")]
        static extern int LookupAccountSid(string SystemName, int SID, IntPtr AccountNamePointer, ref int AccountNameBufferSize, IntPtr DomainNamePointer, ref int DomainNameBufferSize, ref int SIDType);

        // '' <summary>
        // '' The LookupAccountName function accepts the name of a system and an account as input. It retrieves a security identifier (SID) for the account and the name of the domain on which the account was found.
        // '' </summary>
        // '' <param name="SystemName">The name of the system or domain controller to check. Can be left blank to initialize translation.</param>
        // '' <param name="AccountName">The account name to look up.</param>
        // '' <param name="SIDPointer">The pointer that will reference the SID of the account.</param>
        // '' <param name="SIDPointerSize">An integer that specifies how long the SID buffer must be.</param>
        // '' <param name="DomainNamePointer">A pointer that will reference the domain of the SID.</param>
        // '' <param name="DomainNameBufferSize">An integer that specifies how long the domain name buffer must be.</param>
        // '' <param name="SIDType"></param>
        // '' <returns>Returns an integer indicating 0 for failure or non-zero for success.</returns>
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountNameA")]
        static extern int LookupAccountName(string SystemName, string AccountName, IntPtr SIDPointer, ref int SIDPointerSize, IntPtr DomainNamePointer, ref int DomainNameBufferSize, ref int SIDType);

        // '' <summary>
        // '' The ConvertSidTostringSid function converts a security identifier (SID) to a string format suitable for display, storage, or transmission.
        // '' </summary>
        // '' <param name="Sid">A pointer to the SID structure to be converted.</param>
        // '' <param name="stringSid">A pointer to a variable that receives a pointer to a null-terminated SID string. To free the returned buffer, call the LocalFree function.
        // ''</param>
        // '' <returns>If the function succeeds, the return value is nonzero.</returns>
        // '' <remarks></remarks>
        [DllImport("advapi32.dll", EntryPoint = "ConvertSidToStringSidA")]
        static extern int ConvertSidToStringSid(IntPtr Sid, ref IntPtr stringSid);

        // '' <summary>
        // '' The ConvertstringSidToSid function converts a string-format security identifier (SID) into a valid, functional SID. You can use this function to retrieve a SID that the ConvertSidTostringSid function converted to string format.
        // '' </summary>
        // '' <param name="stringSid">A pointer to a null-terminated string containing the string-format SID to convert. 
        // '' The SID string can use either the standard S-R-I-S-S& format for SID strings, or the SID string constant 
        // '' format, such as "BA" for built-in administrators. For more information about SID string notation, see 
        // '' SID Components. 
        // ''</param>
        // '' <param name="Sid">A pointer to a variable that receives a pointer to the converted SID. To free the returned buffer, call the LocalFree function.
        // ''</param>
        // '' <returns>If the function succeeds, the return value is nonzero.</returns>
        // '' <remarks></remarks>
        [DllImport("advapi32.dll", EntryPoint = "ConvertStringSidToSidA")]
        static extern bool ConvertStringSidToSid(string stringSid, ref IntPtr Sid);

        // '' <summary>
        // ''   Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        // '' </summary>
        // '' <returns>The return value is the calling thread's last-error code.</returns>
        // '' <remarks></remarks>
        [DllImport("kernel32.dll")]
        static extern int GetLastError();

        // '' <summary>
        // '' Frees the specified local memory object and invalidates its handle.
        // '' </summary>
        // '' <param name="MemHandle">A handle to the local memory object. 
        // '' This handle is returned by either the LocalAlloc or LocalReAlloc function. 
        // '' It is not safe to free memory allocated with GlobalAlloc.
        // '' </param>
        // '' <remarks></remarks>
        [DllImport("kernel32.dll")]
        static extern void LocalFree(int MemHandle);

        public enum IdentityType : int
        {

            SID = 0,

            NTAccount = 1,
        }

        private string _Account;

        private string _Domain;

        private int _SIDUse;

        private string _SID;

        private string _System;

        // '' <summary>
        // '' Gets a string with the name of the account, or SAMID.
        // '' </summary>
        // '' <value></value>
        // '' <returns></returns>
        // '' <remarks></remarks>
        public string Account
        {
            get
            {
                return _Account;
            }
        }

        public string Domain
        {
            get
            {
                return _Domain;
            }
        }

        public int SIDUse
        {
            get
            {
                return _SIDUse;
            }
        }

        public string SID
        {
            get
            {
                return _SID;
            }
        }

        public string System
        {
            get
            {
                return _System;
            }
        }

        // '' <summary>
        // '' Creates a new instance of the SIDInfo class.
        // '' </summary>
        // '' <param name="Identity">A string containing identifying information about the account, SID or NTAccount.</param>
        // '' <param name="SystemName">A string containing the name of the system in which to search for the SID.</param>
        // '' <param name="Type">Specifies the type of data in the Identity parameter. Default is SID.</param>
        // '' <remarks></remarks>
        public SIDInfo(string Identity, string SystemName, IdentityType IdentityType)
        {
            string Account = string.Empty;
            // Warning!!! Optional parameters not supported
            // Warning!!! Optional parameters not supported
            string Domain = string.Empty;
            int SIDUse = 0;
            string SID = string.Empty;
            string System = SystemName;
            if ((IdentityType == IdentityType.SID))
            {
                SID = Identity;
                int Result;
                Result = SIDInfo.GetAccountInfoBySID(Identity, SystemName, ref Account, ref Domain, ref SIDUse);
                if ((Result != 0))
                {
                    throw new ApplicationException(("Unable to get account info by SID, error code: " + Result.ToString()));
                }

            }
            else {
                int Result;
                Result = SIDInfo.GetAccountInfoByName(Identity, SystemName, ref SID, ref Domain, ref SIDUse);
                if ((Result != 0))
                {
                    throw new ApplicationException(("Unable to get account info by name, error code: " + Result.ToString()));
                }

                Result = SIDInfo.GetAccountInfoBySID(SID, SystemName, ref Account, ref  Domain, ref SIDUse);
                if ((Result != 0))
                {
                    throw new ApplicationException(("Unable to get account info by SID, error code: " + Result.ToString()));
                }

            }

            _Account = Account;
            _Domain = Domain;
            _SIDUse = SIDUse;
            _SID = SID;
            _System = SystemName;
        }

        // '' <summary>
        // '' Gets account info using an SID through the LookupAccountSid function.
        // '' </summary>
        // '' <param name="SID">The SID to use as a lookup parameter.</param>
        // '' <param name="System">The system to search for the SID, or blank if the SID is not for a local account.</param>
        // '' <param name="Account">A reference to a string that will contain the Account.</param>
        // '' <param name="Domain">A reference to a string that will contain the Domain.</param>
        // '' <param name="SIDUse">A reference to an integer that will contain the SID type.</param>
        // '' <returns></returns>
        // '' <remarks></remarks>
        public static int GetAccountInfoBySID(string SID, string System, ref string Account, ref string Domain, ref int SIDUse)
        {
            long Result;
            int SIDInteger;
            IntPtr SIDPointer = new IntPtr();
            // Convert the string SID to a byte array. If this returns false, then the function failed, return last error.
            if (!SIDInfo.ConvertStringSidToSid(SID, ref SIDPointer))
            {
                return GetLastError();
            }

            SIDInteger = SIDPointer.ToInt32();
            // The buffer sizes can be adjusted if desired, but the return values will probably never exceed 255.
            // So this is a good, safe value.
            IntPtr AccountNamePointer = new IntPtr();
            int AccountNameBufferSize = 255;
            IntPtr DomainNamePointer = new IntPtr();
            int DomainNameBufferSize = 255;
            int SIDType = 0;
            // Since we're dealing with unmanaged code, we have to allocate memory for these manually.
            AccountNamePointer = Marshal.AllocHGlobal(AccountNameBufferSize);
            DomainNamePointer = Marshal.AllocHGlobal(DomainNameBufferSize);
            // Calling the function, the return value will contain either 0 on failure, or non-zero on success.
            Result = SIDInfo.LookupAccountSid(System, SIDInteger, AccountNamePointer, ref AccountNameBufferSize, DomainNamePointer, ref DomainNameBufferSize, ref SIDType);
            // If the result is zero, it failed. Return the error code.
            if ((Result == 0))
            {
                return GetLastError();
            }

            // Getting the account and domain values from the pointers we sent to LookupAccountSid.
            Account = Marshal.PtrToStringAnsi(AccountNamePointer);
            Domain = Marshal.PtrToStringAnsi(DomainNamePointer);
            SIDUse = SIDType;
            // Free up the memory we used for the operation.
            Marshal.FreeHGlobal(AccountNamePointer);
            Marshal.FreeHGlobal(DomainNamePointer);
            SIDInfo.LocalFree(SIDPointer.ToInt32());
            return 0;
        }

        // '' <summary>
        // '' Gets account info using an account name through the LookupAccountName function.
        // '' </summary>
        // '' <param name="Account">The name to use as a lookup parameter.</param>
        // '' <param name="System">The system to search for the SID, or blank if the account is not a local account.</param>
        // '' <param name="SID">A reference to a string that will contain the SID.</param>
        // '' <param name="Domain">A reference to a string that will contain the Domain.</param>
        // '' <param name="SIDUse">A reference to an integer that will contain the SID type.</param>
        // '' <returns></returns>
        // '' <remarks></remarks>
        public static int GetAccountInfoByName(string Account, string System, ref string SID, ref string Domain, ref int SIDUse)
        {
            int Result;
            // The buffer sizes can be adjusted if desired, but the return values will probably never exceed 255.
            // So this is a good, safe value.
            string AccountName = Account;
            IntPtr SIDPointer = new IntPtr();
            int SIDPointerBufferSize = 255;
            IntPtr DomainNamePointer = new IntPtr();
            int DomainNameBufferSize = 255;
            int Use = 0;
            // Since we're dealing with unmanaged code, we have to allocate memory for these manually.
            SIDPointer = Marshal.AllocHGlobal(SIDPointerBufferSize);
            DomainNamePointer = Marshal.AllocHGlobal(DomainNameBufferSize);
            // Calling the function, the return value will contain either 0 on failure, or non-zero on success.
            Result = SIDInfo.LookupAccountName(System, AccountName, SIDPointer, ref SIDPointerBufferSize, DomainNamePointer, ref DomainNameBufferSize, ref Use);
            // If the result is zero, it failed. Return the error code.
            if ((Result == 0))
            {
                return GetLastError();
            }

            IntPtr SDDLString = new IntPtr();
            // We got the SID in the form of a byte array. So we have to convert this to a string. This function returns
            // non-zero on success.
            Result = SIDInfo.ConvertSidToStringSid(SIDPointer, ref SDDLString);
            if ((Result == 0))
            {
                return GetLastError();
            }

            // Getting the account and domain values from the pointers we sent to LookupAccountName.
            Account = AccountName;
            SID = Marshal.PtrToStringAnsi(SDDLString);
            Domain = Marshal.PtrToStringAnsi(DomainNamePointer);
            SIDUse = Use;
            // Free up the memory we used for the operation.
            Marshal.FreeHGlobal(SIDPointer);
            Marshal.FreeHGlobal(DomainNamePointer);
            SIDInfo.LocalFree(SDDLString.ToInt32());
            return 0;
        }

        public override string ToString()
        {
            string DomainString;

            if (string.IsNullOrEmpty(Domain))
            {
                if (string.IsNullOrEmpty(System))
                {
                    DomainString = string.Empty;
                }
                else
                {
                    DomainString = System;
                }
            }
            else
            {
                DomainString = Domain;
            }

            string AccountString;

            if (string.IsNullOrEmpty(Account))
            {
                AccountString = SID;
            }
            else
            {
                AccountString = Account;
            }

            string ReturnString = string.Empty;

            if (!string.IsNullOrEmpty(DomainString)){
                ReturnString = DomainString + "\\";
            }

            if (string.IsNullOrEmpty(AccountString))
            {
                ReturnString = ReturnString + "<resolution failed>";
            }
            else
            {
                ReturnString = ReturnString + AccountString;
            }

            return ReturnString;

         }

        }
    }
