using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace EConnectDocEx
{
    public class GridTables
    {
        // TableClasses
        //DataTable FileDocTable = CreateDataTable(typeof(FileDoc));

        public class FileDoc
        {
            public string FileName { get; set; }
            public DateTime FileCreationDate { get; set; }
            public string FileSize { get; set; }

            public bool ValidInvoice { get; set; }
            public string InvoiceID { get; set; }
            public string TotalAmount { get; set; }
            public string ReceiverName { get; set; }
            public string ReceiverID { get; set; }
            public string ReceiverContact { get; set; }
            public string ReceiverValid { get; set; }

            public string FullFilePath { get; set; }
        }

        //DataTable InboxDocTable = CreateDataTable(typeof(InboxDoc));

        public class InboxDoc
        {
            //public string Rowkey { get; set; }

            //public string DocumentId { get; set; }
            public string ExternalId { get; set; }
            //public string ConsignmentId { get; set; }
            public string ConsignmentName { get; set; }
            public string Subject { get; set; }
            public string Type { get; set; }

            public string SenderAccountId { get; set; }
            public string SenderAccountName { get; set; }
            public string SenderUserId { get; set; }
            public string SenderUserName { get; set; }
            public string SenderEntityId { get; set; }
            public string SenderEntityName { get; set; }

            public long CreatedDateTime { get; set; }

            // TODO: to string[] comma separeted?
            public string PossibleConsignmentStatuses { get; set; }
            public bool IsRead { get; set; }
            // TODO: Check IsTask is not bool?
            public int IsTask { get; set; }
            public string LatestStatus { get; set; }
            public string LatestStatusInfo { get; set; }
            // TODO: string to int?
            public string LatestStatusCode { get; set; }

            public string ReceiverEntityId { get; set; }
            public string ReceiverEntityName { get; set; }

            public string StandardTemplateId { get; set; }
            public string StandardTemplateName { get; set; }

            public string DocumentViewerId { get; set; }
            public string DocumentViewerName { get; set; }
        }

        public class OutboxDoc
        {
            //public string Rowkey { get; set; }

            //public string DocumentId { get; set; }
            public string ExternalId { get; set; }
            //public string ConsignmentId { get; set; }
            public string ConsignmentName { get; set; }
            public string Subject { get; set; }
            public string Type { get; set; }

            public string SenderAccountId { get; set; }
            public string SenderAccountName { get; set; }
            public string SenderUserId { get; set; }
            public string SenderUserName { get; set; }
            public string SenderEntityId { get; set; }
            public string SenderEntityName { get; set; }

            public long CreatedDateTime { get; set; }

            // TODO: to string[] comma separeted?
            public string PossibleConsignmentStatuses { get; set; }
            public bool IsRead { get; set; }
            // TODO: Check IsTask is not bool?
            public int IsTask { get; set; }
            public string LatestStatus { get; set; }
            public string LatestStatusInfo { get; set; }
            // TODO: string to int?
            public string LatestStatusCode { get; set; }

            public string ReceiverEntityId { get; set; }
            public string ReceiverEntityName { get; set; }

            public string StandardTemplateId { get; set; }
            public string StandardTemplateName { get; set; }

            public string DocumentViewerId { get; set; }
            public string DocumentViewerName { get; set; }
        }


        // Helpers

        public static DataTable CreateDataTable(Type doctype)
        {
            DataTable return_Datatable = new DataTable();
            foreach (PropertyInfo info in doctype.GetProperties())
            {
                return_Datatable.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }
            return return_Datatable;
        }


        public static DataRow makeRow(object input, DataTable table)
        {
            Type inputtype = input.GetType();
            DataRow row = table.NewRow();
            foreach (PropertyInfo info in inputtype.GetProperties())
            {
                row[info.Name] = info.GetValue(input, null);
            }
            return row;
        }
    }
}
