// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RollingLogFile.cs" company="Hämmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   Defines the RollingLogFile type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.AmazonS3
{
    using System;

    /// <summary>   A class that represents a rolling log file internally. </summary>
    public class RollingLogFile
    {
        /// <summary>   Initializes a new instance of the <see cref="RollingLogFile" /> class. </summary>
        /// <param name="filename">         The filename. </param>
        /// <param name="dateTime">         The date time. </param>
        /// <param name="sequenceNumber">   The sequence number. </param>
        public RollingLogFile(string filename, DateTime? dateTime, int? sequenceNumber)
        {
            this.Filename = filename;
            this.DateTime = dateTime;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>   Gets the date time. </summary>
        public DateTime? DateTime { get; }

        /// <summary>   Gets the filename. </summary>
        public string Filename { get; }

        /// <summary>   Gets the sequence number. </summary>
        public int? SequenceNumber { get; }
    }
}