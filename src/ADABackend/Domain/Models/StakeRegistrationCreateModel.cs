using System;
using System.Collections.Generic;

namespace Cardano.Domain.Models
{
    public partial class StakeRegistrationCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public int CertIndex { get; set; }

        public long TxId { get; set; }

        #endregion

    }
}
