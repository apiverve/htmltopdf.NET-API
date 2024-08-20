using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("marginLeft")]
    public string marginLeft { get; set; }

    [JsonProperty("marginRight")]
    public string marginRight { get; set; }

    [JsonProperty("marginTop")]
    public string marginTop { get; set; }

    [JsonProperty("marginBottom")]
    public string marginBottom { get; set; }

    [JsonProperty("landscape")]
    public bool landscape { get; set; }

    [JsonProperty("pdfName")]
    public string pdfName { get; set; }

    [JsonProperty("expires")]
    public int expires { get; set; }

    [JsonProperty("downloadURL")]
    public string downloadURL { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
