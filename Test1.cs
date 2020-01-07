using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxPRM.ShellService.Models
{
    public class MechanicHome
    {
        public MyProfile MyProfile { get; set; }
        public MyPoints MyPoints { get; set; }
        public MyPerformance MyPerformance { get; set; }
        public MyOutletPerformance MyOutletPerformance { get; set; }
        public MySales MySales { get; set; }
		/*Added on : 18-01-2019 -> Begins*/
        public LoyaltyContractPerformance LoyaltyContractPerformance { get; set; }
        /*Lebaran Promotion - Edited*/
        //public CNYPromotion CNYPromotion { get; set; }
        public TradesPromotion TradesPromotion { get; set; }
        /*Lebaran Promotion - Edited*/
        public CVBoosterPromotion CVBoosterPromotion { get; set; }
        public AgriPromotion AgriPromotion { get; set; }
        public HX8Promotion HX8Promotion { get; set; }
        public HomesList HomesPromotion{ get; set; }
    }
    public class MyOutletPerformance
    {
        public string OutletPerfUpdatedOn { get; set; }
        public string CarouselHeader { get; set; }
        public string IconName { get; set; }
        //public int? TotalReferals { get; set; }
        //public int? TotalOilChanges { get; set; }
        //public int? TotalProdScanned { get; set; }
        public string PerformanceKeyOne { get; set; }
        public string PerformanceIconOne { get; set; }
        public int PerformanceValueOne { get; set; }
        public string PerformanceKeyTwo { get; set; }
        public string PerformanceIconTwo { get; set; }
        public string PerformanceIconThree { get; set; }
        public int PerformanceValueTwo { get; set; }
        public string PerformanceKeyThree { get; set; }
        public int PerformanceValueThree { get; set; }
        public bool HasPerformanceViewDetails { get; set; }
    }
    public class Preference
    {
        public int LanguageCode { get; set; }
    }
    public class MyProfile
    {

        public bool HasPendingWorkshopList { get; set; }//anjana for India retail
        public bool HasBtnUpdate { get; set; }//anjana for India retail
        public bool HasBtnDeactivate { get; set; }//anjana for India retail

        public bool QLHasBottleSale { get; set; }//1087
        public bool HasBottleSale { get; set; }//ticket 1087

        public int TermCondition { get; set; }
        public int ChangePassword { get; set; }
        public int RewardsStatus { get; set; }
        public int RedeemOnly { get; set; }
        public int CanInviteTrade { get; set; }

        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string ShareCode { get; set; }
        public int ProfileType { get; set; }

        public string ProfileDesc { get; set; }
        public string Rank { get; set; }
        public string BonusPoint { get; set; }
        public int ProfileCompleteness { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salutation { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ProfileImage { get; set; }
        public string UnReadPushMessage { get; set; }
        public bool HasOrdering { get; set; }
        public bool HasSearchVehicleID { get; set; }
        public bool HasRegisterProductCode { get; set; }
        public bool HasManageMyStaff { get; set; }
        public bool HasRegisterPromoCode { get; set; }
        public bool HasParticipatingProducts { get; set; }
        public bool HasParticipatingShareProducts { get; set; }
        public bool HasParticipatingAllProducts { get; set; }
        public bool HasWorkshopPerformance { get; set; }
        public bool HasCustomerRedemption { get; set; }
        public bool HasCustomerRedemptionDSR { get; set; }
        public bool HasAddNewWorkshop { get; set; }
        public bool CanEditAddress { get; set; }
        public bool CanEditShippingAddress { get; set; }
        public bool EnableCustomerRedemption { get; set; }
        public bool IsEnableSurvey { get; set; }
        public bool ShowSurveyPP { get; set; }
        public bool HasTOPoint { get; set; }
        public bool HasAncillaryOffers { get; set; }
        public string SurveyID { get; set; }
        public bool HasMYPoints { get; set; }
        public bool ShowScanSearchVehicle { get; set; }
        public bool HasRegisterProductCode_V2 { get; set; }
        public bool HasInviteConsumer { get; set; }
        public bool HasMYPerformance { get; set; }
        public bool HasPushNotif { get; set; }
        public List<string> PushNotifList { get; set; }
        /*Objects for Decal codes - Begins*/
        public bool HasTagDecalToWorkshop { get; set; }
        public bool QLHasDecalActivation { get; set; }
        public bool HasDecal { get; set; }
        /*Objects for Decal codes - Ends*/
        /*Objects for Asset  - Begins*/
        public bool HasAsset { get; set; }
        /*Objects for Asset codes - Ends*/
        public bool HasOrdering_V2 { get; set; }
        /*Logic for Flags QuickLinks -> Begins*/
        public bool QLHasOrdering_V2 { get; set; }
        public bool QLHasAsset { get; set; }
        public bool QLHasSearchVehicleID { get; set; }
        public bool QLHasManageWorkshop { get; set; }
        public bool QLHasRegisterProductCode { get; set; }
        public bool QLHasCustomerRedemption { get; set; }
        public bool QLHasScanDecal { get; set; }
        public bool QLHasInviteConsumer { get; set; }
        public bool QLHasRewards { get; set; }
        /*Logic for Flags QuickLinks -> Ends*/
        public bool CSHasPartnersOfShellClub { get; set; }
        public bool CSHasMyProfile { get; set; }
        public bool CSHasMyPoints { get; set; }
        public bool CSHasPerformance { get; set; }
        public bool HasDRWorkshopPerformance { get; set; }
        /*FA Carousel*/
        public string FAShareCode { get; set; }
        public string FAShareQRCode { get; set; }
        public string ShareQRCode { get; set; }
        public bool CSHasBadge { get; set; }
        public bool HasWorkshopAcademy { get; set; }
        public double CTNIncrement { get; set; }
        public bool QLHasWorkshopAcademy { get; set; }
        public string WorkshopAcademyURL { get; set; }
        public bool CSHasFABadge { get; set; }
        public bool CSHasFAPerformance { get; set; }
        public bool CSHasOutletPerformance { get; set; }
        public bool CSHasOutletPerformanceV2 { get; set; }

        public bool HasMyPointsViewDetails { get; set; }
        public bool IsMyPointsOpt1 { get; set; }
        public bool IsMyPointsOpt2 { get; set; }
        public bool IsManageStaffOpt1 { get; set; }
        public bool IsManageStaffOpt2 { get; set; }
        public bool IsParticipatingProductsOpt1 { get; set; }
        public bool IsParticipatingProductsOpt2 { get; set; }

        /*Added for hiding Manage Staff in DSR view for SPS/WS and MCO*/
        public bool HasDSRManageStaff { get; set; }

        /*Added for hiding Manage Staff in DSR view for SPS/WS and MCO*/
        public bool QLHasParticipatingProducts { get; set; }
        public bool QLHasPartnersOfShellClub { get; set; }
        public bool HasLeaderBoard { get; set; }
        public bool HasWorkshopPerformanceView { get; set; }
        public bool HasCustomerRedemptionBtn { get; set; }

        /*India flags -> Begins*/
        public bool QLHasMechanicPerformance { get; set; }
        public bool QLHasManageStaff { get; set; }
        public bool HasManageMechanicPerformance { get; set; }
        public bool HasOilChangeWalkThrough { get; set; }
        public bool QLOilChangeWalkThrough { get; set; }
        public bool ShowRedemptionAddress { get; set; }
        public string ShareTagCode { get; set; }
        public bool IsAccountDeActive { get; set; }
        public bool IsPerfOpt1 { get; set; }
        public bool IsPerfOpt2 { get; set; }
        /*India flags -> Ends*/
        public bool HasMultipleSubmissionOilChange { get; set; }
		public bool IsRetail { get; set; }
		/*Added on : 18-01-2019 -> Begins*/
		#region Loyalty Program
        public bool CSHasLoyaltyProgramV2 { get; set; }
        public bool CSHasLoyaltyBDV2 { get; set; }
        public bool HasLoyaltyProgramV2 { get; set; }
        public bool QLHasLoyaltyProgramV2 { get; set; }

        public bool CSHasLoyaltyProgram { get; set; }
        public bool CSHasLoyaltyBD { get; set; }
        public bool HasLoyaltyProgram { get; set; }
        public bool QLHasLoyaltyProgram { get; set; }
        //CNY promotion
        public bool CSHasTradePromotion { get; set; }
        public bool CSHasLebaranPromotion { get; set; }
        //Company Tier
        public string CompanyCertTier { get; set; }
        public string CompanyCertTierText { get; set; }
        public string CompanyCertTierImage { get; set; }
        #endregion
        /*Added on : 2019-03-12; Reason : Ancillary OFfer ; SHARE-189; -> Begins*/
        public bool QLHasWorkShopOffer { get; set; }
        /*Added on : 2019-03-12; Reason : Ancillary OFfer ; SHARE-189; -> Ends*/
		/*India CV promotion - Begins*/
        public bool CSHasCVBooster { get; set; }
        public bool CSHasAgri { get; set; }
        /*India CV promotion - Ends*/
        public bool IsToSkipDeliveryAddress { get; set; }
        public bool HasCurrentMileage { get; set; }
        /*India HX8 promotion - Begins*/
        public bool CSHasHX8Promotion { get; set; }
        /*India HX8 promotion - Ends*/
		 /*Deepan for India*/
        public bool QLCashIncentive { get; set; }
        public bool HasCashIncentive { get; set; }

        /*Added by KR on 20/06/19 - Online Ordering changes - begins*/
        public bool HasManageOrder { get; set; }
        /*Added by KR on 20/06/19 - Online Ordering changes - ends*/

            /*VN Rmiula*/
        public bool HasVehicleType { get; set; }
        public int NextExpiryPoints { get; set; }
        public string NextExpiryDate { get; set; }
    }
    public class CountryPostalList
    {
        public CountryPostal PostalDetails { get; set; }
    }
    public class CountryPostal
    {
        public string PostalCode { get; set; }
        public string TownId { get; set; }
        public string TownName { get; set; }
        public string StateId { get; set; }
    }
    public class MyPoints
    {
        public string BalancePoints { get; set; }
        public string PointsToReachMilestone { get; set; }
        public int PointsPercentage { get; set; }
        public string PointsRedeemed { get; set; }
        public string PointsExpiringMonth { get; set; }
        public string PointsExpiring { get; set; }
        public List<PointsExpiry> ExpiringPoints { get; set; }
        public string TotalPoints { get; set; }
        public string LastUpdateDate { get; set; }
    }
    public class ExpiryList
    {
        public PointsExpiryListVal PointsExpiryList { get; set; }
    }
    public class PointsExpiryListVal
    {
        public List<PointsExpiry> PointsExpiry { get; set; }
    }
    public class PointsExpiry
    {
        public string ExpiryDate { get; set; }
        public string PointsExpiring { get; set; }
    }
    public class MyPerformance
    {
        public string Month { get; set; }
        public int TargetScan { get; set; }
        public int AchievedScan { get; set; }
        public int AchievedScanPercentage { get; set; }
        public int TargetCustomer { get; set; }
        public int AchievedCustomer { get; set; }
        public int NumberOfWorkshops { get; set; }

        public int ReturningCustomers { get; set; }
        public int TotalOilChanges { get; set; }

        public string PerformanceKeyOne { get; set; }
        public int PerformanceValueOne { get; set; }
        public string PerformanceKeyTwo { get; set; }
        public int PerformanceValueTwo { get; set; }
        public string PerformanceKeyThree { get; set; }
        public int PerformanceValueThree { get; set; }
        public bool HasPerformanceViewDetails { get; set; }
    }
    public class MySales
    {
        public string TOProgramDateRange { get; set; }
        public int TotalVolumeOrdered { get; set; }
        public int TOPointsAccumulated { get; set; }
        public string LastUpdateDate { get; set; }
    }
	/*Added on : 18-01-2019 -> Begins*/
	#region Loyalty Contract
    public class LoyaltyContractPerformance
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SubTitle { get; set; }
        public int NoOfOverallCartons { get; set; }
        public int NoOfPremiumCartons { get; set; }
        public int PackagePeriod { get; set; }
        public int NoOfOverallOrdered { get; set; }
        public int NoOfPremiumOrdered { get; set; }
        public string ColorCodeOverall { get; set; }
        public string ColorCodePremium { get; set; }
        public int OverallTarget { get; set; }
        public int PremiumTarget { get; set; }
        public string LegendTotCartons { get; set; }
        public string ColorCodeTotCartons { get; set; }
        public string LegendPremiumTier { get; set; }
        public string ColorCodePremiumTier { get; set; }
        public string FooterText { get; set; }
        public bool isComplete { get; set; }
        public List<Month> Month { get; set; }
        public List<BreakdownLegend> BreakdownLegend { get; set; }
        public List<MonthlyBreakdown> BreakdownDetails { get; set; }
        public List<DetailedBreakdownByGroup> DetailedBreakdownByGroup { get; set; }
        public string FooterTitleBD { get; set; }
        public string FooterMin { get; set; }
        public string FooterPremium { get; set; }
        public string FooterTotal { get; set; }
        public string ColorCodeMinBD { get; set; }
        public string ColorCodePremiumBD { get; set; }
        public string ColorCodeTotalBD { get; set; }

        public int MinTarget { get; set; }
        public int MinPremiumTarget { get; set; }
        public int TotalTarget { get; set; }

    }


    #endregion

    //#region CNY Promotion
    //public class CNYPromotion
    //{
    //    public bool HasTPViewDetailsBtn { get; set; }
    //    public bool HasTPRedeemBtn { get; set; }

    //    public string TPImage { get; set; }
    //    public string TPImageUrl { get; set; }
    //    public string TPOilChangeCount { get; set; }
    //    public string TPStartDate { get; set; }
    //    public string TPEndDate { get; set; }
    //    public string TPCSHeader { get; set; }
    //    public string TPCSFooter { get; set; }
    //    public string TPDetails { get; set; }
    //    public int TPDaysLeft { get; set; }

    //}
    //#endregion

    #region Trades Promotion
    /*Lebaran Promotion - Edited*/
    //public class CNYPromotion
    public class TradesPromotion
    {
        public bool HasTPViewDetailsBtn { get; set; }
        public bool HasTPRedeemBtn { get; set; }

        public string TPImage { get; set; }
        public string TPImageUrl { get; set; }
        public string TPOilChangeCount { get; set; }
        public string TPStartDate { get; set; }
        public string TPEndDate { get; set; }
        public string TPCSHeader { get; set; }
        public string TPCSFooter { get; set; }
        public string TPDetails { get; set; }
        public int TPDaysLeft { get; set; }
        public string TPFinalMessage1 { get; set; }
        public string TPFinalMessage2 { get; set; }

    }
    #endregion


    #region India CV Booster Promotion

    public class CVBoosterPromotion
    {
        public string CVHeading { get; set; }
        public int CVTotalTarget { get; set; }
        public int CVAchievedTarget { get; set; }
        public int CVFirstTarget { get; set; }
        public int CVSecondTarget { get; set; }
        public string CVFirstRewardImage { get; set; }
        public string CVSecondRewardImage { get; set; }
        public string CVFinalRewardImage { get; set; }
        public string CVColorCode { get; set; }
        public string CVStartDate { get; set; }
        public string CVEndDate { get; set; }
        public string CVFooterText { get; set; }
        public bool CVIsComplete { get; set; }
        public string CVUpdatedAsOfText { get; set; }
        public string CVUpdatedAsOfValue { get; set; }
        //Suresh change on 13 Aug 2019
        public int CVTotalNoOfTarget { get; set; }
    }

    #endregion

    #region India Agri Promotion

    public class AgriPromotion
    {
        public string AgriHeading { get; set; }
        public int AgriTotalTarget { get; set; }
        public int AgriBoosterTotalTarget { get; set; }
        public int AgriAchievedTarget { get; set; }
        public int AgriBoosterAchievedTarget { get; set; }
        public int AgriFirstTarget { get; set; }
        public int AgriSecondTarget { get; set; }
        public int AgriBoosterFirstTarget { get; set; }
        public int AgriBoosterSecondTarget { get; set; }
        public string AgriColorCode { get; set; }
        public string AgriBoosterColorCode { get; set; }
        public string AgriStartDate { get; set; }
        public string AgriEndDate { get; set; }
        public string AgriFooterText { get; set; }
        public bool AgriIsComplete { get; set; }
        public string AgriUpdatedAsOfText { get; set; }
        public string AgriUpdatedAsOfValue { get; set; }
    }

    #endregion

    #region India HX8 Promotion
    /*India HX8 promotion - Begins*/
    public class HX8Promotion
    {

        public bool HasBtnScanNow { get; set; }
        public string HX8PromoHeading { get; set; }
        public string HX8PromoStartDate { get; set; }
        public string HX8PromoEndDate { get; set; }
        public string HX8PromoFooterText { get; set; }
        public string HX8PromoVoucherValue1 { get; set; }
        public string HX8PromoVoucherValue2 { get; set; }
        public string HX8PromoVoucherValue3 { get; set; }
        public string HX8PromoVoucherValue4 { get; set; }
        public string HX8PromoTarget1 { get; set; }
        public string HX8PromoTarget2 { get; set; }
        public string HX8PromoTarget3 { get; set; }
        public string HX8PromoTarget4 { get; set; }
        public string HX8TargetAchieved { get; set; }
    }

    /*India HX8 promotion - Begins*/
    #endregion

    #region Home Promotion

    public class HomesList
    {
        public IList<HomePromotion> Promotion { get; set; }
        public IList<HomeNews> News { get; set; }
       // public  IList<CategoryList> RewardsBanner { get; set; }
         
    }
    public class HomePromotion
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tag { get; set; }
        public string PromotionPeriod { get; set; }
        
    }
    public class HomeNews
    {

        public string Image { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tag { get; set; }
        public string PromotionPeriod { get; set; }
    }

    #endregion
}