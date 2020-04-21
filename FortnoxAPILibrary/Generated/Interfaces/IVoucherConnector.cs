using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IVoucherConnector : IConnector
	{
        [SearchParameter("filter")]
		Filter.Voucher? FilterBy { get; set; }

        [SearchParameter]
		string CostCenter { get; set; }

        Voucher Create(Voucher voucher);

		Voucher Get(int? id, string seriesId, int? financialYearId);

        EntityCollection<VoucherSubset> Find();

	}
}