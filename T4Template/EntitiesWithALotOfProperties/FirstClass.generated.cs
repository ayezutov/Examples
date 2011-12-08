using System;
using System.ComponentModel;

namespace T4Template.EntitiesWithALotOfProperties
{
    public partial class FirstClass
    {
        [Category("Group1")] 
        public string Property1 { get; set; }
        [Category("Group1")] 
        public DateTime Property2 { get; set; }
        [Category("Group1")] 
        public int Property3 { get; set; }

        [Category("Group2")]
        public string Property4 { get; set; }
        [Category("Group2")]
        public string Property5 { get; set; }
    }
}
