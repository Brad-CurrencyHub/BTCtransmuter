using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BtcTransmuter.Extension.NBXplorer.Models;

namespace BtcTransmuter.Extension.NBXplorer.Actions.SendTransaction
{
    public class SendTransactionData
    {
        [Display(Name = "Crypto")] [Required] public string CryptoCode { get; set; }
        [Display(Name = "Address")] public string Address { get; set; }

        [Display(Name = "Derivation Strategy")]
        public string DerivationStrategy { get; set; }
        public List<TransactionOutput> Outputs { get; set; } = new List<TransactionOutput>();

        public List<PrivateKeyDetails> PrivateKeys { get; set; } = new List<PrivateKeyDetails>();

        public class TransactionOutput
        {
            [Display(Name = "Destination Address")]
            [Required]
            public string DestinationAddress { get; set; }

            [Display(Name = "Amount")] [Required] public string Amount { get; set; }
            
        
            [Display(Name = "Subtract fees from this output")]
            public bool SubtractFeesFromOutput { get; set; }
        }

        
    }
}