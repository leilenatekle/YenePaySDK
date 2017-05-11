﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenePaySdk
{
    public class PDTRequestModel
    {
        /// <summary>
        /// Gets or sets the type of the request.
        /// </summary>
        /// <value>The type of the request.</value>
        [Required]
        public string RequestType { get; set; }
        /// <summary>
        /// Gets or sets the PDT token.
        /// </summary>
        /// <value>The PDT token.</value>
        [Required]
        public string PdtToken { get; set; }
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>The transaction identifier.</value>
        [Required]
        public Guid TransactionId { get; set; }

        public bool UseSandbox { get; set; }

        public Dictionary<string, string> GetPDTDictionary()
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("RequestType", this.RequestType.ToString());
            keyValues.Add("PdtToken", this.PdtToken.ToString());
            keyValues.Add("TransactionId", this.TransactionId.ToString());
            return keyValues;
        }
    }
}
