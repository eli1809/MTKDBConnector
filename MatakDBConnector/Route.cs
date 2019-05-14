using System;
using Npgsql;

namespace MatakDBConnector
{
    public class Route: DbConnector
    {
        private int routeId;
        private string name;
        private DateTime startDatetime;
        private DateTime endDatetime;
        private int geojsonDocId;
        private int reasonId;
        private int priorityId;
        private int statusId;
        private int orgId;
        private int createdByUserId;
        private int sentToUserId;
        private int approvedByUserId;
        private string note;
        private string geoJsonString;

        public Route()
        {
            routeId = 0;
            name = "0";
            startDatetime = DateTime.Now;
            endDatetime = DateTime.Now;
            geojsonDocId = 0;
            reasonId = 0;
            priorityId = 0;
            statusId = 0;
            orgId = 0;
            createdByUserId = 0;
            sentToUserId = 0;
            approvedByUserId = 0;
            note = "0";
            geoJsonString = "0";
        }
        
        public Route(int routeId, string name, DateTime startDatetime, DateTime endDatetime, int geojsonDocId,
            int reasonId, int priorityId, int statusId, int orgId, int createdByUserId, int sentToUserId,
            int approvedByUserId, string note, string geoJsonString)
        {
            this.routeId = routeId;
            this.name = name;
            this.startDatetime = startDatetime;
            this.endDatetime = endDatetime;
            this.geojsonDocId = geojsonDocId;
            this.reasonId = reasonId;
            this.priorityId = priorityId;
            this.statusId = statusId;
            this.orgId = orgId;
            this.createdByUserId = createdByUserId;
            this.sentToUserId = sentToUserId;
            this.approvedByUserId = approvedByUserId;
            this.note = note;
            this.geoJsonString = geoJsonString;
        }

        public Route RouteMaker(NpgsqlDataReader reader)
        {
            RouteId = reader.GetInt32(0);
            Name = reader.GetString(1);
            StartDatetime = reader.GetDateTime(2);
            EndDatetime = reader.GetDateTime(3);
            GeojsonDocId = reader.GetInt32(4);
            ReasonId = reader.GetInt32(5);
            PriorityId = reader.GetInt32(6);
            StatusId = reader.GetInt32(7);
            OrgId = reader.GetInt32(8);
            CreatedByUserId = reader.GetInt32(9);
            SentToUserId = reader.GetInt32(10);
            ApprovedByUserId = reader.GetInt32(11);
            Note = reader.GetString(12);
            GeoJsonString = reader.GetString(13);

            return this;
        }

        public int RouteId
        {
            get => routeId;
            set => routeId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime StartDatetime
        {
            get => startDatetime;
            set => startDatetime = value;
        }

        public DateTime EndDatetime
        {
            get => endDatetime;
            set => endDatetime = value;
        }

        public int GeojsonDocId
        {
            get => geojsonDocId;
            set => geojsonDocId = value;
        }

        public int ReasonId
        {
            get => reasonId;
            set => reasonId = value;
        }

        public int PriorityId
        {
            get => priorityId;
            set => priorityId = value;
        }

        public int StatusId
        {
            get => statusId;
            set => statusId = value;
        }

        public int OrgId
        {
            get => orgId;
            set => orgId = value;
        }

        public int CreatedByUserId
        {
            get => createdByUserId;
            set => createdByUserId = value;
        }

        public int SentToUserId
        {
            get => sentToUserId;
            set => sentToUserId = value;
        }

        public int ApprovedByUserId
        {
            get => approvedByUserId;
            set => approvedByUserId = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public string GeoJsonString
        {
            get => geoJsonString;
            set => geoJsonString = value;
        }
    }
}