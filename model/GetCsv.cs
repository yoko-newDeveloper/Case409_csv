﻿namespace Case409_csv.model
{
    public class GetCsv
    {

        [CsvHelper.Configuration.Attributes.Name("要求レコード番号")]
        public String RecordNumber { get; set; }


        [CsvHelper.Configuration.Attributes.Name("個人番号")]
        public String PersonalNumber { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果氏名")]
        public String InquiryResultName { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果氏名かな")]
        public String InquiryResultNameKana { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果生年月日")]
        public String InquiryResultBirth { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果性別コード")]
        public String InquiryResultGenderCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果性別")]
        public String QueryResultGender { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果住所")]
        public String InquiryResultAddress { get; set; }

        [CsvHelper.Configuration.Attributes.Name("市町村コード")]
        public String MunicipalCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("対象者識別情報")]
        public String IdentifierInfo { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会処理結果コード")]
        public String InquiryResultCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会処理結果")]
        public String InquiryProcessResult { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果レコード数")]
        public String QueryResultRecord { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果レコード連番")]
        public String RecordSequenceNumber { get; set; }

        [CsvHelper.Configuration.Attributes.Name("異動有無コード")]
        public String TransferStatusCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("異動有無")]
        public String TransferStatus { get; set; }

        [CsvHelper.Configuration.Attributes.Name("生存状況コード")]
        public String SurvivalStatusCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("生存状況")]
        public string SurvivalStatus { get; set; }

        [CsvHelper.Configuration.Attributes.Name("変更状況コード")]
        public String ChangeStatusCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("変更状況")]
        public String ChangeStatus { get; set; }

        [CsvHelper.Configuration.Attributes.Name("異動事由コード")]
        public String ChangeTransferCode { get; set; }

        [CsvHelper.Configuration.Attributes.Name("異動事由")]
        public String ReasonTransfer { get; set; }

        [CsvHelper.Configuration.Attributes.Name("異動年月日")]
        public String DateOfTransfer { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果氏名外字数")]
        public String InquirycharOutsideName { get; set; }

        [CsvHelper.Configuration.Attributes.Name("照会結果住所外字数")]
        public String InquirycharOutsideAddress { get; set; }

        [CsvHelper.Configuration.Attributes.Name("不参加団体対象フラグ")]
        public String NonParticipantFlag { get; set; }

        [CsvHelper.Configuration.Attributes.Name("不参加団体対象要因")]
        public String NonParticipantReason { get; set; }
    }
}
