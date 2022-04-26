﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clima
{
    public class ClimaDTO
    {
        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("currentConditions")]
        public CurrentConditions CurrentConditions { get; set; }

        [JsonPropertyName("next_days")]
        public List<NextDay> NextDays { get; set; }

        [JsonPropertyName("contact_author")]
        public ContactAuthor ContactAuthor { get; set; }

        [JsonPropertyName("data_source")]
        public string DataSource { get; set; }
    }

    public class Temp
    {
        [JsonPropertyName("c")]
        public int C { get; set; }

        [JsonPropertyName("f")]
        public int F { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("km")]
        public int Km { get; set; }

        [JsonPropertyName("mile")]
        public int Mile { get; set; }
    }

    public class CurrentConditions
    {
        [JsonPropertyName("dayhour")]
        public string Dayhour { get; set; }

        [JsonPropertyName("temp")]
        public Temp Temp { get; set; }

        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        [JsonPropertyName("iconURL")]
        public string IconURL { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }

    public class MaxTemp
    {
        [JsonPropertyName("c")]
        public int C { get; set; }

        [JsonPropertyName("f")]
        public int F { get; set; }
    }

    public class MinTemp
    {
        [JsonPropertyName("c")]
        public int C { get; set; }

        [JsonPropertyName("f")]
        public int F { get; set; }
    }

    public class NextDay
    {
        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("max_temp")]
        public MaxTemp MaxTemp { get; set; }

        [JsonPropertyName("min_temp")]
        public MinTemp MinTemp { get; set; }

        [JsonPropertyName("iconURL")]
        public string IconURL { get; set; }
    }

    public class ContactAuthor
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("auth_note")]
        public string AuthNote { get; set; }
    }
}
