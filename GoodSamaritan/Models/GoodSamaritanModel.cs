namespace GoodSamaritan.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GoodSamaritan.Models.LookupTables;

    public class GoodSamaritanModel : DbContext
    {
        // Your context has been configured to use a 'GoodSamaritanModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GoodSamaritan.Models.GoodSamaritanModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GoodSamaritanModel' 
        // connection string in the application configuration file.
        public GoodSamaritanModel()
            : base("name=GoodSamaritanModel")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<GoodSamaritanModel>()); // always drops and recreates database
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<UserModel> UserModel { get; set; }

        public virtual DbSet<ClientModel> ClientModel { get; set; }

        public virtual DbSet<SmartModel> SmartModel { get; set; }

        /* -- CLIENT LOOKUPS -- */
        public virtual DbSet<AbuserRelationshipModel> AbuserRelationshipModel { get; set; }

        public virtual DbSet<AgeModel> AgeModel { get; set; }

        public virtual DbSet<AssignedWorkerModel> AssignedWorkerModel { get; set; }

        public virtual DbSet<CrisisModel> CrisisModel { get; set; }

        public virtual DbSet<DuplicateFileModel> DuplicateFileModel { get; set; }

        public virtual DbSet<EthnicityModel> EthnicityModel { get; set; }

        public virtual DbSet<FamilyViolenceModel> FamilyViolenceModel { get; set; }

        public virtual DbSet<FiscalYearModel> FiscalYearModel { get; set; }

        public virtual DbSet<IncidentModel> IncidentModel { get; set; }

        public virtual DbSet<ProgramModel> ProgramModel { get; set; }

        public virtual DbSet<ReferralContactModel> ReferralContactModel { get; set; }

        public virtual DbSet<ReferralSourceModel> ReferralSourceModel { get; set; }

        public virtual DbSet<RepeatClientModel> RepeatClientModel { get; set; }

        public virtual DbSet<RiskLevelModel> RiskLevelModel { get; set; }

        public virtual DbSet<RiskStatusModel> RiskStatusModel { get; set; }

        public virtual DbSet<ServiceModel> ServiceModel { get; set; }

        public virtual DbSet<StatusOfFileModel> StatusOfFileModel { get; set; }

        public virtual DbSet<VictimOfIncidentModel> VictimOfIncidentModel { get; set; }

        /* -- SMART LOOKUPS -- */

        public virtual DbSet<BadDateReportModel> BadDateReportModel { get; set; }

        public virtual DbSet<CityOfAssaultModel> CityOfAssaultModel { get; set; }

        public virtual DbSet<CityOfResidenceModel> CityOfResidenceModel { get; set; }

        public virtual DbSet<DrugFacilitatedAssaultModel> DrugFacilitatedAssaultModel { get; set; }

        public virtual DbSet<EvidenceStoredModel> EvidenceStoredModel { get; set; }

        public virtual DbSet<HIVMedsModel> HIVMedsModel { get; set; }

        public virtual DbSet<HospitalAttendedModel> HospitalAttendedModel { get; set; }

        public virtual DbSet<MedicalOnlyModel> MedicalOnlyModel { get; set; }

        public virtual DbSet<MultiplePerpetratorsModel> MultiplePerpetratorsModel { get; set; }

        public virtual DbSet<PoliceAttendanceModel> PoliceAttendanceModel { get; set; }

        public virtual DbSet<PoliceReportedModel> PoliceReportedModel { get; set; }

        public virtual DbSet<ReferralHospitalModel> ReferralHospitalModel { get; set; }

        public virtual DbSet<ReferredCBVSModel> ReferredCBVSModel { get; set; }

        public virtual DbSet<SocialWorkAttendanceModel> SocialWorkAttendanceModel { get; set; }

        public virtual DbSet<ThirdPartyReportModel> ThirdPartyReportModel { get; set; }

        public virtual DbSet<VictimServicesModel> VictimServicesModel { get; set; }

        public virtual DbSet<Work_ExploitationModel> Work_ExploitationModel { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}