using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NBitcoin;
using NBXplorer.Models;

namespace BtcTransmuter.Extension.NBXplorer.Triggers.NBXplorerBalance
{
    public class NBXplorerBalanceTriggerParameters
    {
        [Display(Name = "Crypto")]
        [Required] public string CryptoCode { get; set; }
        public string Address { get; set; }
        [Display(Name = "Derivation Strategy")]
        public string DerivationStrategy { get; set; }
        [Display(Name = "Balance")]
        public decimal BalanceValue { get; set; }

        public MoneyUnit BalanceMoneyUnit { get; set; } = MoneyUnit.BTC;
        public BalanceComparer BalanceComparer { get; set; }

        public Money Balance => Money.FromUnit(BalanceValue, BalanceMoneyUnit);
    }
}