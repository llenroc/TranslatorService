﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorService
{
    /// <summary>
    /// The <strong>TranslatorServiceException</strong> class holds information about Exception related to <see cref="TranslatorServiceClient"/>.
    /// </summary>
    /// <seealso cref="TranslatorServiceClient"/>
    public class TranslatorServiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslatorServiceException"/> class using the specified error message.
        /// </summary>
        /// <param name="message">Message that describes the error</param>
        public TranslatorServiceException(string message)
            : base(message)
        {
        }
    }
}
