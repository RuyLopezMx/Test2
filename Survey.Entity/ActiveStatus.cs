﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ActiveStatus : EntityBase
    {
        public ActiveStatus()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }


        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}