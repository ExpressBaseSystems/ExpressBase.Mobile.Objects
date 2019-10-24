using ExpressBase.Mobile.Common.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressBase.Mobile.Objects
{
    public class EbGroupBox : EbControlContainer
    {
        public override string Label { get; set; }

        public bool HideBorder { get; set; }
    }
}
