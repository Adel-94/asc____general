
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace asc_general.Models
{

using System;
    using System.Collections.Generic;
    
public partial class our_complex
{

    public int id { get; set; }

    public Nullable<int> region_id { get; set; }

    public string complex_name { get; set; }

    public string address { get; set; }

    public string phone { get; set; }

    public string facebook { get; set; }

    public string instagram { get; set; }

    public Nullable<bool> edu_or_gym { get; set; }

    public string photo { get; set; }

    public string text { get; set; }

    public string map_url { get; set; }



    public virtual region region { get; set; }

}

}
