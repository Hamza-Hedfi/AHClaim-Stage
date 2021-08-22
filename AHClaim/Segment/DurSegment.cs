namespace AHClaim.Segment
{
    public class DurSegment
    {
        /// <summary>
        /// Field #: 3 
        /// Field Name: DUR 1 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        public string Dur1ConflictCode { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: DUR 1 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        public string Dur1SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: DUR 1 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        public string Dur1HitDisposition { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: DUR 1 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        public string Dur1ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: DUR 2 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        public string Dur2ConflictCode { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: DUR 2 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>

        public string Dur2SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: DUR 2 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        public string Dur2HitDisposition { get; set; }

        /// <summary>
        /// Field #: 10 
        /// Field Name: DUR 2 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        public string Dur2ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 11 
        /// Field Name: DUR 3 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        public string Dur3ConflictCode { get; set; }

        /// <summary>
        /// Field #: 12 
        /// Field Name: DUR 3 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        public string Dur3SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 13 
        /// Field Name: DUR 3 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        public string Dur3HitDisposition { get; set; }

        /// <summary>
        /// Field #: 14 
        /// Field Name: DUR 3 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        public string Dur3ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 15 
        /// Field Name: DUR 4 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        public string Dur4ConflictCode { get; set; }

        /// <summary>
        /// Field #: 16 
        /// Field Name: DUR 4 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        public string Dur4SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 17 
        /// Field Name: DUR 4 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        public string Dur4HitDisposition { get; set; }

        /// <summary>
        /// Field #: 18 
        /// Field Name: DUR 4 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        public string Dur4ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 19 
        /// Field Name: DUR 5 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        public string Dur5ConflictCode { get; set; }

        /// <summary>
        /// Field #: 20 
        /// Field Name: DUR 5 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        public string Dur5SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 21 
        /// Field Name: DUR 5 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        public string Dur5HitDisposition { get; set; }

        /// <summary>
        /// Field #: 22 
        /// Field Name: DUR 5 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        public string Dur5ConflictingAuthorizationNumber { get; set; }
    }
}