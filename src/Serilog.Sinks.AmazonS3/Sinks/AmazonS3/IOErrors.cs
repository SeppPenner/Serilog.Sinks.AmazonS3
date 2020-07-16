﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOErrors.cs" company="Hämmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   Defines the IOErrors type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.AmazonS3
{
    using System.IO;

    /// <summary>   A class that simplifies the use of some I/O errors. </summary>
    public static class IoErrors
    {
        /// <summary>   Determines whether the file is locked or not. </summary>
        /// <param name="ex">   The <see cref="IOException" /> to check. </param>
        /// <returns>   <c>true</c> if the file is locked; otherwise, <c>false</c>. </returns>
        public static bool IsLockedFile(IOException ex)
        {
#if HRESULTS
            var errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(ex) & ((1 << 16) - 1);
            return errorCode == 32 || errorCode == 33;
#else
            return true;
#endif
        }
    }
}