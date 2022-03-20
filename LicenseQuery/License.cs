namespace LicenseQuery
{
	public class License
	{
		#region Properties

		public string CustomerID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MailAddr1 { get; set; }
		public string MailAddr2 { get; set; }
		public string MailAddr3 { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string EMail { get; set; }
		public string Voice { get; set; }
		public string Fax { get; set; }
		public string CustomerEnteredBy { get; set; }
		public string CustomerEnteredDate { get; set; }
		public string CustomerModifiedBy { get; set; }
		public string CustomerModifiedDate { get; set; }
		public string UnRegistered { get; set; }
		public string InvalidAddress { get; set; }
		public string ExcludeFromAll { get; set; }
		public string Taxable { get; set; }
		public string IsDistributor { get; set; }
		public string LastLogin { get; set; }
		public string LastLoginIP { get; set; }
		public string Notes { get; set; }
		public string TempEMailFlag { get; set; }
		public string Enabled { get; set; }
		public string AuthorIDOwner { get; set; }
		public string OfferProduct { get; set; }
		public string OfferPartners { get; set; }
		public string ExternalReference { get; set; }
		public string EuropeanUnionVATNumber { get; set; }
		public string AuthorID { get; set; }
		public string AuthorCompanyName { get; set; }
		public string LicenseID { get; set; }
		public string ActivationPassword { get; set; }
		public string Status { get; set; }
		public string ReplacedBy { get; set; }
		public string UpgradedTo { get; set; }
		public string ReturnedDate { get; set; }
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public string ProdOptionID { get; set; }
		public string OptionName { get; set; }
		public string InvoiceNo { get; set; }
		public string UnlocksLeft { get; set; }
		public string OutsideThresLeft { get; set; }
		public string QOrdered { get; set; }
		public string LicenseCounter { get; set; }
		public string UnitPrice { get; set; }
		public string AuthorSerialNum { get; set; }
		public string AuthorSerialNumTxt { get; set; }
		public string CurrentVersion { get; set; }
		public string LicenseUpdate { get; set; }
		public string ExpirationDate { get; set; }
		public string DistributorID { get; set; }
		public string LicenseEnteredBy { get; set; }
		public string LicenseEnteredDate { get; set; }
		public string LicenseModifiedBy { get; set; }
		public string LicenseModifiedDate { get; set; }
		public string LicenseNotes { get; set; }
		public string LFExpireType { get; set; }
		public string LFUdefChar1 { get; set; }
		public string LFUdefChar2 { get; set; }
		public string LFUdefChar3 { get; set; }
		public string LFUdefChar4 { get; set; }
		public string LFUdefChar5 { get; set; }
		public string LFUdefChar6 { get; set; }
		public string LFUdefChar7 { get; set; }
		public string LFUdefChar8 { get; set; }
		public string LFUdefChar9 { get; set; }
		public string LFUdefChar10 { get; set; }
		public string LFExpireDateSoft { get; set; }
		public string LFExpireDateHard { get; set; }
		public string LFLastUsedDate { get; set; }
		public string LFLastUsedTime { get; set; }
		public string LFUdefDate1 { get; set; }
		public string LFUdefDate2 { get; set; }
		public string LFUdefDate3 { get; set; }
		public string LFUdefDate4 { get; set; }
		public string LFUdefDate5 { get; set; }
		public string LFExpireCount { get; set; }
		public string LFExpireAllowed { get; set; }
		public string LFLANCount { get; set; }
		public string LFLANAllowed { get; set; }
		public string LFInstallCount { get; set; }
		public string LFInstallAllowed { get; set; }
		public string LFUdefNum1 { get; set; }
		public string LFUdefNum2 { get; set; }
		public string LFUdefNum3 { get; set; }
		public string LFUdefNum4 { get; set; }
		public string LFUdefNum5 { get; set; }
		public string LastUpdateDate { get; set; }
		public string LastUpdateStatus { get; set; }
		public string CouponType { get; set; }
		public string CouponCode { get; set; }
		public string CouponClaimed { get; set; }
		public string CouponAmount { get; set; }
		public string CouponPaid { get; set; }
		public string CouponDeclinedReason { get; set; }
		public string LFUdefFloat1 { get; set; }
		public string LFUdefFloat2 { get; set; }
		public string LFUdefFloat3 { get; set; }
		public string LFUdefFloat4 { get; set; }
		public string LFUdefFloat5 { get; set; }
		public string PriorityCode { get; set; }
		public string SalePrice { get; set; }
		public string BundledProdOptionID { get; set; }
		public string PriorityCodeDiscountAmount { get; set; }
		public string UpsellProdOptionID { get; set; }
		public string ComboDiscountAmount { get; set; }
		public string PaymentPlanInstanceID { get; set; }
		public string ReturnReasonID { get; set; }
		public string BundleDiscountAmount { get; set; }
		public string CustomData { get; set; }
		public string DeactivationsLeft { get; set; }
		public string AllowedActivationIPs { get; set; }
		public string LicenseCustomData { get; set; }
		public string OriginalLicenseID { get; set; }
		public string ReasonForChange { get; set; }
		public string LicenseLicenseeName { get; set; }
		public string LicenseLicenseeEmail { get; set; }

		#endregion

		public string this[string propertyName]
		{
			get { return GetProperty(propertyName); }
			set { SetProperty(propertyName, value); }
		}

		public static bool HasProperty(string propertyName)
		{
			return typeof(License).GetProperty(propertyName) != null;
		}

		public string GetProperty(string propertyName)
		{
			return HasProperty(propertyName) ? typeof(License).GetProperty(propertyName).GetValue(this).ToString() : "";
		}

		public void SetProperty(string propertyName, string newValue)
		{
			if (HasProperty(propertyName))
				typeof(License).GetProperty(propertyName).SetValue(this, newValue);
		}

		public override string ToString()
		{
			return (
				"LicenseID: " + LicenseID + ", " +
				"CustomerID: " + CustomerID + ", " +
				"CompanyName: " + CompanyName + ", " +
				"ContactName: " + ContactName + ", " +
				"Email: " + EMail + ", " +
				"Enabled: " + Enabled
			);
		}
	}
}
