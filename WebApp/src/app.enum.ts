    //#region enums

    export enum DataType {
        Int = 0,
        Bool = 1,
        String = 2,
        Date = 3,
        Time = 4,
        Datetime = 5,
        Guid = 6,
        User = 7,
        Workgroup = 8,
        Participants = 9,
        NullableInt = 10,
        NullableGuid = 11,
        NullableBool = 12,
        NullableDate = 13,
        NullableDatetime = 14,
        NullableUser = 15,
        NullableWorkgroup = 16,
        Workgroups = 17,
        Attachments = 18,
        Text = 19,
        IncidentRootCause = 20,
        IncidentCommission = 21,
        BusinessUnit = 22,
        IncidentClassification = 23,
        SeverityMatrix = 24,
        Equipment = 25,
        TreatmentType = 26,
        Address = 27,
        Person = 28,
        PersonWorkDay = 29,
        DurationOfEmployment = 30,
        Decimal = 31,
        NullableDecimal = 32,
        WorkflowHistory = 33,
        TypeRootCause = 34,
        ChooseType = 35,
        Company = 36,
        CorrectiveActions = 37,
        InjuredPerson = 38,
        IncidentBodyInjuryParts = 39,
        BreakLine = 40, // break form row to next row
        Notes = 41,
        Coordinates = 42,
        WorkflowBookmarks = 43,
        ActionCost = 44,
        PpeRulesBook = 47,
        ReferenceNumberAutoGen = 48,
        MultiSelect = 49,
        ImageUpload = 50,
        Asset = 51,
        LinkedPpeModels = 52,
        LinkedPpeUtilizationNorms = 53,
        LinkedPpeSizes = 54,
        LinkedPpeTypeLists = 55,
        NumberPicker = 56,
        LinkToEntity = 57,
        Password = 58,
        RoleCell = 59,
        HtmlEditor = 60,
        IncidentStandardRootCause = 61,
        IncidentImmediateCause = 62,
        ActionProgrammeActionGroups = 63,
        NullableDatetimeBeforeToday = 64,
        GuidCollection = 65,
        ActionProgrammeActions = 66,
        Heading = 67,
        SelectTreeview = 68,
        ModalSelect = 69,
        LinkedAudits = 70,
        IncidentCost = 71,
        StatusKpi = 80,
        GroupedGuid = 81,
        NullableGroupedGuid = 82,
        AttachmentsStructured = 95,
        InfoLevel = 100, // use for highlight rows in datatable
        MultiselectTree = 101,
        IncidentSafetyRules = 102
    }

    export enum DateLimitType {
        BeforeToday = 0,
        BeforeTomorrow = 1,
        AfterToday = 2,
        AfterYesterday = 3
    }

    export enum ControlType {
        Textbox = 0,
        Checkbox = 1,
        Select = 2,
        DatePicker = 3,
        TimePicker = 4,
        DatetimePicker = 5,
        UserPicker = 6,
        WorkgroupPicker = 7,
        MultipleWorkgroupPicker = 8,
        ParticipantsPicker = 9,
        NumberPicker = 10,
        Textarea = 11,
        InputTags = 12
    }

    export enum Module {
        General = 0,
        Action = 1,
        Incident = 2,
        Vfl = 3,
        Dashboard = 4,
        Help = 5,
        Reports = 6,
        Admin = 7,
        Audit = 8,
        ActionIncident = 9,
        ActionProgrammes = 10,
        Programmes = 11,
        Risk = 12,
        AuditSchedule = 13,
        PpeType = 14,
        PpeSet = 15,
        PpeModel = 16,
        ActionProgrammeAction = 17,
        PpeUtilizationNorm = 18,
        PpeRulesBook = 19,
        PpeSize = 20,
        PpeTypeList = 21,
        User = 22,
        UserRole = 23,
        Group = 24,
        UserEmail = 25,
        Asset = 30,
        Equipment =31
    }

    export enum Operator {
        Equal = 0,
        LessThan = 1,
        GreaterThan = 2,
        LessThanOrEqual = 3,
        GreaterThanOrEqual = 4,
        NotEqual = 5,
        Contains = 6,
        In = 7
    }

    export enum DatatablesColumnDefType {
        String = 0,
        Date = 1,
        Num = 2,
        Html = 3
    }

    export enum PropertyAffectedByRule {
        Value = 0,
        IsVisible = 1,
        IsDisabled = 2,
        Min = 3,
        Max = 4
    }

    export enum FormControlWidth {
        Small = 0, // col-3
        Medium = 1,// col-6 - by default in the DB
        Large = 2, // col-9
        Full = 3 // col-12
    }

    export enum WorkgroupSelector {
        All = 0,
        Primary,
        Secondary
    }

    export enum DocumentSource {
        RiskDocument = 0,
        ProjectDocument = 1,
        IncidentDocument = 2,
        PeopleDocument = 3,
        CompanyDocument = 4,
        GeneralDocument = 5,
        AuditDocument = 6,
        CSRDocument = 7,
        EquipmentDocument = 8,
    }

    export enum IconType {
        ActionKPI = 0
    }

    export enum ActionType {
        View = 0,
        New = 1,
        Edit = 2,
        List = 3
    }

    export enum ExportType {
        All = 0,
        Page = 1,
        SelectedItems = 2
    }

    export enum ExportFormat {
        Xls = 0,
        Pdf = 1
    }

    export enum IncidentRootCauseType {
        Direct = 0,
        Basic = 1,
        Root = 2
    }

    export enum WorkflowBookmarkType {
        None = 0,
        Approve = 1,
        Decline = 2,
        Reject = 3,
        Cancel = 4,
        Close = 5,
        Reopen = 6,
        Review = 7,
        Reassign = 8,
        Defer = 9,
        ChooseInvestigator = 10,
        WarningNote = 999
    }

export enum TableToModule {
  TBL_Equipment = 31,
}

    //#endregion

