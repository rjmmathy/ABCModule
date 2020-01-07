using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxPRM.ShellService.Models
{
    public class TradePreRegistration : Device
    {
        public Company REG_Company { get; set; }
        public CompanyAddress REG_CompanyAddress { get; set; }
        public IList<CompanyService> REG_CompanyService { get; set; }
        //public IList<CompanyHours> REG_CompanyHours { get; set; }
        public CompanyStatus REG_CompanyStatus { get; set; }
        public BankDetail REG_Bank { get; set; }
        public PANDetail REG_PAN { get; set; }
        public DrivingLicense REG_DrivingLicense { get; set; }
        public Voter REG_VoterID { get; set; }
        public CompanyWorkHours REG_CompanyWorkHours { get; set; }
        public Member REG_Member { get; set; }
        public string AuthToken { get; set; }
        public int? CountryCode { get; set; }
        public string MobileNumber { get; set; }
        public string OTP { get; set; }
        public bool TermCondition { get; set; }
        public bool BankInfoSharing { get; set; }
        public IList<MechanicList> MechanicList { get; set; }
        public ImageDetails WorkShopImageDetails { get; set; }
        public ImageDetails PersonalImageDetails { get; set; }
        public string Remarks { get; set; }
        public string LeadSource { get; set; }

        public string IDProofType { get; set; }
    }
    public class BankDetails
    {
        public BankDetail REG_Bank { get; set; }
        public PANDetail REG_PAN { get; set; }
        public DrivingLicense REG_DrivingLicense { get; set; }
        public Voter REG_VoterID { get; set; }
        public string IDProofType { get; set; }
        public bool BankInfoSharing { get; set; }
        


    }
    public class PANDetail
    {
        public string PANCardId { get; set; }
        public string PANCardImage { get; set; }
    }
    public class DrivingLicense
    {
        public string DrivingLicenseID { get; set; }
        public string DrivingLicenseImage { get; set; }
    }
    public class Voter
    {
        public string VoterID { get; set; }
        public string VoterIDImage { get; set; }
    }
    public class BankDetail
    {
        public string BeneficiaryName { get; set; }
        public string BankID { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BankName { get; set; }
    }
    public class Company
    {
        public string LeadID { get; set; }
        public string ProgramID { get; set; }
        public string CompanyID { get; set; }
        public string ReferenceCode { get; set; }

      //  public string ShellWorkshopCode { get; set; }
        
        public string WorkshopQRCode { get; set; }

        public int CompanyType { get; set; }
        public int CompanyCategory { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmailAddress { get; set; }
        public int CompanyTier { get; set; }
        public string ContactNumber { get; set; }
        public string OilChangePerMonth { get; set; }
        public string OilChangePercentage { get; set; }
        public string ShellHelixQty { get; set; }
        public string HalfSyntheticOilChanges { get; set; }
        public string ReferenceCompanyID { get; set; }
        public string CompanySource { get; set; }        
        public int Status { get; set; }
        public string ApprovalStatus { get; set; }
        public string Remarks { get; set; }
        public bool HasDSRManageStaff { get; set; }
    }
    public class CompanyAddress
    {
        public int AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string StreetName { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string PostalCode { get; set; }
        public bool IsActive { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

    }
    public class CompanyService
    {
        public string ServiceID { get; set; }
        public bool IsActive { get; set; }

    }
    public class MechanicList
    {
        public string TradeID { get; set; }
        public string RegistrationID { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Performance { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string Status { get; set; }
        public string StaffType { get; set; }
        public string StaffTypeDesc { get; set; }

    }
    public class CompanyWorkHours
    {
        public string WorkHourStart1 { get; set; }
        public string WorkHourEnd1 { get; set; }
        public string WeekDays1 { get; set; }
        public bool PublicHoliday { get; set; }


        public string WorkHourStart2 { get; set; }
        public string WorkHourEnd2 { get; set; }
        public string WeekDays2 { get; set; }
    }
    //public class CompanyHours
    //{
    //    public int? WeekDay { get; set; }
    //    public bool IsOpen { get; set; }
    //    public double? StartTime { get; set; }
    //    public double? CloseTime { get; set; }

    //}
    public class CompanyStatus
    {
        public int Status { get; set; }

    }
    public class Member
    {
        public string RegistrationID { get; set; }
        public int ProgramID { get; set; }
        public string UserID { get; set; }
        public string DSRCode { get; set; }
        public string LeadID { get; set; }
        public string UserPassword { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProfileType { get; set; }
        public string ProfileTypeDesc { get; set; }
        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        //public int ContactPreference { get; set; }
        public string ContactPreferences { get; set; }
        public int RegistrationType { get; set; }
        public int RegistrationMode { get; set; }
        public string TradeID { get; set; }

        public string CountryName { get; set; }
        public int CountryCode { get; set; }
        public string DOBDay { get; set; }



        public string DOBMonth { get; set; }
        public int? RegistrationRole { get; set; }


    }
    public class Profiling
    {
        public string ID { get; set; }
        public int type { get; set; }

        public IList<ListItemDetail> ProfilingList { get; set; }
    }
    public class ListItemDetail
    {
        public string KeyCode { get; set; }
        public string KeyValue { get; set; }
        //public string DefaultValue { get; set; }
    }
    public class Mechanic
    {

        public string TradeID { get; set; }
        public string RegistrationID { get; set; }
        public string WorkshopTradeID { get; set; }
        public int? CountryCode { get; set; }
        public string OTP { get; set; }
        public int ProgramID { get; set; }
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        public int ContactPreference { get; set; }
        public string ContactPreferences { get; set; }

        public int RegistrationStatus { get; set; }

        public string WorkshopQRCode { get; set; }


        public int TermCondition { get; set; }
        public string DOBDay { get; set; }

        public string FAShareCode { get; set; }

        public string DOBMonth { get; set; }
        public string Remarks { get; set; }

        public int? EnableCustomerRedemption { get; set; }
        public bool HasUpdateMechanic { get; set; }

        public int? StaffType { get; set; }
        public IList<CompanyService> REG_CompanyService { get; set; }
        public CompanyWorkHours REG_CompanyWorkHours { get; set; }
        public Company REG_Company { get; set; }
        public CompanyAddress REG_CompanyAddress { get; set; }
        public BankDetail REG_Bank { get; set; }
        public PANDetail REG_PAN { get; set; }
        public DrivingLicense REG_DrivingLicense { get; set; }
        public Voter REG_VoterID { get; set; }
    }

    public class ImageDetails
    {
        public string TradeID { get; set; }
        public int PhotoType { get; set; }

        public string[] PhotoFileNames { get; set; }

    }

    public class Transaction
    {
        public string ServiceType { get; set; }
        public Double EarnedPoints { get; set; }
        public Double RedeemedPoints { get; set; }
        public Double BalancePoints { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public IList<TransactionHistory> TransactionHistory { get; set; }
    }

    public class CashTransaction
    {
        public string Status { get; set; }
        public string ServiceType { get; set; }
        public string TotalEarning { get; set; }
        public string TotalRemitted { get; set; }
        public string CurrentEarning { get; set; }
        public string Target { get; set; }
        public string AsofDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public IList<CashTransactionHistory> TransactionHistory { get; set; }
    }
    public struct CashTransactionHistory
    {

        public string Description { get; set; }
        public string Remarks { get; set; }
        public string TransactionDate { get; set; }
        public string Amount { get; set; }
        public int TypeColor { get; set; }
    }
    public struct TransactionHistory
    {

        public string Description { get; set; }
        public string TransactionDate { get; set; }
        public decimal Points { get; set; }
        public int TypeColor { get; set; }
    }
    public class PushNotificationInfo
    {
        public bool PushSatus { get; set; }
    }
        public class PushMessageList
    {
        public IList<PushMessage> PushMessages { get; set; }
    }
        public class PushMessage
    {
        public string PushID { get; set; }
        public string Header { get; set; }
        public string ShortDescription { get; set; }
        
        public string Message { get; set; }
        public bool ReadStatus { get; set; }
        public string ReadDate { get; set; }

        public string PushType { get; set; }
        public string ReferenceKey { get; set; }
        public string ReferenceValue { get; set; }

    }
    public class PushMessageToDel
    {
        public string PushID { get; set; }
    }
    public class PushMessageToDelList
    {
        public List<PushMessageToDel> list { get; set; }
    }
}