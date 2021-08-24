namespace AHClaim.domain.Segment
{
    public class DrugClassificationSegment
    {
        /// <summary> 
        /// Field #: 3 
        /// Field Name: Category Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Class Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string ClassCode { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: GC1 Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string Gc1Code { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: GC2 Code 
        /// Format: AN 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string Gc2Code { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: GC3 Code 
        /// Format: AN 
        /// Length: 3 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string Gc3Code { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: GC4 Code 
        /// Format: AN 
        /// Length: 4 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string Gc4Code { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Specific Therapeutic Class 
        /// Format: AN 
        /// Length: 3 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string SpecificTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: GCN Code 
        /// Format: N 
        /// Length: 5 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string GcnCode { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: GCN Sequence Number 
        /// Format: N 
        /// Length: 6 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string GcnSequenceNumber { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: Standard Therapeutic Class 
        /// Format: N 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string StandardTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: Generic Therapeutic Class 
        /// Format: N 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string GenericTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: AHFS Therapeutic Class 
        /// Format: N 
        /// Length: 6 
        /// Definition: Code from Drug file
        /// </summary>
        public string AhfsTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: Orange Book Code 
        /// Format: AN 
        /// Length: 3 
        /// Definition: Code from Drug file
        /// </summary>
        public string OrangeBookCode { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Route of Administration Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string RouteOfAdministrationCode { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Drug Form Code (Unit of Measure) 
        /// Format: N 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        public string DrugFormCodeUnitOfMeasure { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: DEA Code 
        /// Format: N 
        /// Length: 1 
        /// Definition: Code from Drug file
        /// </summary>
        public string DeaCode { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Maintenance Drug Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        public string MaintenanceDrugIndicator { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: Unit of Use Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        public string UnitOfUseIndicator { get; set; }

        /// <summary> 
        /// Field #: 21 
        /// Field Name: Repackage Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        public string RepackageIndicator { get; set; }

        /// <summary> 
        /// Field #: 22 
        /// Field Name: Unit Dose Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        public string UnitDoseIndicator { get; set; }

        /// <summary> 
        /// Field #: 23 
        /// Field Name: DESI Drug Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        public string DesiDrugIndicator { get; set; }

        /// <summary> 
        /// Field #: 24 
        /// Field Name: Drug Obsolete Date 
        /// Format: N 
        /// Length: 8 
        /// Definition: Date that NDC became obsolete
        /// </summary>
        public string DrugObsoleteDate { get; set; }

        /// <summary> 
        /// Field #: 25 
        /// Field Name: Medispan GPI 
        /// Format: AN 
        /// Length: 14 
        /// Value: Medispan Code from Drug file
        /// </summary>
        public string MedispanGpi { get; set; }

        /// <summary> 
        /// Field #: 26 
        /// Field Name: Reserved for Future Use 
        /// Length: 11
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}